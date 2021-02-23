namespace GK4.Controls
{
    partial class CameraControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.aNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fovLabel = new System.Windows.Forms.Label();
            this.nearLabel = new System.Windows.Forms.Label();
            this.farLabel = new System.Windows.Forms.Label();
            this.cameraGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNumericUpDown)).BeginInit();
            this.cameraGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.fovLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.aNumericUpDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nearLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bNumericUpDown, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.farLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cNumericUpDown, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 25);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Controls.SetChildIndex(this.cNumericUpDown, 0);
            this.tableLayoutPanel1.Controls.SetChildIndex(this.bNumericUpDown, 0);
            this.tableLayoutPanel1.Controls.SetChildIndex(this.aNumericUpDown, 0);
            // 
            // aNumericUpDown
            // 
            this.aNumericUpDown.DecimalPlaces = 2;
            this.aNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.aNumericUpDown.Location = new System.Drawing.Point(25, 3);
            this.aNumericUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.aNumericUpDown.Name = "aNumericUpDown";
            this.aNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.aNumericUpDown.TabIndex = 3;
            this.aNumericUpDown.ValueChanged += new System.EventHandler(this.aNumericUpDown_ValueChanged);
            // 
            // bNumericUpDown
            // 
            this.bNumericUpDown.DecimalPlaces = 2;
            this.bNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bNumericUpDown.Location = new System.Drawing.Point(113, 3);
            this.bNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.bNumericUpDown.Name = "bNumericUpDown";
            this.bNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.bNumericUpDown.TabIndex = 4;
            this.bNumericUpDown.ValueChanged += new System.EventHandler(this.bNumericUpDown_ValueChanged);
            // 
            // cNumericUpDown
            // 
            this.cNumericUpDown.DecimalPlaces = 2;
            this.cNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cNumericUpDown.Location = new System.Drawing.Point(201, 3);
            this.cNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cNumericUpDown.Name = "cNumericUpDown";
            this.cNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.cNumericUpDown.TabIndex = 5;
            this.cNumericUpDown.ValueChanged += new System.EventHandler(this.cNumericUpDown_ValueChanged);
            // 
            // fovLabel
            // 
            this.fovLabel.AutoSize = true;
            this.fovLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fovLabel.Location = new System.Drawing.Point(3, 0);
            this.fovLabel.Name = "fovLabel";
            this.fovLabel.Size = new System.Drawing.Size(16, 25);
            this.fovLabel.TabIndex = 0;
            this.fovLabel.Text = "FOV:";
            this.fovLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nearLabel
            // 
            this.nearLabel.AutoSize = true;
            this.nearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nearLabel.Location = new System.Drawing.Point(91, 0);
            this.nearLabel.Name = "nearLabel";
            this.nearLabel.Size = new System.Drawing.Size(16, 25);
            this.nearLabel.TabIndex = 1;
            this.nearLabel.Text = "N:";
            this.nearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // farLabel
            // 
            this.farLabel.AutoSize = true;
            this.farLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.farLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.farLabel.Location = new System.Drawing.Point(179, 0);
            this.farLabel.Name = "farLabel";
            this.farLabel.Size = new System.Drawing.Size(16, 25);
            this.farLabel.TabIndex = 2;
            this.farLabel.Text = "F:";
            this.farLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cameraGroupBox
            // 
            this.cameraGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.cameraGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraGroupBox.Location = new System.Drawing.Point(3, 3);
            this.cameraGroupBox.Name = "cameraGroupBox";
            this.cameraGroupBox.Size = new System.Drawing.Size(270, 44);
            this.cameraGroupBox.TabIndex = 0;
            this.cameraGroupBox.TabStop = false;
            this.cameraGroupBox.Text = "Camera:";
            // 
            // CameraControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "CameraControl";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNumericUpDown)).EndInit();
            this.cameraGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cameraGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label fovLabel;
        private System.Windows.Forms.Label nearLabel;
        private System.Windows.Forms.Label farLabel;
        private System.Windows.Forms.NumericUpDown aNumericUpDown;
        private System.Windows.Forms.NumericUpDown bNumericUpDown;
        private System.Windows.Forms.NumericUpDown cNumericUpDown;
    }
}
