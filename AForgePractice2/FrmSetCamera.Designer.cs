namespace AForgePractice2
{
    partial class FrmSetCamera
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
            this.btnApplySettings = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectDevice = new System.Windows.Forms.Button();
            this.cbCaptureDevices = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbVideoResolutions = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApplySettings
            // 
            this.btnApplySettings.Location = new System.Drawing.Point(323, 168);
            this.btnApplySettings.Name = "btnApplySettings";
            this.btnApplySettings.Size = new System.Drawing.Size(118, 49);
            this.btnApplySettings.TabIndex = 0;
            this.btnApplySettings.Text = "Apply";
            this.btnApplySettings.UseVisualStyleBackColor = true;
            this.btnApplySettings.Click += new System.EventHandler(this.btnApplySettings_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(190, 168);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(118, 49);
            this.btnCloseForm.TabIndex = 1;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectDevice);
            this.groupBox1.Controls.Add(this.cbCaptureDevices);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Camera Device";
            // 
            // btnSelectDevice
            // 
            this.btnSelectDevice.Location = new System.Drawing.Point(357, 10);
            this.btnSelectDevice.Name = "btnSelectDevice";
            this.btnSelectDevice.Size = new System.Drawing.Size(65, 51);
            this.btnSelectDevice.TabIndex = 1;
            this.btnSelectDevice.Text = "Select";
            this.btnSelectDevice.UseVisualStyleBackColor = true;
            this.btnSelectDevice.Click += new System.EventHandler(this.btnSelectDevice_Click);
            // 
            // cbCaptureDevices
            // 
            this.cbCaptureDevices.FormattingEnabled = true;
            this.cbCaptureDevices.Location = new System.Drawing.Point(7, 27);
            this.cbCaptureDevices.Name = "cbCaptureDevices";
            this.cbCaptureDevices.Size = new System.Drawing.Size(344, 21);
            this.cbCaptureDevices.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbVideoResolutions);
            this.groupBox2.Location = new System.Drawing.Point(13, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 68);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Resolution/FPS";
            // 
            // cbVideoResolutions
            // 
            this.cbVideoResolutions.FormattingEnabled = true;
            this.cbVideoResolutions.Location = new System.Drawing.Point(7, 27);
            this.cbVideoResolutions.Name = "cbVideoResolutions";
            this.cbVideoResolutions.Size = new System.Drawing.Size(415, 21);
            this.cbVideoResolutions.TabIndex = 0;
            // 
            // FrmSetCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 230);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnApplySettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSetCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Camera Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApplySettings;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectDevice;
        private System.Windows.Forms.ComboBox cbCaptureDevices;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbVideoResolutions;
    }
}