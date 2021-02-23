using GK4.Objects;
using System;

namespace GK4.Controls
{
    public partial class ConeControl : RenderObjectControl
    {
        private Cone cone;

        public ConeControl()
        {
            InitializeComponent();

            cuboidParametersTablePanel.Controls.Add(cuboidGroupBox, 0, 7);
        }

        public ConeControl(Cone cone, Scene scene)
            : base(cone, scene)
        {
            InitializeComponent();

            cuboidParametersTablePanel.Controls.Add(cuboidGroupBox, 0, 7);

            this.cone = cone;

            aNumericUpDown.Value = (decimal)cone.R;
            bNumericUpDown.Value = (decimal)cone.H;
            cNumericUpDown.Value = cone.N;
        }

        private void aNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cone.R = (float)aNumericUpDown.Value;
        }

        private void bNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cone.H = (float)bNumericUpDown.Value;
        }

        private void cNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cone.N = (int)cNumericUpDown.Value;
        }
    }
}