using System;
using System.Windows.Forms;

namespace AForgePractice2
{
    public partial class FrmSetColor : Form
    {
        MainForm mainForm = (MainForm)Application.OpenForms["Mainform"];
        public FrmSetColor()
        {
            InitializeComponent();
            chkActivePassive.Checked = mainForm.ActivateColorTracking;
            redTrackBar.Value = mainForm.Red;
            greenTrackBar.Value = mainForm.Green;
            blueTrackBar.Value = mainForm.Blue;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkActivePassive_CheckedChanged(object sender, EventArgs e)
        {           
            mainForm.ActivateColorTracking = chkActivePassive.Checked;
        }

        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            mainForm.Red = redTrackBar.Value;
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            mainForm.Green = greenTrackBar.Value;
        }

        private void blueTrackBar_Scroll(object sender, EventArgs e)
        {
            mainForm.Blue = blueTrackBar.Value;
        }
    }
}
