namespace GK4.Rendering.Edges
{
    internal struct Range
    {
        public Range(Edge edge1, Edge edge2)
        {
            X1 = edge1.X;
            Z1 = edge1.Z;
            X2 = edge2.X;
            Z2 = edge2.Z;
            Normal1 = edge1.Normal;
            Normal2 = edge2.Normal;
            Tangent1 = edge1.Tangent;
            Tangent2 = edge2.Tangent;
            Binormal1 = edge1.Binormal;
            Binormal2 = edge2.Binormal;
            Position1 = edge1.Position;
            Position2 = edge2.Position;
            TextureCoords1 = edge1.TextureCoords;
            TextureCoords2 = edge2.TextureCoords;
            W1 = edge1.W;
            W2 = edge2.W;
        }

        public Vector3 Binormal1 { get; }
        public Vector3 Binormal2 { get; }
        public Vector3 Normal1 { get; }
        public Vector3 Normal2 { get; }
        public Vector3 Position1 { get; }
        public Vector3 Position2 { get; }
        public Vector3 Tangent1 { get; }
        public Vector3 Tangent2 { get; }
        public Vector2 TextureCoords1 { get; }
        public Vector2 TextureCoords2 { get; }
        public float W1 { get; }
        public float W2 { get; }
        public float X1 { get; }
        public float X2 { get; }
        public float Z1 { get; }
        public float Z2 { get; }
    }
}