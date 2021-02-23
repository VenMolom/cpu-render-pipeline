using GK4.Controls;
using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GK4.Objects
{
    public class Camera : IObject3D
    {
        private const float cameraSpeed = 0.005f;
        private const float limit = (float)Math.PI / 2 - 0.1f;
        private const float mouseSensitivity = 0.005f;
        private Vector3 front = new Vector3(0, 0, -1f);

        public Camera()
        {
        }

        public Camera(Scene scene, float aspect)
        {
            Control = new CameraControl(this, scene);
            Aspect = aspect;
        }

        public float Aspect { get; set; }

        [XmlIgnore]
        public UserControl Control { get; private set; }

        public float Far { get; set; } = 100f;
        public float FOV { get; set; } = (float)Math.PI / 2;
        public string Name => "Camera";
        public float Near { get; set; } = 0.1f;
        public float Pitch { get; set; } = 0f;
        public Vector3 Position { get; set; } = new Vector3(0, 0, 3f);
        public Matrix4x4 Projection => Matrix4x4.Projection(FOV, Far, Near, Aspect);
        public Matrix4x4 View => Matrix4x4.View(Position, front);
        public float Yaw { get; set; } = -(float)Math.PI / 2;

        public void Move(float moveX, float moveY)
        {
            var right = Vector3.Cross(Vector3.UWorld, front);
            var up = Vector3.Cross(front, right);

            var y = cameraSpeed * moveY * up;
            var x = cameraSpeed * moveX * right;
            Position += y;
            Position -= x;

            (Control as ObjectControl).UpdateNumerics();
        }

        public void OnDeserialization(Scene scene)
        {
            Control = new CameraControl(this, scene);

            front.X = (float)(Math.Cos(Yaw) * Math.Cos(Pitch));
            front.Y = (float)Math.Sin(Pitch);
            front.Z = (float)(Math.Sin(Yaw) * Math.Cos(Pitch));
        }

        public void Rotate(float rotX, float rotY)
        {
            rotX *= mouseSensitivity;
            rotY *= mouseSensitivity;

            Yaw += rotX;
            Pitch += rotY;

            if (Pitch > limit)
                Pitch = limit;
            if (Pitch < -limit)
                Pitch = -limit;

            front.X = (float)(Math.Cos(Yaw) * Math.Cos(Pitch));
            front.Y = (float)Math.Sin(Pitch);
            front.Z = (float)(Math.Sin(Yaw) * Math.Cos(Pitch));
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