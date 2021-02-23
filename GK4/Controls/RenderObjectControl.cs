using GK4.Objects;
using GK4.Rendering;
using System;
using System.Windows.Forms;

namespace GK4.Controls
{
    public partial class RenderObjectControl : ObjectControl
    {
        private IRenderObject3D renderObject3D;

        public RenderObjectControl()
        {
            InitializeComponent();

            cuboidParametersTablePanel.Controls.Add(scaleGroupBox, 0, 1);
            cuboidParametersTablePanel.Controls.Add(rotationGroupBox, 0, 2);
            cuboidParametersTablePanel.Controls.Add(ambientColorGroupBox, 0, 3);
            cuboidParametersTablePanel.Controls.Add(diffuseColorGroupBox, 0, 4);
            cuboidParametersTablePanel.Controls.Add(specularColorGroupBox, 0, 5);
            cuboidParametersTablePanel.Controls.Add(shininessGroupBox, 0, 6);
            cuboidParametersTablePanel.Controls.Add(tableLayoutPanelMaps, 0, 8);
        }

        public RenderObjectControl(IRenderObject3D renderObject3D, Scene scene)
            : base(renderObject3D, scene)
        {
            InitializeComponent();

            cuboidParametersTablePanel.Controls.Add(scaleGroupBox, 0, 1);
            cuboidParametersTablePanel.Controls.Add(rotationGroupBox, 0, 2);
            cuboidParametersTablePanel.Controls.Add(ambientColorGroupBox, 0, 3);
            cuboidParametersTablePanel.Controls.Add(diffuseColorGroupBox, 0, 4);
            cuboidParametersTablePanel.Controls.Add(specularColorGroupBox, 0, 5);
            cuboidParametersTablePanel.Controls.Add(shininessGroupBox, 0, 6);
            cuboidParametersTablePanel.Controls.Add(tableLayoutPanelMaps, 0, 8);

            this.renderObject3D = renderObject3D;

            scaleXNumericUpDown.Value = (decimal)renderObject3D.Scale.X;
            scaleYNumericUpDown.Value = (decimal)renderObject3D.Scale.Y;
            scaleZNumericUpDown.Value = (decimal)renderObject3D.Scale.Z;

            rotXNumericUpDown.Value = (decimal)renderObject3D.Rotation.X;
            rotYNumericUpDown.Value = (decimal)renderObject3D.Rotation.Y;
            rotZNumericUpDown.Value = (decimal)renderObject3D.Rotation.Z;

            ambientColorPanel.BackColor = renderObject3D.AmbientColor.Color;
            diffuseColorPanel.BackColor = renderObject3D.DiffuseColor.Color;
            specularColorPanel.BackColor = renderObject3D.SpecularColor.Color;
            shininess.Value = (decimal)renderObject3D.Shininess;
        }

        private void ambientColorPanel_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            dialog.Color = ambientColorPanel.BackColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ambientColorPanel.BackColor = dialog.Color;
                renderObject3D.DiffuseColor = new FragColor(dialog.Color);
            }
        }

        private void diffuseColorPanel_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            dialog.Color = diffuseColorPanel.BackColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                diffuseColorPanel.BackColor = dialog.Color;
                renderObject3D.DiffuseColor = new FragColor(dialog.Color);
            }
        }

        private void normalMapButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                renderObject3D.NormalMap = new DirectBitmap(dialog.FileName);
            }
        }

        private void rotXNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            renderObject3D.Rotation = new Vector3((float)rotXNumericUpDown.Value, renderObject3D.Rotation.Y, renderObject3D.Rotation.Z);
        }

        private void rotYNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            renderObject3D.Rotation = new Vector3(renderObject3D.Rotation.X, (float)rotYNumericUpDown.Value, renderObject3D.Rotation.Z);
        }

        private void rotZNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            renderObject3D.Rotation = new Vector3(renderObject3D.Rotation.X, renderObject3D.Rotation.Y, (float)rotZNumericUpDown.Value);
        }

        private void scaleXNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            renderObject3D.Scale = new Vector3((float)scaleXNumericUpDown.Value, renderObject3D.Scale.Y, renderObject3D.Scale.Z);
        }

        private void scaleYNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            renderObject3D.Scale = new Vector3(renderObject3D.Scale.X, (float)scaleYNumericUpDown.Value, renderObject3D.Scale.Z);
        }

        private void scaleZNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            renderObject3D.Scale = new Vector3(renderObject3D.Scale.X, renderObject3D.Scale.Y, (float)scaleZNumericUpDown.Value);
        }

        private void shininess_ValueChanged(object sender, EventArgs e)
        {
            renderObject3D.Shininess = (float)shininess.Value;
        }

        private void specularColorPanel_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            dialog.Color = specularColorPanel.BackColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                specularColorPanel.BackColor = dialog.Color;
                renderObject3D.DiffuseColor = new FragColor(dialog.Color);
            }
        }

        private void textureButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                renderObject3D.Texture = new DirectBitmap(dialog.FileName);
            }
        }
    }
}