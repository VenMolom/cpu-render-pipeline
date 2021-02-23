using GK4.Controls;
using GK4.Rendering;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GK4.Objects
{
    public class Light : IObject3D
    {
        public Light()
        {
        }

        public Light(Scene scene)
        {
            Control = new LightControl(this, scene);
        }

        public Vector3 Attenuation { get; set; } = new Vector3(1f, 0.09f, 0.032f);

        [XmlIgnore]
        public UserControl Control { get; private set; }

        public FragColor DiffuseLight { get; set; } = new FragColor(0.8f, 0.8f, 0.8f);
        public string Name => "Light";

        public Vector3 Position { get; set; } = new Vector3(0, 4f, 0);
        public FragColor SpecularLight { get; set; } = new FragColor(1f, 1f, 1f);

        public void OnDeserialization(Scene scene)
        {
            Control = new LightControl(this, scene);
        }

        public void SendDelete(Scene scene)
        {
            scene.Remove(this);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}