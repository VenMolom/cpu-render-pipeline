using GK4.Rendering;
using System.Collections.Generic;
using System.Drawing;

namespace GK4.Objects
{
    public interface IRenderObject3D : IObject3D
    {
        FragColor AmbientColor { get; set; }
        FragColor DiffuseColor { get; set; }
        DirectBitmap NormalMap { get; set; }
        Vector3 Rotation { get; set; }
        Vector3 Scale { get; set; }
        float Shininess { get; set; }
        FragColor SpecularColor { get; set; }
        DirectBitmap Texture { get; set; }

        void Render(DirectBitmap bitmap, Matrix4x4 view, Matrix4x4 projection, Size size, Vector3 cameraPos, IList<Light> lights);
    }
}