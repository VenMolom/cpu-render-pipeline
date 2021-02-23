using GK4.Objects;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace GK4.Controls
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class ObjectControl : UserControl
    {
        private IObject3D object3D;
        private Scene scene;

        public ObjectControl()
        {
            InitializeComponent();
        }

        public ObjectControl(IObject3D object3D, Scene scene)
        {
            InitializeComponent();

            this.object3D = object3D;
            this.scene = scene;

            posXNumericUpDown.Value = (decimal)object3D.Position.X;
            posYNumericUpDown.Value = (decimal)object3D.Position.Y;
            posZNumericUpDown.Value = (decimal)object3D.Position.Z;
        }

        public void UpdateNumerics()
        {
            posXNumericUpDown.Value = (decimal)object3D.Position.X;
            posYNumericUpDown.Value = (decimal)object3D.Position.Y;
            posZNumericUpDown.Value = (decimal)object3D.Position.Z;
        }

        private void deleteObjectButton_Click(object sender, EventArgs e)
        {
            object3D.SendDelete(scene);
        }

        private void posXNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            object3D.Position = new Vector3((float)posXNumericUpDown.Value, object3D.Position.Y, object3D.Position.Z);
        }

        private void posYNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            object3D.Position = new Vector3(object3D.Position.X, (float)posYNumericUpDown.Value, object3D.Position.Z);
        }

        private void posZNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            object3D.Position = new Vector3(object3D.Position.X, object3D.Position.Y, (float)posZNumericUpDown.Value);
        }
    }
}