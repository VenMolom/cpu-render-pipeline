namespace GK4.Rendering
{
    internal struct Material
    {
        public Material(FragColor ambientColor, FragColor diffuseColor, FragColor specularColor, float shininess)
        {
            AmbientColor = ambientColor;
            DiffuseColor = diffuseColor;
            SpecularColor = specularColor;
            Shininess = shininess;
        }

        public FragColor AmbientColor { get; }
        public FragColor DiffuseColor { get; }
        public float Shininess { get; }
        public FragColor SpecularColor { get; }
    }
}