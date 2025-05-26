using System.Media;
using NutriTrack;
using ZXing;

namespace NutriTrack

using AForge.Video;
using AForge.Video.DirectShow;
public partial class Form5 : Form
{
    public Form5()
    {
        InitializeComponent();
    }

     FilterInfoCollection fileterCollection;
     VideoCaptureDevice videoCaptureDevice;

    private void label1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Form5_Load(object sender, EventArgs e)
    {
        fileterCollection= new FilterInfoCollection(FilterCategory.VideoInputDevice);
        foreach (FilterInfo device in fileterCollection )
        {
            comCamara.Items.Add(device.Name);
            comCamara.SelectedIndex = 0;
        }
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        videoCaptureDevice = new VideoCaptureDevice(fileterCollection[comCamara.SelectedIndex].MonikerString);
        videoCaptureDevice.NewFrame += videoCaptureDevice_NewFrame;
        videoCaptureDevice.Start();
        
    }

    private void videoCaptureDevice_NewFrame(object sender,AForge.Video.NewFrameEventArgs eventArgs)
    {
        Bitmap bitmap=(Bitmap)eventArgs.Frame.Clone();
        BarcodeReader reader = new BarcodeReader();
        var result = reader.Decode(bitmap);
        if (result != null)
        {
            textBarCode.Invoke(new MethodInvoker(
                delegate(){
            textBarCode.Text = result.ToString();
            
            
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

    private void Form5_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (videoCaptureDevice != null)
        {
            videoCaptureDevice.SignalToStop();
            videoCaptureDevice.WaitForStop();
        }
    }

    private void Form5_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (videoCaptureDevice != null)
        {
            videoCaptureDevice.SignalToStop();
            videoCaptureDevice.WaitForStop();
        }
    }
}