using GK4.Objects;
using System;

namespace GK4.Controls
{
    public partial class CuboidControl : RenderObjectControl
    {
        private Cuboid cuboid;

        public CuboidControl()
        {
            InitializeComponent();

            cuboidParametersTablePanel.Controls.Add(cuboidGroupBox, 0, 7);
        }

        public CuboidControl(Cuboid cuboid, Scene scene)
            : base(cuboid, scene)
        {
            InitializeComponent();

            cuboidParametersTablePanel.Controls.Add(cuboidGroupBox, 0, 7);

            this.cuboid = cuboid;

            aNumericUpDown.Value = (decimal)cuboid.A;
            bNumericUpDown.Value = (decimal)cuboid.B;
            cNumericUpDown.Value = (decimal)cuboid.C;
        }

        private void aNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cuboid.A = (float)aNumericUpDown.Value;
        }

        private void bNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cuboid.B = (float)bNumericUpDown.Value;
        }

        private void cNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cuboid.C = (float)cNumericUpDown.Value;
        }
    }
}