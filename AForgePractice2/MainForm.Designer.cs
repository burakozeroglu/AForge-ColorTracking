namespace AForgePractice2
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cameraSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOrjinalOrProcessImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiOrSingleTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbOrjinalimage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrjinalimage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraSettingsToolStripMenuItem,
            this.imageProcessToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cameraSettingsToolStripMenuItem
            // 
            this.cameraSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cameraSettingsToolStripMenuItem.Name = "cameraSettingsToolStripMenuItem";
            this.cameraSettingsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cameraSettingsToolStripMenuItem.Text = "Ca&mera";
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.setToolStripMenuItem.Text = "Set &Up";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.setToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.startToolStripMenuItem.Text = "&Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.stopToolStripMenuItem.Text = "S&top";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // imageProcessToolStripMenuItem
            // 
            this.imageProcessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorTrackingToolStripMenuItem,
            this.showOrjinalOrProcessImageToolStripMenuItem,
            this.multiOrSingleTrackingToolStripMenuItem});
            this.imageProcessToolStripMenuItem.Name = "imageProcessToolStripMenuItem";
            this.imageProcessToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.imageProcessToolStripMenuItem.Text = "Image &Process";
            // 
            // colorTrackingToolStripMenuItem
            // 
            this.colorTrackingToolStripMenuItem.Name = "colorTrackingToolStripMenuItem";
            this.colorTrackingToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.colorTrackingToolStripMenuItem.Text = "Color &Tracking";
            this.colorTrackingToolStripMenuItem.Click += new System.EventHandler(this.colorTrackingToolStripMenuItem_Click);
            // 
            // showOrjinalOrProcessImageToolStripMenuItem
            // 
            this.showOrjinalOrProcessImageToolStripMenuItem.Checked = true;
            this.showOrjinalOrProcessImageToolStripMenuItem.CheckOnClick = true;
            this.showOrjinalOrProcessImageToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showOrjinalOrProcessImageToolStripMenuItem.Name = "showOrjinalOrProcessImageToolStripMenuItem";
            this.showOrjinalOrProcessImageToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.showOrjinalOrProcessImageToolStripMenuItem.Text = "Show Orjinal Or Process Image";
            this.showOrjinalOrProcessImageToolStripMenuItem.Click += new System.EventHandler(this.showOrjinalOrProcessImageToolStripMenuItem_Click);
            // 
            // multiOrSingleTrackingToolStripMenuItem
            // 
            this.multiOrSingleTrackingToolStripMenuItem.Checked = true;
            this.multiOrSingleTrackingToolStripMenuItem.CheckOnClick = true;
            this.multiOrSingleTrackingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.multiOrSingleTrackingToolStripMenuItem.Name = "multiOrSingleTrackingToolStripMenuItem";
            this.multiOrSingleTrackingToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.multiOrSingleTrackingToolStripMenuItem.Text = "Multi Or Single Tracking";
            this.multiOrSingleTrackingToolStripMenuItem.Click += new System.EventHandler(this.multiOrSingleTrackingToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.CloseToolStripMenuItem.Text = "Cl&ose";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // pbOrjinalimage
            // 
            this.pbOrjinalimage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbOrjinalimage.Location = new System.Drawing.Point(0, 27);
            this.pbOrjinalimage.Name = "pbOrjinalimage";
            this.pbOrjinalimage.Size = new System.Drawing.Size(651, 401);
            this.pbOrjinalimage.TabIndex = 1;
            this.pbOrjinalimage.TabStop = false;
            this.pbOrjinalimage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbOrjinalimage_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 440);
            this.Controls.Add(this.pbOrjinalimage);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "MainForm";
            this.Text = "AForge - Exercise";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrjinalimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cameraSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbOrjinalimage;
        private System.Windows.Forms.ToolStripMenuItem imageProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorTrackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOrjinalOrProcessImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiOrSingleTrackingToolStripMenuItem;
    }
}