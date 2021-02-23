using GK4.Controls;
using System;

namespace GK4.Objects
{
    public class Cone : RenderObject3D
    {
        private float h = 1f;
        private int n = 5;
        private float r = 1f;

        public Cone()
        {
        }

        public Cone(Scene scene)
        {
            Control = new ConeControl(this, scene);
        }

        public float H
        {
            get => h;
            set
            {
                h = value;
                SetVectors();
            }
        }

        public int N
        {
            get => n;
            set
            {
                n = value;
                SetVectors();
            }
        }

        public override string Name => "Cone";

        public float R
        {
            get => r;
            set
            {
                r = value;
                SetVectors();
            }
        }

        public override void OnDeserialization(Scene scene)
        {
            Control = new ConeControl(this, scene);
            SetVectors();
        }

        protected override void SetVectors()
        {
            var phiStep = (float)(2 * Math.PI / n);

            var trianglesCount = 4 * n;
            vertices = new Vector4[trianglesCount, 3];
            normals = new Vector4[trianglesCount, 3];
            tangents = new Vector4[trianglesCount, 3];
            binormals = new Vector4[trianglesCount, 3];
            textureCoords = new Vector2[trianglesCount, 3];

            var currentTriangle = 0;
            var height = h / 2f;
            for (int j = 0; j < n; ++j)
            {
                var phi = j * phiStep;
                var phi2 = phi + phiStep;

                SetTriangeVectors(currentTriangle++, phi, phi2, height);
            }

            var bottom = new Vector3(0f, -height, 0f);
            for (int j = 0; j < n; ++j)
            {
                var phi = j * phiStep;
                var phi2 = phi + phiStep;

                SetCircleTriangeVectors(currentTriangle,
                    GetSphereVertice(phi, -height),
                    bottom,
                    GetSphereVertice(phi2, -height));

                SetTexCoord(currentTriangle, 0, 0.5f, phi);
                SetTexCoord(currentTriangle, 1, 1f, phi);
                SetTexCoord(currentTriangle++, 2, 0.5f, phi2);
            }
        }

        private Vector3 GetSphereBinormals(float phi)
        {
            return new Vector3(
                -(float)Math.Sin(phi),
                0,
                (float)Math.Cos(phi));
        }

        private Vector3 GetSphereVertice(float phi, float height)
        {
            return new Vector3(
                (float)(r * Math.Cos(phi)),
                height,
                (float)(r * Math.Sin(phi)));
        }

        private void SetCircleTriangeVectors(int triangleIndex, Vector3 v1, Vector3 v2, Vector3 v3)
        {
            vertices[triangleIndex, 0] = new Vector4(v1, 1f);
            vertices[triangleIndex, 1] = new Vector4(v2, 1f);
            vertices[triangleIndex, 2] = new Vector4(v3, 1f);

            var sign = Math.Sign(v1.Y);
            normals[triangleIndex, 0] = (Vector4.Up * sign).Normalized;
            normals[triangleIndex, 1] = (Vector4.Up * sign).Normalized;
            normals[triangleIndex, 2] = (Vector4.Up * sign).Normalized;

            tangents[triangleIndex, 0] = new Vector4(v1.X, 0, v1.Z).Normalized;
            tangents[triangleIndex, 1] = new Vector4(v2.X, 0, v2.Z).Normalized;
            tangents[triangleIndex, 2] = new Vector4(v3.X, 0, v3.Z).Normalized;

            binormals[triangleIndex, 0] = new Vector4(Vector3.Cross(new Vector3(v1.X, 0, v1.Z).Normalized, sign * Vector3.UWorld));
            binormals[triangleIndex, 1] = new Vector4(Vector3.Cross(new Vector3(v2.X, 0, v2.Z).Normalized, sign * Vector3.UWorld));
            binormals[triangleIndex, 2] = new Vector4(Vector3.Cross(new Vector3(v3.X, 0, v3.Z).Normalized, sign * Vector3.UWorld));
        }

        private void SetTexCoord(int triangleIndex, int vertexIndex, float y, float phi)
        {
            textureCoords[triangleIndex, vertexIndex] = new Vector2(phi / (2 * (float)Math.PI), y);
        }

        private void SetTriangeVectors(int triangleIndex, float phi2, float phi3, float height)
        {
            var v1 = new Vector3(0f, height, 0f);
            var v2 = GetSphereVertice(phi2, -height);
            var v3 = GetSphereVertice(phi3, -height);

            vertices[triangleIndex, 0] = new Vector4(v1, 1f);
            vertices[triangleIndex, 1] = new Vector4(v2, 1f);
            vertices[triangleIndex, 2] = new Vector4(v3, 1f);

            var phi1 = (phi2 + phi3) / 2;
            var mid = GetSphereVertice(phi1, -height);
            tangents[triangleIndex, 0] = new Vector4(v1 - mid).Normalized;
            tangents[triangleIndex, 1] = new Vector4(v1 - v2).Normalized;
            tangents[triangleIndex, 2] = new Vector4(v1 - v3).Normalized;

            binormals[triangleIndex, 0] = new Vector4(GetSphereBinormals(phi1)).Normalized;
            binormals[triangleIndex, 1] = new Vector4(GetSphereBinormals(phi2)).Normalized;
            binormals[triangleIndex, 2] = new Vector4(GetSphereBinormals(phi3)).Normalized;

            normals[triangleIndex, 0] = new Vector4(Vector3.Cross(v1 - mid, GetSphereBinormals(phi1))).Normalized;
            normals[triangleIndex, 1] = new Vector4(Vector3.Cross(v1 - v2, GetSphereBinormals(phi1))).Normalized;
            normals[triangleIndex, 2] = new Vector4(Vector3.Cross(v1 - v3, GetSphereBinormals(phi1))).Normalized;

            SetTexCoord(triangleIndex, 0, 0, phi1);
            SetTexCoord(triangleIndex, 1, 0.5f, phi2);
            SetTexCoord(triangleIndex, 2, 0.5f, phi3);
        }
    }
}