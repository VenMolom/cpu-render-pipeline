using System.Drawing;

namespace GK4
{
    internal struct Vertex
    {
        public Vertex(Vector4 position, Vector3 normal, Vector3 tangent, Vector3 binormal, Vector3 worldPosition, Vector2 textureCoords)
        {
            ScreenPosition = position;
            Normal = normal;
            Tangent = tangent;
            Binormal = binormal;
            WorldPosition = worldPosition;
            ClipW = 0;
            TextureCoords = textureCoords;
        }

        public Vector3 Binormal { get; }
        public float ClipW { get; private set; }
        public Vector3 Normal { get; }
        public Vector4 ScreenPosition { get; }
        public Vector3 Tangent { get; }
        public Vector2 TextureCoords { get; }
        public Vector3 WorldPosition { get; }

        public static Vertex operator *(Vertex v, float a)
        {
            return new Vertex(v.ScreenPosition * a, v.Normal * a, v.Tangent * a, v.Binormal * a, v.WorldPosition * a, v.TextureCoords * a);
        }

        public static Vertex operator +(Vertex v1, Vertex v2)
        {
            return new Vertex(v1.ScreenPosition + v2.ScreenPosition,
                v1.Normal + v2.Normal,
                v1.Tangent + v2.Tangent,
                v1.Binormal + v2.Binormal,
                v1.WorldPosition + v2.WorldPosition,
                v1.TextureCoords + v2.TextureCoords);
        }

        public Vertex ToScreenCoords(Size size)
        {
            var ret = new Vertex(ScreenPosition.ToScreenCoords(size), Normal, Tangent, Binormal, WorldPosition, TextureCoords);
            ret.ClipW = ScreenPosition.W;
            return ret;
        }
    }
}