using GK4.Objects;
using GK4.Rendering;
using GK4.Serialization;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GK4
{
    public class Scene
    {
        private readonly IList<Camera> cameras;
        private readonly IList<Light> lights;
        private readonly ListBox listBox;
        private readonly IList<IRenderObject3D> renderObjects3D;

        public Scene(ListBox listBox, Size size)
        {
            this.listBox = listBox;
            cameras = new List<Camera>();
            renderObjects3D = new List<IRenderObject3D>();
            lights = new List<Light>();

            Camera = new Camera(this, size.Width / (float)size.Height);
            Add(Camera);
        }

        public Scene(SceneSerialization sceneSerialization, ListBox listBox, Size size)
        {
            cameras = new List<Camera>();
            renderObjects3D = new List<IRenderObject3D>();
            lights = new List<Light>();
            this.listBox = listBox;

            foreach (var renderObject3D in sceneSerialization.RenderObjects3D)
            {
                Add(renderObject3D);
                renderObject3D.OnDeserialization(this);
            }

            foreach (var light in sceneSerialization.Lights)
            {
                Add(light);
                light.OnDeserialization(this);
            }

            foreach (var camera in sceneSerialization.Cameras)
            {
                Add(camera);
                camera.OnDeserialization(this);
            }

            Camera = cameras[cameras.Count - 1];
            Camera.Aspect = size.Width / (float)size.Height;
        }

        public Camera Camera { get; private set; }

        public void Add(IRenderObject3D object3D)
        {
            renderObjects3D.Add(object3D);
            AddObject(object3D);
        }

        public void Add(Light light)
        {
            lights.Add(light);
            AddObject(light);
        }

        public void Add(Camera camera)
        {
            cameras.Add(camera);
            AddObject(camera);
        }

        public void Remove(IRenderObject3D object3D)
        {
            renderObjects3D.Remove(object3D);
            RemoveObject(object3D);
        }

        public void Remove(Light light)
        {
            lights.Remove(light);
            RemoveObject(light);
        }

        public void Remove(Camera camera)
        {
            if (cameras.Count == 1) return;

            var index = cameras.IndexOf(Camera);
            SwitchCamera(cameras[(index - 1 + cameras.Count) % cameras.Count]);
            cameras.RemoveAt(index);
            RemoveObject(camera);
        }

        public void Render(DirectBitmap bitmap, Size size)
        {
            Renderer.ClearZBuffer();
            foreach (var renderObject3D in renderObjects3D)
            {
                renderObject3D.Render(bitmap, Camera.View, Camera.Projection, size, Camera.Position, lights);
            }
        }

        public void SwitchCamera(Camera camera)
        {
            camera.Aspect = Camera.Aspect;
            Camera = camera;
        }

        public SceneSerialization ToSceneSerialization()
        {
            return new SceneSerialization() { RenderObjects3D = renderObjects3D.Select(r => r as RenderObject3D).ToList(), Lights = lights.ToList(), Cameras = cameras.ToList() };
        }

        public void UpdateSize(Size size)
        {
            Camera.Aspect = size.Width / (float)size.Height;
        }

        private void AddObject(IObject3D object3D)
        {
            listBox.Items.Add(object3D);
            listBox.SelectedIndex = listBox.Items.Count - 1;
        }

        private void RemoveObject(IObject3D object3D)
        {
            var index = listBox.Items.IndexOf(object3D);

            if (index < 0) return;

            listBox.Items.RemoveAt(index);
        }
    }
}