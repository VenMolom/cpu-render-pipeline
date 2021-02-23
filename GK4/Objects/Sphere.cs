using GK4.Controls;
using System;

namespace GK4.Objects
{
    public class Sphere : RenderObject3D
    {
        private int horizontal = 5;
        private float r = 1f;
        private int vertical = 5;

        public Sphere()
        {
        }

        public Sphere(Scene scene)
        {
            Control = new SphereControl(this, scene);
        }

        public int Horizontal
        {
            get => horizontal;
            set
            {
                horizontal = value;
                SetVectors();
            }
        }

        public override string Name => "Sphere";

        public float R
        {
            get => r;
            set
            {
                r = value;
                SetVectors();
            }
        }

        public int Vertical
        {
            get => vertical;
            set
            {
                vertical = value;
                SetVectors();
            }
        }

        public override void OnDeserialization(Scene scene)
        {
            Control = new SphereControl(this, scene);
            SetVectors();
        }

        protected override void SetVectors()
        {
            var psiStep = (float)Math.PI / horizontal;
            var phiStep = (float)(2 * Math.PI / vertical);

            var trianglesCount = 2 * vertical * (horizontal - 1);
            vertices = new Vector4[trianglesCount, 3];
            normals = new Vector4[trianglesCount, 3];
            tangents = new Vector4[trianglesCount, 3];
            binormals = new Vector4[trianglesCount, 3];
            textureCoords = new Vector2[trianglesCount, 3];

            var currentTriangle = 0;
            // psi == 0
            var top = GetSphereVertice(0f, 0f);
            for (int j = 0; j < vertical; ++j)
            {
                var psi = psiStep;
                var phi = j * phiStep;
                var phi2 = phi + phiStep;

                SetVectors(currentTriangle, 0, 0, phi);
                SetVectors(currentTriangle, 1, psi, phi);
                SetVectors(currentTriangle++, 2, psi, phi2);
            }

            for (int i = 1; i < horizontal - 1; ++i)
            {
                var psi = i * psiStep;
                var psi2 = psi + psiStep;

                for (int j = 0; j < vertical; ++j)
                {
                    var phi = j * phiStep;
                    var phi2 = phi + phiStep;

                    SetVectors(currentTriangle, 0, psi, phi2);
                    SetVectors(currentTriangle, 1, psi, phi);
                    SetVectors(currentTriangle++, 2, psi2, phi);

                    SetVectors(currentTriangle, 0, psi2, phi2);
                    SetVectors(currentTriangle, 1, psi, phi2);
                    SetVectors(currentTriangle++, 2, psi2, phi);
                }
            }

            // psi == PI
            var bottom = GetSphereVertice((float)Math.PI, 0f);
            for (int j = 0; j < vertical; ++j)
            {
                var psi = (float)Math.PI - psiStep;
                var phi = j * phiStep;
                var phi2 = phi + phiStep;

                SetVectors(currentTriangle, 0, psi, phi);
                SetVectors(currentTriangle, 1, (float)Math.PI, phi);
                SetVectors(currentTriangle++, 2, psi, phi2);
            }
        }

        private Vector3 GetSphereBinormal(float psi, float phi)
        {
            return new Vector3(
                -(float)(Math.Sin(psi) * Math.Sin(phi)),
                0,
                (float)(Math.Sin(psi) * Math.Cos(phi)));
        }

        private Vector3 GetSphereTangent(float psi, float phi)
        {
            return new Vector3(
                (float)(Math.Cos(psi) * Math.Cos(phi)),
                -(float)Math.Sin(psi),
                (float)(Math.Cos(psi) * Math.Sin(phi)));
        }

        private Vector3 GetSphereVertice(float psi, float phi)
        {
            return new Vector3(
                (float)(r * Math.Sin(psi) * Math.Cos(phi)),
                (float)(r * Math.Cos(psi)),
                (float)(r * Math.Sin(psi) * Math.Sin(phi)));
        }

        private void SetVectors(int triangleIndex, int vertexIndex, float psi, float phi)
        {
            var pos = GetSphereVertice(psi, phi);

            vertices[triangleIndex, vertexIndex] = new Vector4(pos, 1f);
            normals[triangleIndex, vertexIndex] = new Vector4(pos.Normalized);
            tangents[triangleIndex, vertexIndex] = new Vector4(GetSphereTangent(psi, phi).Normalized);

            if (Math.Sin(psi) == 0)
            {
                binormals[triangleIndex, vertexIndex] = new Vector4(GetSphereBinormal(psi + (float)Math.PI / 2, phi).Normalized);
            }
            else
            {
                binormals[triangleIndex, vertexIndex] = new Vector4(GetSphereBinormal(psi, phi).Normalized);
            }

            textureCoords[triangleIndex, vertexIndex] = new Vector2(phi / (2 * (float)Math.PI), psi / (float)Math.PI);
        }
    }
}