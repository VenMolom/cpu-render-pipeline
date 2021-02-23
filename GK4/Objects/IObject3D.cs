using System.Windows.Forms;

namespace GK4.Objects
{
    public interface IObject3D
    {
        UserControl Control { get; }
        string Name { get; }
        Vector3 Position { get; set; }

        void OnDeserialization(Scene scene);

        void SendDelete(Scene scene);
    }
}