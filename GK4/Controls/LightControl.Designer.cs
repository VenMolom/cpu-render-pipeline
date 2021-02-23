namespace GK4.Controls
{
    partial class LightControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.diffusionLightGroupBox = new System.Windows.Forms.GroupBox();
            this.diffusionLightPanel = new System.Windows.Forms.Panel();
            this.specularLightGroupBox = new System.Windows.Forms.GroupBox();
            this.specularLightPanel = new System.Windows.Forms.Panel();
            this.attenuationGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.attenuationCNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.attenuationLNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.attenuationQNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.diffusionLightGroupBox.SuspendLayout();
            this.specularLightGroupBox.SuspendLayout();
            this.attenuationGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attenuationCNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attenuationLNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attenuationQNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // diffusionLightGroupBox
            // 
            this.diffusionLightGroupBox.Controls.Add(this.diffusionLightPanel);
            this.diffusionLightGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diffusionLightGroupBox.Location = new System.Drawing.Point(3, 53);
            this.diffusionLightGroupBox.Name = "diffusionLightGroupBox";
            this.diffusionLightGroupBox.Size = new System.Drawing.Size(270, 44);
            this.diffusionLightGroupBox.TabIndex = 4;
            this.diffusionLightGroupBox.TabStop = false;
            this.diffusionLightGroupBox.Text = "Diffusion";
            // 
            // diffusionLightPanel
            // 
            this.diffusionLightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diffusionLightPanel.Location = new System.Drawing.Point(3, 16);
            this.diffusionLightPanel.Name = "diffusionLightPanel";
            this.diffusionLightPanel.Size = new System.Drawing.Size(264, 25);
            this.diffusionLightPanel.TabIndex = 0;
            this.diffusionLightPanel.Click += new System.EventHandler(this.diffusionLightPanel_Click);
            // 
            // specularLightGroupBox
            // 
            this.specularLightGroupBox.Controls.Add(this.specularLightPanel);
            this.specularLightGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.specularLightGroupBox.Location = new System.Drawing.Point(3, 103);
            this.specularLightGroupBox.Name = "specularLightGroupBox";
            this.specularLightGroupBox.Size = new System.Drawing.Size(270, 44);
            this.specularLightGroupBox.TabIndex = 5;
            this.specularLightGroupBox.TabStop = false;
            this.specularLightGroupBox.Text = "Specular";
            // 
            // specularLightPanel
            // 
            this.specularLightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.specularLightPanel.Location = new System.Drawing.Point(3, 16);
            this.specularLightPanel.Name = "specularLightPanel";
            this.specularLightPanel.Size = new System.Drawing.Size(264, 25);
            this.specularLightPanel.TabIndex = 0;
            this.specularLightPanel.Click += new System.EventHandler(this.specularLightPanel_Click);
            // 
            // attenuationGroupBox
            // 
            this.attenuationGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.attenuationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attenuationGroupBox.Location = new System.Drawing.Point(3, 153);
            this.attenuationGroupBox.Name = "attenuationGroupBox";
            this.attenuationGroupBox.Size = new System.Drawing.Size(270, 44);
            this.attenuationGroupBox.TabIndex = 6;
            this.attenuationGroupBox.TabStop = false;
            this.attenuationGroupBox.Text = "Attenuation";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.attenuationCNumericUpDown, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.attenuationLNumericUpDown, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.attenuationQNumericUpDown, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(264, 25);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "c:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(91, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "l:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(179, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "q:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attenuationCNumericUpDown
            // 
            this.attenuationCNumericUpDown.DecimalPlaces = 3;
            this.attenuationCNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attenuationCNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.attenuationCNumericUpDown.Location = new System.Drawing.Point(25, 3);
            this.attenuationCNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.attenuationCNumericUpDown.Name = "attenuationCNumericUpDown";
            this.attenuationCNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.attenuationCNumericUpDown.TabIndex = 3;
            this.attenuationCNumericUpDown.ValueChanged += new System.EventHandler(this.attenuationCNumericUpDown_ValueChanged);
            // 
            // attenuationLNumericUpDown
            // 
            this.attenuationLNumericUpDown.DecimalPlaces = 3;
            this.attenuationLNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attenuationLNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.attenuationLNumericUpDown.Location = new System.Drawing.Point(113, 3);
            this.attenuationLNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.attenuationLNumericUpDown.Name = "attenuationLNumericUpDown";
            this.attenuationLNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.attenuationLNumericUpDown.TabIndex = 4;
            this.attenuationLNumericUpDown.ValueChanged += new System.EventHandler(this.attenuationLNumericUpDown_ValueChanged);
            // 
            // attenuationQNumericUpDown
            // 
            this.attenuationQNumericUpDown.DecimalPlaces = 3;
            this.attenuationQNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attenuationQNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.attenuationQNumericUpDown.Location = new System.Drawing.Point(201, 3);
            this.attenuationQNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.attenuationQNumericUpDown.Name = "attenuationQNumericUpDown";
            this.attenuationQNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.attenuationQNumericUpDown.TabIndex = 5;
            this.attenuationQNumericUpDown.ValueChanged += new System.EventHandler(this.attenuationQNumericUpDown_ValueChanged);
            // 
            // LightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "LightControl";
            this.diffusionLightGroupBox.ResumeLayout(false);
            this.specularLightGroupBox.ResumeLayout(false);
            this.attenuationGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attenuationCNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attenuationLNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attenuationQNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox diffusionLightGroupBox;
        private System.Windows.Forms.GroupBox specularLightGroupBox;
        private System.Windows.Forms.GroupBox attenuationGroupBox;
        private System.Windows.Forms.Panel diffusionLightPanel;
        private System.Windows.Forms.Panel specularLightPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown attenuationCNumericUpDown;
        private System.Windows.Forms.NumericUpDown attenuationLNumericUpDown;
        private System.Windows.Forms.NumericUpDown attenuationQNumericUpDown;
    }
}
