using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriTrack
{
    public partial class ProfileForm : UserControl
    {
        public ProfileForm()
        {
            InitializeComponent();
/*            this.WindowState = FormWindowState.Maximized; // يفتح النافذة بحجم متكامل
*/
        }

        private void ButtonEditProfile_Click(object sender, EventArgs e)
        {

        }

        private void buttonBackProfile_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
