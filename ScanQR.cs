using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using ZXing;
using AForge.Video.DirectShow;
namespace NutriTrack
{
    public partial class ScanQR : Form
    {
        public ScanQR()
        {
            InitializeComponent();
        }
        FilterInfoCollection fileterCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if (fileterCollection == null || fileterCollection.Count == 0)
            {
                MessageBox.Show("No camera devices found.");
                return;
            }

            if (ComaraDevices.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a camera device first.");
                return;
            }
            videoCaptureDevice = new VideoCaptureDevice(fileterCollection[ComaraDevices.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += videoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer.Start();
        }

        private void ScanCode_Load(object sender, EventArgs e)
        {
            fileterCollection= new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in fileterCollection )
            { 
                ComaraDevices.Items.Add(device.Name);
                ComaraDevices.SelectedIndex = 0;
            }
        }
        
        
        
        private void videoCaptureDevice_NewFrame(object sender,AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap=(Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                textQRcode.Invoke(new MethodInvoker(
                    delegate(){
                        textQRcode.Text = result.ToString();
            
            
                        try
                        {
                            // SystemSounds.Beep.Play(); // You can replace with your own WAV file below
                            SoundPlayer player = new SoundPlayer("C:\\Users\\Lenovo\\RiderProjects\\WinFormsApp3\\WinFormsApp3\\store-scanner-beep-90395.wav");
                            player.Play();

                            NutrientVisualizationForm nu = new NutrientVisualizationForm();
                            nu.Show();
                            this.Hide();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Sound error: " + ex.Message);
                        }
            
            
                    }));
            }
            pictureBox.Image = bitmap;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBox.Image);
                if (result != null)
                {   
                    textQRcode.Text=result.Text;
                    timer.Stop();
                }
            }
        }

        private void ScanCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
            }
        }
    }
}