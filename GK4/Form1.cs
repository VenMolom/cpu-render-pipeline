using GK4.Objects;
using GK4.Rendering;
using GK4.Serialization;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GK4
{
    public partial class Form1 : Form
    {
        private int currentFrames;
        private DirectBitmap directBitmap;
        private Font font = new Font("Arial", 16);
        private int frames;
        private Point lastMousePos;
        private DateTime lastTime;
        private bool mouseDown;
        private Scene scene;
        private IObject3D selected;
        private Size viewSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void addCameraButton_Click(object sender, EventArgs e)
        {
            scene.Add(new Camera(scene, viewSize.Width / (float)viewSize.Height));
        }

        private void addConeButton_Click(object sender, EventArgs e)
        {
            scene.Add(new Cone(scene));
        }

        private void addCuboidButton_Click(object sender, EventArgs e)
        {
            scene.Add(new Cuboid(scene));
        }

        private void addCylinderButton_Click(object sender, EventArgs e)
        {
            scene.Add(new Cylinder(scene));
        }

        private void addLightButton_Click(object sender, EventArgs e)
        {
            scene.Add(new Light(scene));
        }

        private void addSphereButton_Click(object sender, EventArgs e)
        {
            scene.Add(new Sphere(scene));
        }

        private void ambientLightColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            dialog.Color = Renderer.AmbientLight.Color;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Renderer.AmbientLight = new FragColor(dialog.Color);
            }
        }

        private void backfaceCullingToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Renderer.BackfaceCulling = !Renderer.BackfaceCulling;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viewSize = new Size(pictureBox.Width, pictureBox.Height);
            directBitmap = new DirectBitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = directBitmap.Bitmap;
            Renderer.CreateZBuffer(viewSize);
            scene = new Scene(objectsListBox, viewSize);

            frames = 0;
            currentFrames = 0;
            lastTime = DateTime.Now;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "GK4 files (*.gk4)|*GK4";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = dialog.OpenFile())
                {
                    objectsListBox.Items.Clear();
                    editObjectsGroupBox.Controls.Clear();

                    scene = new Scene(SceneSerialization.Deserialize(stream), objectsListBox, viewSize);
                }
            }
        }

        private void objectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = (IObject3D)objectsListBox.SelectedItem;

            editObjectsGroupBox.Controls.Clear();

            if (selected is null) return;

            var control = selected.Control;
            if (control != null) control.Dock = DockStyle.Fill;
            editObjectsGroupBox.Controls.Add(control);

            if (selected is Camera selectedCamera)
            {
                scene?.SwitchCamera(selectedCamera);
            }
        }

        private void perspectiveCorelationToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Renderer.PerspectiveCorrection = !Renderer.PerspectiveCorrection;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if (ModifierKeys == Keys.Shift)
                {
                    scene.Camera.Rotate(e.Location.X - lastMousePos.X, e.Location.Y - lastMousePos.Y);
                }
                else
                {
                    scene.Camera.Move(e.Location.X - lastMousePos.X, e.Location.Y - lastMousePos.Y);
                }
            }

            lastMousePos = e.Location;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = Graphics.FromImage(directBitmap.Bitmap))
            {
                g.Clear(Color.White);
            }
            scene.Render(directBitmap, viewSize);
            e.Graphics.DrawImage(directBitmap.Bitmap, 0, 0);
            e.Graphics.DrawString(frames.ToString(), font, Brushes.Green, 0, 0);
        }

        private void pictureBox_SizeChanged(object sender, EventArgs e)
        {
            viewSize = new Size(pictureBox.Width, pictureBox.Height);
            directBitmap = new DirectBitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = directBitmap.Bitmap;
            scene.UpdateSize(viewSize);
            Renderer.CreateZBuffer(viewSize);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "GK4 files (*.gk4)|*GK4";
            dialog.FileName = "scene1.gk4";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = dialog.OpenFile())
                {
                    SceneSerialization.Serialize(stream, scene.ToSceneSerialization());
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentFrames++;

            if ((DateTime.Now - lastTime).TotalSeconds >= 1)
            {
                frames = currentFrames;
                currentFrames = 0;
                lastTime = DateTime.Now;
            }

            pictureBox.Refresh();
        }

        private void wireframeToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Renderer.Wireframe = !Renderer.Wireframe;
        }

        private void zbufferingToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Renderer.ZBuffering = !Renderer.ZBuffering;
        }
    }
}