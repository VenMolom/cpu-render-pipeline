using GK4.Objects;
using GK4.Rendering.Edges;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace GK4.Rendering
{
    internal static class Renderer
    {
        private static float[,] zbuffer;
        public static FragColor AmbientLight { get; set; } = new FragColor(0.2f, 0.2f, 0.2f);
        public static bool BackfaceCulling { get; set; } = true;
        public static bool PerspectiveCorrection { get; set; } = true;
        public static bool Wireframe { get; set; } = false;
        public static bool ZBuffering { get; set; } = true;

        public static void ClearZBuffer()
        {
            for (int i = 0; i < zbuffer.GetLength(0); ++i)
            {
                for (int j = 0; j < zbuffer.GetLength(1); ++j)
                {
                    zbuffer[i, j] = float.PositiveInfinity;
                }
            }
        }

        public static void CreateZBuffer(Size size)
        {
            zbuffer = new float[size.Width, size.Height];
        }

        public static void Render(DirectBitmap bitmap, Vector4[,] vertices, Vector4[,] normals, Vector4[,] tangents, Vector4[,] binormals, Vector2[,] textureCoords, Matrix4x4 model, Matrix4x4 view, Matrix4x4 projection,
                            Size size, Vector3 cameraPos, Material material, IList<Light> lights, DirectBitmap texture, DirectBitmap normalMap)
        {
            var transform = projection * (view * model);
            Matrix4x4.Inverse(Matrix4x4.Transpose(model), out var normalMatrix);
            var viewPoint = new Vector4(size.Width / 2f, size.Height / 2f, 0);

            for (int i = 0; i < vertices.GetLength(0); ++i)
            {
                var v1 = new Vertex(transform * vertices[i, 0],
                    new Vector3(normalMatrix * normals[i, 0]),
                    new Vector3(normalMatrix * tangents[i, 0]),
                    new Vector3(normalMatrix * binormals[i, 0]),
                    new Vector3(model * vertices[i, 0]),
                    textureCoords[i, 0]);
                var v2 = new Vertex(transform * vertices[i, 1],
                    new Vector3(normalMatrix * normals[i, 1]),
                    new Vector3(normalMatrix * tangents[i, 1]),
                    new Vector3(normalMatrix * binormals[i, 1]),
                    new Vector3(model * vertices[i, 1]),
                    textureCoords[i, 1]);
                var v3 = new Vertex(transform * vertices[i, 2],
                    new Vector3(normalMatrix * normals[i, 2]),
                    new Vector3(normalMatrix * tangents[i, 2]),
                    new Vector3(normalMatrix * binormals[i, 2]),
                    new Vector3(model * vertices[i, 2]),
                    textureCoords[i, 2]);

                var screenVertices = Clipping(v1, v2, v3).Select(v => v.ToScreenCoords(size)).ToList();

                if (screenVertices.Count < 3) continue;

                if (BackfaceCulling && !IsClockwise(screenVertices, viewPoint)) continue;

                if (Wireframe)
                {
                    DrawPolygon(bitmap, screenVertices);
                }
                else
                {
                    FillPolygon(bitmap, screenVertices, cameraPos, material, lights, texture, normalMap);
                }
                //graphics.DrawPolygon(Pens.Black, points.Select(p => p.ToPointF()).ToArray());
            }
        }

        private static FragColor CalculatePixelColor(Vector3 position, Vector3 normal, Vector2 texCoords, Vector3 cameraPos, Material material, IList<Light> lights, DirectBitmap texture)
        {
            var pixelColor = new FragColor();
            var kd = texture?.GetPixel(texCoords) ?? material.DiffuseColor;
            foreach (var light in lights)
            {
                // diffuse
                var lightDir = (light.Position - position).Normalized;
                var diff = Math.Max(Vector3.Dot(normal, lightDir), 0);
                var diffuse = diff * kd * light.DiffuseLight;

                // specular
                var viewDir = (cameraPos - position).Normalized;
                var reflectDir = Vector3.Reflect(-lightDir, normal);
                var spec = (float)Math.Pow(Math.Max(Vector3.Dot(viewDir, reflectDir), 0.0f), material.Shininess);
                var specular = spec * material.SpecularColor * light.SpecularLight;

                pixelColor += material.AmbientColor * AmbientLight + (diffuse + specular) * GetAttenuation(light, position);
            }
            return pixelColor;
        }

        // coś nie tak z clipowaniem przy Y
        private static IEnumerable<Vertex> Clipping(Vertex v1, Vertex v2, Vertex v3)
        {
            var vertices = new List<Vertex> { v1, v2, v3 };
            var newVertices = new List<Vertex>();

            for (int i = 1; i <= 6; ++i) // loop over all planes
            {
                var a = vertices[vertices.Count - 1];
                for (int j = 0; j < vertices.Count; ++j) // loop over all current vertices
                {
                    var b = vertices[j];

                    var distA = DistanceI(a, i);
                    var distB = DistanceI(b, i);

                    if (distB > 0) // b inside
                    {
                        if (distA > 0) // a inside
                        {
                            newVertices.Add(b);
                        }
                        else
                        {
                            newVertices.Add(Intersect(a, distA, b, distB));
                            newVertices.Add(b);
                        }
                    }
                    else // b outside
                        if (distA > 0) // a inside
                    {
                        newVertices.Add(Intersect(a, distA, b, distB));
                    }

                    a = b;
                }

                (vertices, newVertices) = (newVertices, vertices);
                newVertices.Clear();

                if (vertices.Count == 0) break;
            }

            return vertices;
        }

        private static float DistanceI(Vertex v, int i)
        {
            switch (i)
            {
                case 1:
                    return v.ScreenPosition.W - v.ScreenPosition.X;

                case 2:
                    return v.ScreenPosition.W + v.ScreenPosition.X;

                case 3:
                    return v.ScreenPosition.W - v.ScreenPosition.Y;

                case 4:
                    return v.ScreenPosition.W + v.ScreenPosition.Y;

                case 5:
                    return v.ScreenPosition.W - v.ScreenPosition.Z;

                case 6:
                    return v.ScreenPosition.W + v.ScreenPosition.Z;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static void DrawLine(DirectBitmap bitmap, Vector4 p1, Vector4 p2)
        {
            int x0 = (int)Math.Round(p1.X), y0 = (int)Math.Round(p1.Y), x1 = (int)Math.Round(p2.X), y1 = (int)Math.Round(p2.Y);

            bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            if (steep) { Swap(ref x0, ref y0); Swap(ref x1, ref y1); }
            if (x0 > x1) { Swap(ref x0, ref x1); Swap(ref y0, ref y1); }
            int dX = x1 - x0, dY = Math.Abs(y1 - y0), err = dX / 2, ystep = y0 < y1 ? 1 : -1, y = y0;

            for (int x = x0; x <= x1; ++x)
            {
                if (steep) SetPixelIfInside(bitmap, y, x, FragColor.Black);
                else SetPixelIfInside(bitmap, x, y, FragColor.Black);
                err = err - dY;
                if (err < 0) { y += ystep; err += dX; }
            }
        }

        private static void DrawPolygon(DirectBitmap bitmap, IList<Vertex> points)
        {
            var p = points[points.Count - 1];
            for (int i = 0; i < points.Count; ++i)
            {
                var s = points[i];
                DrawLine(bitmap, p.ScreenPosition, s.ScreenPosition);
                p = s;
            }
        }

        // TODO: add more lights and ambient and material setable
        private static void FillPixelsInRange(DirectBitmap bitmap, int y, Range range, Vector3 cameraPos, Material material, IList<Light> lights, DirectBitmap texture, DirectBitmap normalMap)
        {
            int x1 = (int)Math.Round(range.X1);
            int x2 = (int)Math.Round(range.X2);

            var q = 0f;
            var qDiff = 1f / (x2 - x1);

            var z = range.Z1;
            var zDiff = Interpolation.Diff(range.Z1, range.Z2, qDiff);

            Parallel.For(0, x2 - x1, i =>
            {
                var x = x1 + i;
                var currentZ = z + i * zDiff;

                if (ZBuffering)
                {
                    if (zbuffer[x, y] <= currentZ) return;
                    zbuffer[x, y] = currentZ;
                }

                var currentQ = q + i * qDiff;

                var texCoords = Interpolation.Interpolate(range.TextureCoords1, range.TextureCoords2, currentQ, range.W1, range.W2, PerspectiveCorrection);
                var normal = Interpolation.Interpolate(range.Normal1, range.Normal2, currentQ, range.W1, range.W2, PerspectiveCorrection);
                if (normalMap != null)
                {
                    normal = NormalMapVector(normal,
                        Interpolation.Interpolate(range.Tangent1, range.Tangent2, currentQ, range.W1, range.W2, PerspectiveCorrection),
                        Interpolation.Interpolate(range.Binormal1, range.Binormal2, currentQ, range.W1, range.W2, PerspectiveCorrection),
                        Vector3.FromNormalMap(normalMap, texCoords));
                }

                var pixelColor = CalculatePixelColor(
                    Interpolation.Interpolate(range.Position1, range.Position2, currentQ, range.W1, range.W2, PerspectiveCorrection),
                    normal.Normalized,
                    texCoords,
                    cameraPos, material, lights, texture);
                SetPixelIfInside(bitmap, x, y, pixelColor);
            });
        }

        // add light itd
        private static void FillPolygon(DirectBitmap bitmap, IList<Vertex> screenVertices, Vector3 cameraPos, Material material, IList<Light> lights, DirectBitmap texture, DirectBitmap normalMap)
        {
            EdgeTable edgeTable = new EdgeTable();
            for (int i = 0; i < screenVertices.Count - 1; ++i)
            {
                edgeTable.AddEdge(screenVertices[i], screenVertices[i + 1], PerspectiveCorrection);
            }
            edgeTable.AddEdge(screenVertices[screenVertices.Count - 1], screenVertices[0], PerspectiveCorrection);

            ActiveEdgeTable activeEdgeTable = new ActiveEdgeTable();
            int y = edgeTable.FirstIndex;
            while (!activeEdgeTable.Empty || edgeTable.Count > 0)
            {
                activeEdgeTable.AddEdges(edgeTable[y]);

                var ranges = activeEdgeTable.GetFillRanges();
                foreach (var range in ranges)
                {
                    FillPixelsInRange(bitmap, y, range, cameraPos, material, lights, texture, normalMap);
                }

                y++;
                activeEdgeTable.RemoveEdges(y);
                activeEdgeTable.Increase();
            }
        }

        private static float GetAttenuation(Light light, Vector3 position)
        {
            var distance = (light.Position - position).Length;
            return 1f / (light.Attenuation.X + light.Attenuation.Y * distance + light.Attenuation.Z * distance * distance);
        }

        private static Vertex Intersect(Vertex a, float distA, Vertex b, float distB)
        {
            var distC = distA / (distA - distB);
            return a * (1 - distC) + b * distC;
        }

        private static bool IsClockwise(IList<Vertex> vertices, Vector4 viewPoint)
        {
            var v1 = vertices[0].ScreenPosition;
            var v2 = vertices[1].ScreenPosition;
            var v3 = vertices[2].ScreenPosition;
            var n = Vector4.Cross(v2 - v1, v3 - v1);
            var w = Vector4.Dot(n, v1 - viewPoint);

            return w <= 0;
        }

        private static Vector3 NormalMapVector(Vector3 normal, Vector3 tangent, Vector3 binormal, Vector3 normalMapColor)
        {
            return (Matrix3x3.TBN(tangent, binormal, normal) * normalMapColor.Normalized).Normalized;
        }

        private static void SetPixelIfInside(DirectBitmap bitmap, int x, int y, FragColor color)
        {
            if (x > 0 && x < bitmap.Width && y > 0 && y < bitmap.Height)
                bitmap.SetPixel(x, y, color);
        }

        private static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp; temp = lhs; lhs = rhs; rhs = temp;
        }
    }
}