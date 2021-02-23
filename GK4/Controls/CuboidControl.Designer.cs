namespace GK4.Controls
{
    partial class CuboidControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cuboidGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNumericUpDown)).BeginInit();
            this.cuboidGroupBox.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.aNumericUpDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bNumericUpDown, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cNumericUpDown, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 25);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "a:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(91, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "b:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(179, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "c:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // posXNumericUpDown
            // 
            this.aNumericUpDown.DecimalPlaces = 2;
            this.aNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.aNumericUpDown.Location = new System.Drawing.Point(25, 3);
            this.aNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.aNumericUpDown.Name = "posXNumericUpDown";
            this.aNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.aNumericUpDown.TabIndex = 3;
            this.aNumericUpDown.ValueChanged += new System.EventHandler(this.aNumericUpDown_ValueChanged);
            // 
            // posYNumericUpDown
            // 
            this.bNumericUpDown.DecimalPlaces = 2;
            this.bNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.bNumericUpDown.Location = new System.Drawing.Point(113, 3);
            this.bNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.bNumericUpDown.Name = "posYNumericUpDown";
            this.bNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.bNumericUpDown.TabIndex = 4;
            this.bNumericUpDown.ValueChanged += new System.EventHandler(this.bNumericUpDown_ValueChanged);
            // 
            // posZNumericUpDown
            // 
            this.cNumericUpDown.DecimalPlaces = 2;
            this.cNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.cNumericUpDown.Location = new System.Drawing.Point(201, 3);
            this.cNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.cNumericUpDown.Name = "posZNumericUpDown";
            this.cNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.cNumericUpDown.TabIndex = 5;
            this.cNumericUpDown.ValueChanged += new System.EventHandler(this.cNumericUpDown_ValueChanged);
            // 
            // positionGroupBox
            // 
            this.cuboidGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.cuboidGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuboidGroupBox.Location = new System.Drawing.Point(3, 3);
            this.cuboidGroupBox.Name = "positionGroupBox";
            this.cuboidGroupBox.Size = new System.Drawing.Size(270, 44);
            this.cuboidGroupBox.TabIndex = 0;
            this.cuboidGroupBox.TabStop = false;
            this.cuboidGroupBox.Text = "Cuboid:";
            // 
            // RenderObjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "RenderObjectControl";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNumericUpDown)).EndInit();
            this.cuboidGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cuboidGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown aNumericUpDown;
        private System.Windows.Forms.NumericUpDown bNumericUpDown;
        private System.Windows.Forms.NumericUpDown cNumericUpDown;
    }
}
