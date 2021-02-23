using GK4.Controls;
using GK4.Rendering;
using System.Collections.Generic;
using System.Drawing;

namespace GK4.Objects
{
    public class Cuboid : RenderObject3D
    {
        public Cuboid()
        {
        }

        public Cuboid(Scene scene)
        {
            Control = new CuboidControl(this, scene);
        }

        public float A { get; set; } = 1f;
        public float B { get; set; } = 1f;
        public float C { get; set; } = 1f;
        public override string Name => "Cuboid";

        public override void OnDeserialization(Scene scene)
        {
            Control = new CuboidControl(this, scene);
            SetVectors();
        }

        public override void Render(DirectBitmap bitmap, Matrix4x4 view, Matrix4x4 projection, Size size, Vector3 cameraPos, IList<Light> lights)
        {
            var model = TranslationMatrix * ScaleMatrix * Matrix4x4.Scale(A, B, C) * RotationMatrix;
            Renderer.Render(bitmap, vertices, normals, tangents, binormals, textureCoords, model, view, projection, size, cameraPos,
                new Material(AmbientColor, DiffuseColor, SpecularColor, Shininess), lights, Texture, NormalMap);
        }

        protected override void SetVectors()
        {
            vertices = new Vector4[12, 3]
            {
                { // up
                    new Vector4(0.5f, 0.5f, 0.5f, 1f),
                    new Vector4(-0.5f, 0.5f, 0.5f, 1f),
                    new Vector4(0.5f, 0.5f, -0.5f, 1f)
                }, {
                    new Vector4(-0.5f, 0.5f, 0.5f, 1f),
                    new Vector4(-0.5f, 0.5f, -0.5f, 1f),
                    new Vector4(0.5f, 0.5f, -0.5f, 1f)
                }, { // down
                    new Vector4(0.5f, -0.5f, 0.5f, 1f),
                    new Vector4(0.5f, -0.5f, -0.5f, 1f),
                    new Vector4(-0.5f,-0.5f, 0.5f, 1f)
                }, {
                    new Vector4(-0.5f, -0.5f, 0.5f, 1f),
                    new Vector4(0.5f, -0.5f, -0.5f, 1f),
                    new Vector4(-0.5f, -0.5f, -0.5f, 1f)
                }, { // front
                    new Vector4(0.5f, 0.5f, 0.5f, 1f),
                    new Vector4(0.5f, -0.5f, 0.5f, 1f),
                    new Vector4(-0.5f, -0.5f, 0.5f, 1f)
                }, {
                    new Vector4(-0.5f, -0.5f, 0.5f, 1f),
                    new Vector4(-0.5f, 0.5f, 0.5f, 1f),
                    new Vector4(0.5f, 0.5f, 0.5f, 1f)
                }, { // back
                    new Vector4(0.5f, 0.5f, -0.5f, 1f),
                    new Vector4(-0.5f, -0.5f, -0.5f, 1f),
                    new Vector4(0.5f, -0.5f, -0.5f, 1f)
                }, {
                    new Vector4(-0.5f, -0.5f, -0.5f, 1f),
                    new Vector4(0.5f, 0.5f, -0.5f, 1f),
                    new Vector4(-0.5f, 0.5f, -0.5f, 1f)
                }, { // right
                    new Vector4(0.5f, 0.5f, 0.5f, 1f),
                    new Vector4(0.5f, 0.5f, -0.5f, 1f),
                    new Vector4(0.5f, -0.5f, 0.5f, 1f)
                }, {
                    new Vector4(0.5f, 0.5f, -0.5f, 1f),
                    new Vector4(0.5f, -0.5f, -0.5f, 1f),
                    new Vector4(0.5f, -0.5f, 0.5f, 1f)
                }, { // left
                    new Vector4(-0.5f, 0.5f, 0.5f, 1f),
                    new Vector4(-0.5f, -0.5f, 0.5f, 1f),
                    new Vector4(-0.5f, 0.5f, -0.5f, 1f)
                }, {
                    new Vector4(-0.5f, 0.5f, -0.5f, 1f),
                    new Vector4(-0.5f, -0.5f, 0.5f, 1f),
                    new Vector4(-0.5f, -0.5f, -0.5f, 1f)
                }
            };

            normals = new Vector4[12, 3]
            {
                { // up
                    new Vector4(0, 1f, 0),
                    new Vector4(0, 1f, 0),
                    new Vector4(0, 1f, 0)
                }, {
                    new Vector4(0, 1f, 0),
                    new Vector4(0, 1f, 0),
                    new Vector4(0, 1f, 0)
                }, { // down
                    new Vector4(0, -1f, 0),
                    new Vector4(0, -1f, 0),
                    new Vector4(0, -1f, 0)
                }, {
                    new Vector4(0, -1f, 0),
                    new Vector4(0, -1f, 0),
                    new Vector4(0, -1f, 0)
                }, { // front
                    new Vector4(0, 0, 1f),
                    new Vector4(0, 0, 1f),
                    new Vector4(0, 0, 1f)
                }, {
                    new Vector4(0, 0, 1f),
                    new Vector4(0, 0, 1f),
                    new Vector4(0, 0, 1f)
                }, { // back
                    new Vector4(0, 0, -1f),
                    new Vector4(0, 0, -1f),
                    new Vector4(0, 0, -1f)
                }, {
                    new Vector4(0, 0, -1f),
                    new Vector4(0, 0, -1f),
                    new Vector4(0, 0, -1f)
                }, { // right
                    new Vector4(1f, 0, 0),
                    new Vector4(1f, 0, 0),
                    new Vector4(1f, 0, 0)
                }, {
                    new Vector4(1f, 0, 0),
                    new Vector4(1f, 0, 0),
                    new Vector4(1f, 0, 0)
                }, { // left
                    new Vector4(-1f, 0, 0),
                    new Vector4(-1f, 0, 0),
                    new Vector4(-1f, 0, 0)
                }, {
                    new Vector4(-1f, 0, 0),
                    new Vector4(-1f, 0, 0),
                    new Vector4(-1f, 0, 0)
                }
            };

            tangents = new Vector4[12, 3]
            {
                { // up
                    new Vector4(1f, 0, 0),
                    new Vector4(1f, 0, 0),
                    new Vector4(1f, 0, 0)
                }, {
                    new Vector4(1f, 0, 0),
                    new Vector4(1f, 0, 0),
                    new Vector4(1f, 0, 0)
                }, { // down
                    new Vector4(-1f, 0, 0),
                    new Vector4(-1f, 0, 0),
                    new Vector4(-1f, 0, 0)
                }, {
                    new Vector4(-1f, 0, 0),
                    new Vector4(-1f, 0, 0),
                    new Vector4(-1f, 0, 0)
                }, { // front
                    new Vector4(0, 1f, 0),
                    new Vector4(0, 1f, 0),
                    new Vector4(0, 1f, 0)
                }, {
                    new Vector4(0, 1f, 0),
                    new Vector4(0, 1f, 0),
                    new Vector4(0, 1f, 0)
                }, { // back
                    new Vector4(0, -1f, 0),
                    new Vector4(0, -1f, 0),
                    new Vector4(0, -1f, 0)
                }, {
                    new Vector4(0, -1f, 0),
                    new Vector4(0, -1f, 0),
                    new Vector4(0, -1f, 0)
                }, { // right
                    new Vector4(0, 0, 1f),
                    new Vector4(0, 0, 1f),
                    new Vector4(0, 0, 1f)
                }, {
                    new Vector4(0, 0, 1f),
                    new Vector4(0, 0, 1f),
                    new Vector4(0, 0, 1f)
                }, { // left
                    new Vector4(0, 0, -1f),
                    new Vector4(0, 0, -1f),
                    new Vector4(0, 0, -1f)
                }, {
                    new Vector4(0, 0, -1f),
                    new Vector4(0, 0, -1f),
                    new Vector4(0, 0, -1f)
                }
            };

            binormals = new Vector4[12, 3]
            {
                { // up
                    new Vector4(0, 0, 1f),
                    new Vector4(0, 0, 1f),
                    new Vector4(0, 0, 1f)
                }, {
                    new Vector4(0, 0, 1f),
                    new Vector4(0, 0, 1f),
                    new Vector4(0, 0, 1f)
                }, { // down
                    new Vector4(0, 0, -1f),
                    new Vector4(0, 0, -1f),
                    new Vector4(0, 0, -1f)
                }, {
                    new Vector4(0, 0, -1f),
                    new Vector4(0, 0, -1f),
                    new Vector4(0, 0, -1f)
                }, { // front
                    new Vector4(1f, 0, 0),
                    new Vector4(1f, 0, 0),
                    new Vector4(1f, 0, 0)
                }, {
                    new Vector4(1f, 0, 0),
                    new Vector4(1f, 0, 0),
                    new Vector4(1f, 0, 0)
                }, { // back
                    new Vector4(-1f, 0, 0),
                    new Vector4(-1f, 0, 0),
                    new Vector4(-1f, 0, 0)
                }, {
                    new Vector4(-1f, 0, 0),
                    new Vector4(-1f, 0, 0),
                    new Vector4(-1f, 0, 0)
                }, { // right
                    new Vector4(0, 1f, 0),
                    new Vector4(0, 1f, 0),
                    new Vector4(0, 1f, 0)
                }, {
                    new Vector4(0, 1f, 0),
                    new Vector4(0, 1f, 0),
                    new Vector4(0, 1f, 0)
                }, { // left
                    new Vector4(0, -1f, 0),
                    new Vector4(0, -1f, 0),
                    new Vector4(0, -1f, 0)
                }, {
                    new Vector4(0, -1f, 0),
                    new Vector4(0, -1f, 0),
                    new Vector4(0, -1f, 0)
                }
            };

            textureCoords = new Vector2[12, 3]
            {
                { // up
                    new Vector2(1f, 1f),
                    new Vector2(0, 1f),
                    new Vector2(1f, 0)
                }, {
                    new Vector2(0, 1f),
                    new Vector2(0, 0),
                    new Vector2(1f, 0)
                }, { // down
                    new Vector2(1f, 1f),
                    new Vector2(1f, 0),
                    new Vector2(0, 1f)
                }, {
                    new Vector2(0, 1f),
                    new Vector2(1f, 0),
                    new Vector2(0, 0)
                }, { // front
                    new Vector2(1f, 1f),
                    new Vector2(1f, 0),
                    new Vector2(0, 0)
                }, {
                    new Vector2(0, 0),
                    new Vector2(0, 1f),
                    new Vector2(1f, 1f)
                }, { // back
                    new Vector2(1f, 1f),
                    new Vector2(0, 0),
                    new Vector2(1f, 0)
                }, {
                    new Vector2(0, 0),
                    new Vector2(1f, 1f),
                    new Vector2(0, 1f)
                }, { // right
                    new Vector2(1f, 1f),
                    new Vector2(1f, 0),
                    new Vector2(0, 1f)
                }, {
                    new Vector2(1f, 0),
                    new Vector2(0, 0),
                    new Vector2(0, 1f)
                }, { // left
                    new Vector2(1f, 1f),
                    new Vector2(0, 1f),
                    new Vector2(1f, 0)
                }, {
                    new Vector2(1f, 0),
                    new Vector2(0, 1f),
                    new Vector2(0, 0)
                }
            };
        }
    }
}