using GK4.Objects;
using System;

namespace GK4.Controls
{
    public partial class SphereControl : RenderObjectControl
    {
        private Sphere sphere;

        public SphereControl()
        {
            InitializeComponent();

            cuboidParametersTablePanel.Controls.Add(cuboidGroupBox, 0, 7);
        }

        public SphereControl(Sphere sphere, Scene scene)
            : base(sphere, scene)
        {
            InitializeComponent();

            cuboidParametersTablePanel.Controls.Add(cuboidGroupBox, 0, 7);

            this.sphere = sphere;

            aNumericUpDown.Value = (decimal)sphere.R;
            bNumericUpDown.Value = sphere.Horizontal;
            cNumericUpDown.Value = sphere.Vertical;
        }

        private void aNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sphere.R = (float)aNumericUpDown.Value;
        }

        private void bNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sphere.Horizontal = (int)bNumericUpDown.Value;
        }

        private void cNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sphere.Vertical = (int)cNumericUpDown.Value;
        }
    }
}