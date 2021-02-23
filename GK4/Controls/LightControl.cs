using GK4.Objects;
using GK4.Rendering;
using System;
using System.Windows.Forms;

namespace GK4.Controls
{
    public partial class LightControl : ObjectControl
    {
        private Light light;

        public LightControl()
        {
            InitializeComponent();

            cuboidParametersTablePanel.Controls.Add(diffusionLightGroupBox, 0, 1);
            cuboidParametersTablePanel.Controls.Add(specularLightGroupBox, 0, 2);
            cuboidParametersTablePanel.Controls.Add(attenuationGroupBox, 0, 3);
        }

        public LightControl(Light light, Scene scene)
            : base(light, scene)
        {
            InitializeComponent();

            cuboidParametersTablePanel.Controls.Add(diffusionLightGroupBox, 0, 1);
            cuboidParametersTablePanel.Controls.Add(specularLightGroupBox, 0, 2);
            cuboidParametersTablePanel.Controls.Add(attenuationGroupBox, 0, 3);

            this.light = light;

            attenuationCNumericUpDown.Value = (decimal)light.Attenuation.X;
            attenuationLNumericUpDown.Value = (decimal)light.Attenuation.Y;
            attenuationQNumericUpDown.Value = (decimal)light.Attenuation.Z;

            diffusionLightPanel.BackColor = light.DiffuseLight.Color;
            specularLightPanel.BackColor = light.SpecularLight.Color;
        }

        private void attenuationCNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            light.Attenuation = new Vector3((float)attenuationCNumericUpDown.Value, light.Attenuation.Y, light.Attenuation.Z);
        }

        private void attenuationLNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            light.Attenuation = new Vector3(light.Attenuation.X, (float)attenuationLNumericUpDown.Value, light.Attenuation.Z);
        }

        private void attenuationQNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            light.Attenuation = new Vector3(light.Attenuation.X, light.Attenuation.Y, (float)attenuationQNumericUpDown.Value);
        }

        private void diffusionLightPanel_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            dialog.Color = diffusionLightPanel.BackColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                diffusionLightPanel.BackColor = dialog.Color;
                light.DiffuseLight = new FragColor(dialog.Color);
            }
        }

        private void specularLightPanel_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            dialog.Color = specularLightPanel.BackColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                specularLightPanel.BackColor = dialog.Color;
                light.SpecularLight = new FragColor(dialog.Color);
            }
        }
    }
}