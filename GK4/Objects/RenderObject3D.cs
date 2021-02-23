using GK4.Rendering;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GK4.Objects
{
    [XmlInclude(typeof(Cuboid)),
        XmlInclude(typeof(Cone)),
        XmlInclude(typeof(Cylinder)),
        XmlInclude(typeof(Sphere))]
    abstract public class RenderObject3D : IRenderObject3D
    {
        protected Vector4[,] binormals;
        protected Vector4[,] normals;
        protected Vector4[,] tangents;
        protected Vector2[,] textureCoords;
        protected Vector4[,] vertices;

        public RenderObject3D()
        {
            SetVectors();
        }

        public FragColor AmbientColor { get; set; } = new FragColor(1.0f, 0.5f, 0.31f);

        [XmlIgnore]
        public UserControl Control { get; protected set; }

        public FragColor DiffuseColor { get; set; } = new FragColor(1.0f, 0.5f, 0.31f);
        public abstract string Name { get; }

        [XmlIgnore]
        public DirectBitmap NormalMap { get; set; }

        public Vector3 Position { get; set; } = new Vector3(0, 0, 0);
        public Vector3 Rotation { get; set; } = new Vector3(0, 0, 0);
        public Vector3 Scale { get; set; } = new Vector3(1f, 1f, 1f);
        public float Shininess { get; set; } = 32f;
        public FragColor SpecularColor { get; set; } = new FragColor(0.5f, 0.5f, 0.5f);

        [XmlIgnore]
        public DirectBitmap Texture { get; set; }

        protected Matrix4x4 RotationMatrix => Matrix4x4.RotationX(Rotation.X) * Matrix4x4.RotationY(Rotation.Y) * Matrix4x4.RotationZ(Rotation.Z);
        protected Matrix4x4 ScaleMatrix => Matrix4x4.Scale(Scale);
        protected Matrix4x4 TranslationMatrix => Matrix4x4.Translation(Position);

        public abstract void OnDeserialization(Scene scene);

        public virtual void Render(DirectBitmap bitmap, Matrix4x4 view, Matrix4x4 projection, Size size, Vector3 cameraPos, IList<Light> lights)
        {
            var model = TranslationMatrix * ScaleMatrix * RotationMatrix;
            Renderer.Render(bitmap, vertices, normals, tangents, binormals, textureCoords, model, view, projection, size, cameraPos,
                new Material(AmbientColor, DiffuseColor, SpecularColor, Shininess), lights, Texture, NormalMap);
        }

        public void SendDelete(Scene scene)
        {
            scene.Remove(this);
        }

        public override string ToString()
        {
            return Name;
        }

        protected abstract void SetVectors();
    }
}