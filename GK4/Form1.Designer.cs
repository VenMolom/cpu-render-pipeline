namespace GK4
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.renderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backfaceCullingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perspectiveCorelationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zbufferingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wireframeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambientLightColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.addObjectsGroupBox = new System.Windows.Forms.GroupBox();
            this.addObjectsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.addCuboidButton = new System.Windows.Forms.Button();
            this.addSphereButton = new System.Windows.Forms.Button();
            this.addCylinderButton = new System.Windows.Forms.Button();
            this.addConeButton = new System.Windows.Forms.Button();
            this.addLightButton = new System.Windows.Forms.Button();
            this.addCameraButton = new System.Windows.Forms.Button();
            this.editObjectsGroupBox = new System.Windows.Forms.GroupBox();
            this.objectsGroupBox = new System.Windows.Forms.GroupBox();
            this.objectsListBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainTablePanel.SuspendLayout();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuTablePanel.SuspendLayout();
            this.addObjectsGroupBox.SuspendLayout();
            this.addObjectsTablePanel.SuspendLayout();
            this.objectsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTablePanel
            // 
            this.mainTablePanel.ColumnCount = 2;
            this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.mainTablePanel.Controls.Add(this.picturePanel, 0, 0);
            this.mainTablePanel.Controls.Add(this.menuTablePanel, 1, 0);
            this.mainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTablePanel.Location = new System.Drawing.Point(0, 0);
            this.mainTablePanel.Name = "mainTablePanel";
            this.mainTablePanel.RowCount = 1;
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.Size = new System.Drawing.Size(1376, 821);
            this.mainTablePanel.TabIndex = 0;
            // 
            // picturePanel
            // 
            this.picturePanel.Controls.Add(this.pictureBox);
            this.picturePanel.Controls.Add(this.menuStrip1);
            this.picturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePanel.Location = new System.Drawing.Point(3, 3);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(1120, 815);
            this.picturePanel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1120, 791);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.SizeChanged += new System.EventHandler(this.pictureBox_SizeChanged);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renderingToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // renderingToolStripMenuItem
            // 
            this.renderingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backfaceCullingToolStripMenuItem,
            this.perspectiveCorelationToolStripMenuItem,
            this.zbufferingToolStripMenuItem,
            this.wireframeToolStripMenuItem,
            this.ambientLightColorToolStripMenuItem});
            this.renderingToolStripMenuItem.Name = "renderingToolStripMenuItem";
            this.renderingToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.renderingToolStripMenuItem.Text = "Rendering";
            // 
            // backfaceCullingToolStripMenuItem
            // 
            this.backfaceCullingToolStripMenuItem.Checked = true;
            this.backfaceCullingToolStripMenuItem.CheckOnClick = true;
            this.backfaceCullingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backfaceCullingToolStripMenuItem.Name = "backfaceCullingToolStripMenuItem";
            this.backfaceCullingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.backfaceCullingToolStripMenuItem.Text = "Backface culling";
            this.backfaceCullingToolStripMenuItem.CheckedChanged += new System.EventHandler(this.backfaceCullingToolStripMenuItem_CheckedChanged);
            // 
            // perspectiveCorelationToolStripMenuItem
            // 
            this.perspectiveCorelationToolStripMenuItem.Checked = true;
            this.perspectiveCorelationToolStripMenuItem.CheckOnClick = true;
            this.perspectiveCorelationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.perspectiveCorelationToolStripMenuItem.Name = "perspectiveCorelationToolStripMenuItem";
            this.perspectiveCorelationToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.perspectiveCorelationToolStripMenuItem.Text = "Perspective correction";
            this.perspectiveCorelationToolStripMenuItem.CheckedChanged += new System.EventHandler(this.perspectiveCorelationToolStripMenuItem_CheckedChanged);
            // 
            // zbufferingToolStripMenuItem
            // 
            this.zbufferingToolStripMenuItem.Checked = true;
            this.zbufferingToolStripMenuItem.CheckOnClick = true;
            this.zbufferingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zbufferingToolStripMenuItem.Name = "zbufferingToolStripMenuItem";
            this.zbufferingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.zbufferingToolStripMenuItem.Text = "Z-buffering";
            this.zbufferingToolStripMenuItem.CheckedChanged += new System.EventHandler(this.zbufferingToolStripMenuItem_CheckedChanged);
            // 
            // wireframeToolStripMenuItem
            // 
            this.wireframeToolStripMenuItem.CheckOnClick = true;
            this.wireframeToolStripMenuItem.Name = "wireframeToolStripMenuItem";
            this.wireframeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.wireframeToolStripMenuItem.Text = "Wireframe";
            this.wireframeToolStripMenuItem.CheckedChanged += new System.EventHandler(this.wireframeToolStripMenuItem_CheckedChanged);
            // 
            // ambientLightColorToolStripMenuItem
            // 
            this.ambientLightColorToolStripMenuItem.Name = "ambientLightColorToolStripMenuItem";
            this.ambientLightColorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ambientLightColorToolStripMenuItem.Text = "Ambient light color";
            this.ambientLightColorToolStripMenuItem.Click += new System.EventHandler(this.ambientLightColorToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // menuTablePanel
            // 
            this.menuTablePanel.ColumnCount = 1;
            this.menuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuTablePanel.Controls.Add(this.addObjectsGroupBox, 0, 0);
            this.menuTablePanel.Controls.Add(this.editObjectsGroupBox, 0, 1);
            this.menuTablePanel.Controls.Add(this.objectsGroupBox, 0, 2);
            this.menuTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTablePanel.Location = new System.Drawing.Point(1129, 3);
            this.menuTablePanel.Name = "menuTablePanel";
            this.menuTablePanel.RowCount = 3;
            this.menuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.menuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.menuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuTablePanel.Size = new System.Drawing.Size(244, 815);
            this.menuTablePanel.TabIndex = 1;
            // 
            // addObjectsGroupBox
            // 
            this.addObjectsGroupBox.Controls.Add(this.addObjectsTablePanel);
            this.addObjectsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addObjectsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.addObjectsGroupBox.Name = "addObjectsGroupBox";
            this.addObjectsGroupBox.Size = new System.Drawing.Size(238, 144);
            this.addObjectsGroupBox.TabIndex = 0;
            this.addObjectsGroupBox.TabStop = false;
            this.addObjectsGroupBox.Text = "Add";
            // 
            // addObjectsTablePanel
            // 
            this.addObjectsTablePanel.ColumnCount = 2;
            this.addObjectsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addObjectsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addObjectsTablePanel.Controls.Add(this.addCuboidButton, 0, 0);
            this.addObjectsTablePanel.Controls.Add(this.addSphereButton, 1, 0);
            this.addObjectsTablePanel.Controls.Add(this.addCylinderButton, 0, 1);
            this.addObjectsTablePanel.Controls.Add(this.addConeButton, 1, 1);
            this.addObjectsTablePanel.Controls.Add(this.addLightButton, 0, 2);
            this.addObjectsTablePanel.Controls.Add(this.addCameraButton, 1, 2);
            this.addObjectsTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addObjectsTablePanel.Location = new System.Drawing.Point(3, 16);
            this.addObjectsTablePanel.Name = "addObjectsTablePanel";
            this.addObjectsTablePanel.RowCount = 3;
            this.addObjectsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.addObjectsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.addObjectsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.addObjectsTablePanel.Size = new System.Drawing.Size(232, 125);
            this.addObjectsTablePanel.TabIndex = 0;
            // 
            // addCuboidButton
            // 
            this.addCuboidButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCuboidButton.Location = new System.Drawing.Point(3, 3);
            this.addCuboidButton.Name = "addCuboidButton";
            this.addCuboidButton.Size = new System.Drawing.Size(110, 35);
            this.addCuboidButton.TabIndex = 0;
            this.addCuboidButton.Text = "Cuboid";
            this.addCuboidButton.UseVisualStyleBackColor = true;
            this.addCuboidButton.Click += new System.EventHandler(this.addCuboidButton_Click);
            // 
            // addSphereButton
            // 
            this.addSphereButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSphereButton.Location = new System.Drawing.Point(119, 3);
            this.addSphereButton.Name = "addSphereButton";
            this.addSphereButton.Size = new System.Drawing.Size(110, 35);
            this.addSphereButton.TabIndex = 1;
            this.addSphereButton.Text = "Sphere";
            this.addSphereButton.UseVisualStyleBackColor = true;
            this.addSphereButton.Click += new System.EventHandler(this.addSphereButton_Click);
            // 
            // addCylinderButton
            // 
            this.addCylinderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCylinderButton.Location = new System.Drawing.Point(3, 44);
            this.addCylinderButton.Name = "addCylinderButton";
            this.addCylinderButton.Size = new System.Drawing.Size(110, 35);
            this.addCylinderButton.TabIndex = 2;
            this.addCylinderButton.Text = "Cylinder";
            this.addCylinderButton.UseVisualStyleBackColor = true;
            this.addCylinderButton.Click += new System.EventHandler(this.addCylinderButton_Click);
            // 
            // addConeButton
            // 
            this.addConeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addConeButton.Location = new System.Drawing.Point(119, 44);
            this.addConeButton.Name = "addConeButton";
            this.addConeButton.Size = new System.Drawing.Size(110, 35);
            this.addConeButton.TabIndex = 3;
            this.addConeButton.Text = "Cone";
            this.addConeButton.UseVisualStyleBackColor = true;
            this.addConeButton.Click += new System.EventHandler(this.addConeButton_Click);
            // 
            // addLightButton
            // 
            this.addLightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addLightButton.Location = new System.Drawing.Point(3, 85);
            this.addLightButton.Name = "addLightButton";
            this.addLightButton.Size = new System.Drawing.Size(110, 37);
            this.addLightButton.TabIndex = 4;
            this.addLightButton.Text = "Light";
            this.addLightButton.UseVisualStyleBackColor = true;
            this.addLightButton.Click += new System.EventHandler(this.addLightButton_Click);
            // 
            // addCameraButton
            // 
            this.addCameraButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCameraButton.Location = new System.Drawing.Point(119, 85);
            this.addCameraButton.Name = "addCameraButton";
            this.addCameraButton.Size = new System.Drawing.Size(110, 37);
            this.addCameraButton.TabIndex = 5;
            this.addCameraButton.Text = "Camera";
            this.addCameraButton.UseVisualStyleBackColor = true;
            this.addCameraButton.Click += new System.EventHandler(this.addCameraButton_Click);
            // 
            // editObjectsGroupBox
            // 
            this.editObjectsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editObjectsGroupBox.Location = new System.Drawing.Point(3, 153);
            this.editObjectsGroupBox.Name = "editObjectsGroupBox";
            this.editObjectsGroupBox.Size = new System.Drawing.Size(238, 494);
            this.editObjectsGroupBox.TabIndex = 1;
            this.editObjectsGroupBox.TabStop = false;
            this.editObjectsGroupBox.Text = "Edit";
            // 
            // objectsGroupBox
            // 
            this.objectsGroupBox.Controls.Add(this.objectsListBox);
            this.objectsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectsGroupBox.Location = new System.Drawing.Point(3, 653);
            this.objectsGroupBox.Name = "objectsGroupBox";
            this.objectsGroupBox.Size = new System.Drawing.Size(238, 159);
            this.objectsGroupBox.TabIndex = 2;
            this.objectsGroupBox.TabStop = false;
            this.objectsGroupBox.Text = "Objects";
            // 
            // objectsListBox
            // 
            this.objectsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectsListBox.FormattingEnabled = true;
            this.objectsListBox.Location = new System.Drawing.Point(3, 16);
            this.objectsListBox.Name = "objectsListBox";
            this.objectsListBox.Size = new System.Drawing.Size(232, 140);
            this.objectsListBox.TabIndex = 0;
            this.objectsListBox.SelectedIndexChanged += new System.EventHandler(this.objectsListBox_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 821);
            this.Controls.Add(this.mainTablePanel);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTablePanel.ResumeLayout(false);
            this.picturePanel.ResumeLayout(false);
            this.picturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuTablePanel.ResumeLayout(false);
            this.addObjectsGroupBox.ResumeLayout(false);
            this.addObjectsTablePanel.ResumeLayout(false);
            this.objectsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTablePanel;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel menuTablePanel;
        private System.Windows.Forms.GroupBox addObjectsGroupBox;
        private System.Windows.Forms.TableLayoutPanel addObjectsTablePanel;
        private System.Windows.Forms.Button addCuboidButton;
        private System.Windows.Forms.Button addSphereButton;
        private System.Windows.Forms.Button addCylinderButton;
        private System.Windows.Forms.Button addConeButton;
        private System.Windows.Forms.Button addLightButton;
        private System.Windows.Forms.Button addCameraButton;
        private System.Windows.Forms.GroupBox editObjectsGroupBox;
        private System.Windows.Forms.GroupBox objectsGroupBox;
        private System.Windows.Forms.ListBox objectsListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renderingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backfaceCullingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perspectiveCorelationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zbufferingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wireframeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambientLightColorToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

