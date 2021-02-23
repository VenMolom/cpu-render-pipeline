using GK4.Objects;
using System;

namespace GK4.Controls
{
    public partial class CylinderControl : RenderObjectControl
    {
        private Cylinder cylinder;

        public CylinderControl()
        {
            InitializeComponent();

            cuboidParametersTablePanel.Controls.Add(cuboidGroupBox, 0, 7);
        }

        public CylinderControl(Cylinder cylinder, Scene scene)
            : base(cylinder, scene)
        {
            InitializeComponent();

            cuboidParametersTablePanel.Controls.Add(cuboidGroupBox, 0, 7);

            this.cylinder = cylinder;

            aNumericUpDown.Value = (decimal)cylinder.R;
            bNumericUpDown.Value = (decimal)cylinder.H;
            cNumericUpDown.Value = cylinder.N;
        }

        private void aNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cylinder.R = (float)aNumericUpDown.Value;
        }

        private void bNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cylinder.H = (float)bNumericUpDown.Value;
        }

        private void cNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cylinder.N = (int)cNumericUpDown.Value;
        }
    }
}