
using System;
using System.Windows.Forms;

namespace NutriTrack
{
    public partial class AboutForm : UserControl
    {
        public AboutForm()
        {
            InitializeComponent();

        }

        private void buttonBackAbout_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
