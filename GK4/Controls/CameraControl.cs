using GK4.Objects;
using System;

namespace GK4.Controls
{
    public partial class CameraControl : ObjectControl
    {
        private Camera camera;

        public CameraControl()
        {
            InitializeComponent();

            cuboidParametersTablePanel.Controls.Add(cameraGroupBox, 0, 1);
        }

        public CameraControl(Camera camera, Scene scene)
            : base(camera, scene)
        {
            InitializeComponent();

            cuboidParametersTablePanel.Controls.Add(cameraGroupBox, 0, 1);

            this.camera = camera;

            aNumericUpDown.Value = (decimal)(camera.FOV * (180f / Math.PI));
            bNumericUpDown.Value = (decimal)camera.Near;
            cNumericUpDown.Value = (decimal)camera.Far;
        }

        private void aNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            camera.FOV = (float)aNumericUpDown.Value * (float)(Math.PI / 180d);
        }

        private void bNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            camera.Near = (float)bNumericUpDown.Value;
        }

        private void cNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            camera.Far = (float)cNumericUpDown.Value;
        }
    }
}