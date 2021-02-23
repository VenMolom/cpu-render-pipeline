using GK4.Objects;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace GK4.Serialization
{
    public class SceneSerialization
    {
        public List<Camera> Cameras { get; set; }

        public List<Light> Lights { get; set; }

        [XmlArrayItem(Type = typeof(RenderObject3D)),
            XmlArrayItem(Type = typeof(Cone)),
            XmlArrayItem(Type = typeof(Cuboid)),
            XmlArrayItem(Type = typeof(Cylinder)),
            XmlArrayItem(Type = typeof(Sphere))]
        public List<RenderObject3D> RenderObjects3D { get; set; }

        public static SceneSerialization Deserialize(Stream stream)
        {
            var serializer = new XmlSerializer(typeof(SceneSerialization));
            return (SceneSerialization)serializer.Deserialize(stream);
        }

        public static void Serialize(Stream stream, SceneSerialization sceneSerialization)
        {
            var serializer = new XmlSerializer(typeof(SceneSerialization));
            serializer.Serialize(stream, sceneSerialization);
        }
    }
}