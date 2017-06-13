using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace AForgePractice2
{
    public partial class MainForm : Form
    {
        public VideoCaptureDevice CurrentDevices;
        public bool ActivateColorTracking;
        public bool ShowOrjinalOrProcessImage = true;
        public bool MultiOrSingleTracking=true;
        public int Red;
        public int Green;
        public int Blue;
        Rectangle[] rects;

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSetCamera frmSetCamera = new FrmSetCamera();
            if (CurrentDevices != null )
            {
                CurrentDevices.NewFrame -= new NewFrameEventHandler(CurrentDevices_NewFrame);
                if (CurrentDevices.IsRunning)
                {
                    CurrentDevices.Stop();
                    CurrentDevices.WaitForStop(); 
                }
            }
            if (frmSetCamera.ShowDialog() == DialogResult.OK)
            {             
                CurrentDevices.NewFrame += new NewFrameEventHandler(CurrentDevices_NewFrame);
                pbOrjinalimage.Width = CurrentDevices.VideoResolution.FrameSize.Width;
                pbOrjinalimage.Height = CurrentDevices.VideoResolution.FrameSize.Height;
                this.Width = pbOrjinalimage.Width;
                this.Height = pbOrjinalimage.Height + 65;
                CurrentDevices.Start();
            }            
        }
        private void CurrentDevices_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            Bitmap image1 = (Bitmap)eventArgs.Frame.Clone();

            if (!ActivateColorTracking)
            {
                pbOrjinalimage.Image = image;
            }

            if (ActivateColorTracking)
            {
                if (ShowOrjinalOrProcessImage)
                {
                    pbOrjinalimage.Image = image1;
                }
                EuclideanColorFiltering filter = new EuclideanColorFiltering();               
                filter.CenterColor = new RGB(Color.FromArgb(Red, Green, Blue));
                filter.Radius = 100;
                // apply the filter
                filter.ApplyInPlace(image);
                FindObjects(image);
            }            
        }
        private void FindObjects(Bitmap image)
        {
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.MinWidth = 5;
            blobCounter.MinHeight = 5;
            blobCounter.FilterBlobs = true;
            blobCounter.ObjectsOrder = ObjectsOrder.Size;

            BitmapData objectsData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, image.PixelFormat);
            // grayscaling
            Grayscale grayscaleFilter = new Grayscale(0.2125, 0.7154, 0.0721);
            grayscaleFilter.Apply(new UnmanagedImage(objectsData));
            // unlock image
            image.UnlockBits(objectsData);

            blobCounter.ProcessImage(image);
            rects = blobCounter.GetObjectsRectangles();
            
            if (!ShowOrjinalOrProcessImage)
            {
                pbOrjinalimage.Image = image;
            }

            if (MultiOrSingleTracking)
            {
                //Multi Tracking            
                for (int i = 0; rects.Length > i; i++)
                {
                    Rectangle objectRect = rects[i];
                    Graphics g = pbOrjinalimage.CreateGraphics();
                    using (Pen pen = new Pen(Color.FromArgb(252, 3, 26), 2))
                    {
                        g.DrawRectangle(pen, objectRect);
                        g.DrawString((i + 1).ToString(), new Font("Arial", 12), Brushes.Red, objectRect);
                    }
                    g.Dispose();
                } 
            }

            if (!MultiOrSingleTracking)
            {
                //Single Big Object Tracking
                if (rects.Length > 0)
                {
                    Rectangle objectRect = rects[0];
                    Graphics g = pbOrjinalimage.CreateGraphics();
                    using (Pen pen = new Pen(Color.FromArgb(252, 3, 26), 2))
                    {
                        g.DrawRectangle(pen, objectRect);
                    }
                    g.Dispose();
                } 
            }
        }

        #region Camera Menu
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentDevices != null && !(CurrentDevices.IsRunning))
            {
                try
                {
                    CurrentDevices.Start();
                }
                catch
                {
                    
                }
            }
        }
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentDevices != null && CurrentDevices.IsRunning)
            {
                try
                {
                    CurrentDevices.Stop();
                }
                catch
                {

                }
            }
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentDevices != null && CurrentDevices.IsRunning)
            {
                try
                {
                    CurrentDevices.Stop();
                    CurrentDevices = null;
                    pbOrjinalimage.Image = null;
                    pbOrjinalimage.BackColor = Color.Black;
                }
                catch
                {

                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion Camera Menu        

        #region Image Process Menu
        private void colorTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSetColor frmSetColor;
            frmSetColor = (FrmSetColor)Application.OpenForms["FrmSetColor"];
            if (frmSetColor != null)
            {
                frmSetColor.Focus();
            }
            if (frmSetColor == null)
            {
                frmSetColor = new FrmSetColor();
                frmSetColor.Show();
            }
        }
        private void showOrjinalOrProcessImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrjinalOrProcessImage = showOrjinalOrProcessImageToolStripMenuItem.Checked;
        }
        private void multiOrSingleTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultiOrSingleTracking = multiOrSingleTrackingToolStripMenuItem.Checked;
        }
        #endregion Image Process Menu

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (CurrentDevices != null && CurrentDevices.IsRunning)
            {
                try
                {
                    CurrentDevices.Stop();
                    CurrentDevices = null;
                }
                catch
                {

                }
            }
            base.OnClosing(e);
        }

        private void pbOrjinalimage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           Bitmap curretImage = pbOrjinalimage.Image as Bitmap;
           int resultIndex = -1;           
           Rectangle[] copyRects = (Rectangle[])rects.Clone();        
           Point clickedPoint = e.Location;

            for (int i = 0; i < copyRects.Length - 1; i++)
            {
                if (copyRects[i].Contains(clickedPoint))
                {
                    resultIndex = i;
                    break;
                }
            }

            if (resultIndex != -1)
            {
                Rectangle cropRect = new Rectangle();
                cropRect = copyRects[resultIndex];
                Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);
                using (Graphics g = Graphics.FromImage(target))
                {
                    g.DrawImage(curretImage, new Rectangle(0, 0, target.Width, target.Height),
                                     cropRect,
                                     GraphicsUnit.Pixel);
                }
                ShowCroppedArea showCroppedArea = new ShowCroppedArea(target);
                showCroppedArea.Show();
            }
        }
    }
}
