using System;

namespace GK4.Rendering.Edges
{
    internal class Edge
    {
        private Vector3 binormal1, binormal2;
        private Vector3 normal1, normal2;
        private bool perspectiveCorrection;
        private Vector3 position1, position2;
        private float q;
        private float qDiff;
        private Vector3 tangent1, tangent2;
        private Vector2 texCoords1, texCoords2;
        private float w1, w2;
        private float wDiff;
        private float zDiff;

        public Edge(Vertex v1, Vertex v2, bool perspectiveCorrection)
        {
            this.perspectiveCorrection = perspectiveCorrection;

            Ymax = (int)Math.Round(v2.ScreenPosition.Y);
            Ymin = (int)Math.Round(v1.ScreenPosition.Y);
            X = (int)Math.Round(v1.ScreenPosition.X);
            D = (float)(v2.ScreenPosition.X - v1.ScreenPosition.X) / (v2.ScreenPosition.Y - v1.ScreenPosition.Y);
            Next = null;

            qDiff = 1f / (Ymax - Ymin);
            q = 0;

            Z = v1.ScreenPosition.Z;
            zDiff = Interpolation.Diff(v1.ScreenPosition.Z, v2.ScreenPosition.Z, qDiff);

            W = v1.ClipW;
            wDiff = Interpolation.Diff(v1.ClipW, v2.ClipW, qDiff);

            w1 = v1.ClipW;
            w2 = v2.ClipW;

            Normal = v1.Normal;
            Tangent = v1.Tangent;
            Binormal = v1.Binormal;
            Position = v1.WorldPosition;
            TextureCoords = v1.TextureCoords;

            normal1 = v1.Normal;
            normal2 = v2.Normal;

            tangent1 = v1.Tangent;
            tangent2 = v2.Tangent;

            binormal1 = v1.Binormal;
            binormal2 = v2.Binormal;

            position1 = v1.WorldPosition;
            position2 = v2.WorldPosition;

            texCoords1 = v1.TextureCoords;
            texCoords2 = v2.TextureCoords;
        }

        public Vector3 Binormal { get; private set; }
        public float D { get; private set; }
        public Edge Next { get; set; }
        public Vector3 Normal { get; private set; }
        public Vector3 Position { get; private set; }
        public Vector3 Tangent { get; private set; }
        public Vector2 TextureCoords { get; private set; }
        public float W { get; private set; }
        public float X { get; private set; }
        public int Ymax { get; private set; }
        public int Ymin { get; private set; }
        public float Z { get; private set; }

        public void Increase()
        {
            X += D;
            Z += zDiff;
            W += wDiff;
            q += qDiff;
            Normal = Interpolation.Interpolate(normal1, normal2, q, w1, w2, perspectiveCorrection).Normalized;
            Tangent = Interpolation.Interpolate(tangent1, tangent2, q, w1, w2, perspectiveCorrection).Normalized;
            Binormal = Interpolation.Interpolate(binormal1, binormal2, q, w1, w2, perspectiveCorrection).Normalized;
            Position = Interpolation.Interpolate(position1, position2, q, w1, w2, perspectiveCorrection);
            TextureCoords = Interpolation.Interpolate(texCoords1, texCoords2, q, w1, w2, perspectiveCorrection);
        }
    }
}