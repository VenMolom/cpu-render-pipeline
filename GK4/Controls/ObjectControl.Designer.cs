namespace GK4.Controls
{
    partial class ObjectControl
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
            this.cuboidParametersTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.positionGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.posXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.posYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.posZNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.deleteObjectButton = new System.Windows.Forms.Button();
            this.cuboidParametersTablePanel.SuspendLayout();
            this.positionGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posZNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cuboidParametersTablePanel
            // 
            this.cuboidParametersTablePanel.ColumnCount = 1;
            this.cuboidParametersTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cuboidParametersTablePanel.Controls.Add(this.positionGroupBox, 0, 0);
            this.cuboidParametersTablePanel.Controls.Add(this.deleteObjectButton, 0, 9);
            this.cuboidParametersTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuboidParametersTablePanel.Location = new System.Drawing.Point(0, 0);
            this.cuboidParametersTablePanel.Name = "cuboidParametersTablePanel";
            this.cuboidParametersTablePanel.RowCount = 10;
            this.cuboidParametersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.cuboidParametersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.cuboidParametersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.cuboidParametersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.cuboidParametersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.cuboidParametersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.cuboidParametersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.cuboidParametersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.cuboidParametersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.cuboidParametersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.cuboidParametersTablePanel.Size = new System.Drawing.Size(276, 351);
            this.cuboidParametersTablePanel.TabIndex = 1;
            // 
            // positionGroupBox
            // 
            this.positionGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.positionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positionGroupBox.Location = new System.Drawing.Point(3, 3);
            this.positionGroupBox.Name = "positionGroupBox";
            this.positionGroupBox.Size = new System.Drawing.Size(270, 44);
            this.positionGroupBox.TabIndex = 0;
            this.positionGroupBox.TabStop = false;
            this.positionGroupBox.Text = "Position";
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
            this.tableLayoutPanel1.Controls.Add(this.posXNumericUpDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.posYNumericUpDown, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.posZNumericUpDown, 5, 0);
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
            this.label1.Text = "x:";
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
            this.label2.Text = "y:";
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
            this.label3.Text = "z:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // posXNumericUpDown
            // 
            this.posXNumericUpDown.DecimalPlaces = 2;
            this.posXNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posXNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.posXNumericUpDown.Location = new System.Drawing.Point(25, 3);
            this.posXNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.posXNumericUpDown.Name = "posXNumericUpDown";
            this.posXNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.posXNumericUpDown.TabIndex = 3;
            this.posXNumericUpDown.ValueChanged += new System.EventHandler(this.posXNumericUpDown_ValueChanged);
            // 
            // posYNumericUpDown
            // 
            this.posYNumericUpDown.DecimalPlaces = 2;
            this.posYNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posYNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.posYNumericUpDown.Location = new System.Drawing.Point(113, 3);
            this.posYNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.posYNumericUpDown.Name = "posYNumericUpDown";
            this.posYNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.posYNumericUpDown.TabIndex = 4;
            this.posYNumericUpDown.ValueChanged += new System.EventHandler(this.posYNumericUpDown_ValueChanged);
            // 
            // posZNumericUpDown
            // 
            this.posZNumericUpDown.DecimalPlaces = 2;
            this.posZNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posZNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.posZNumericUpDown.Location = new System.Drawing.Point(201, 3);
            this.posZNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.posZNumericUpDown.Name = "posZNumericUpDown";
            this.posZNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.posZNumericUpDown.TabIndex = 5;
            this.posZNumericUpDown.ValueChanged += new System.EventHandler(this.posZNumericUpDown_ValueChanged);
            // 
            // deleteObjectButton
            // 
            this.deleteObjectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteObjectButton.Location = new System.Drawing.Point(3, 433);
            this.deleteObjectButton.Name = "deleteObjectButton";
            this.deleteObjectButton.Size = new System.Drawing.Size(270, 34);
            this.deleteObjectButton.TabIndex = 3;
            this.deleteObjectButton.Text = "Delete";
            this.deleteObjectButton.UseVisualStyleBackColor = true;
            this.deleteObjectButton.Click += new System.EventHandler(this.deleteObjectButton_Click);
            // 
            // ObjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cuboidParametersTablePanel);
            this.Name = "ObjectControl";
            this.Size = new System.Drawing.Size(276, 351);
            this.cuboidParametersTablePanel.ResumeLayout(false);
            this.positionGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posZNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TableLayoutPanel cuboidParametersTablePanel;
        private System.Windows.Forms.Button deleteObjectButton;
        private System.Windows.Forms.GroupBox positionGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown posXNumericUpDown;
        private System.Windows.Forms.NumericUpDown posYNumericUpDown;
        private System.Windows.Forms.NumericUpDown posZNumericUpDown;
    }
}
