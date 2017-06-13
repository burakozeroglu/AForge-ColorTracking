using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AForgePractice2
{
    public partial class FrmSetCamera : Form
    {
        private FilterInfoCollection VideoCapTureDevices;
        private VideoCaptureDevice CurrentDevices;
        public FrmSetCamera()
        {
            InitializeComponent();
            LoadCaptureDevices();
        }

        private void LoadCaptureDevices()
        {
            try
            {
                VideoCapTureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo VideoCaptureDevice in VideoCapTureDevices)
                {
                    cbCaptureDevices.Items.Add(VideoCaptureDevice.Name);
                }
                if (cbCaptureDevices.Items.Count > 0)
                {
                    cbCaptureDevices.SelectedIndex = 0;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kamera Cihazları Yüklenemedi. Hata : {0}",ex.InnerException.ToString());
            }
        }

        private void LoadDeviceResolutions()
        {
            try
            {
                cbVideoResolutions.Items.Clear();
                foreach (var item in CurrentDevices.VideoCapabilities)
                {
                    cbVideoResolutions.Items.Add(item.FrameSize + " - " + item.AverageFrameRate + "Fps");
                }

                if (cbVideoResolutions.Items.Count > 0)
                {
                    cbVideoResolutions.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kamera Çözünürlükleri Yüklenemedi. Hata : {0}", ex.InnerException.ToString());
            }
        }

        private void btnSelectDevice_Click(object sender, EventArgs e)
        {
            try
            {               
                CurrentDevices = new VideoCaptureDevice(VideoCapTureDevices[cbCaptureDevices.SelectedIndex].MonikerString);
                LoadDeviceResolutions();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnApplySettings_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            CurrentDevices.VideoResolution = CurrentDevices.VideoCapabilities[cbVideoResolutions.SelectedIndex];
            mainForm.CurrentDevices = CurrentDevices;
      
            this.DialogResult = DialogResult.OK;
        }      
    }
}
