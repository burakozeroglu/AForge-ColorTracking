namespace AForgePractice2
{
    partial class FrmSetColor
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
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkActivePassive = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(38, 15);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.redTrackBar.Size = new System.Drawing.Size(45, 165);
            this.redTrackBar.TabIndex = 22;
            this.redTrackBar.Value = 1;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.Location = new System.Drawing.Point(167, 15);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.blueTrackBar.Size = new System.Drawing.Size(45, 165);
            this.blueTrackBar.TabIndex = 23;
            this.blueTrackBar.Value = 1;
            this.blueTrackBar.Scroll += new System.EventHandler(this.blueTrackBar_Scroll);
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(101, 15);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.greenTrackBar.Size = new System.Drawing.Size(45, 165);
            this.greenTrackBar.TabIndex = 24;
            this.greenTrackBar.Value = 1;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Blue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "255";
            // 
            // chkActivePassive
            // 
            this.chkActivePassive.AutoSize = true;
            this.chkActivePassive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkActivePassive.Location = new System.Drawing.Point(10, 215);
            this.chkActivePassive.Name = "chkActivePassive";
            this.chkActivePassive.Size = new System.Drawing.Size(126, 21);
            this.chkActivePassive.TabIndex = 30;
            this.chkActivePassive.Text = "Active / Passive";
            this.chkActivePassive.UseVisualStyleBackColor = true;
            this.chkActivePassive.CheckedChanged += new System.EventHandler(this.chkActivePassive_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(144, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmSetColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 248);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkActivePassive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.redTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSetColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Color Settings";
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkActivePassive;
        private System.Windows.Forms.Button btnClose;
    }
}