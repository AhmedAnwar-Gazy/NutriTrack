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
    public partial class HomeContent : UserControl
    {
        public HomeContent()
        {
            InitializeComponent();
        }

        private void HomeContent_Load(object sender, EventArgs e)
        {

        }

        private void scanbuttonHome_Click(object sender, EventArgs e)
        {
            ScanQR qr = new ScanQR();
            qr.Show();
        }

        private void ButtonSearchViewNuData_Click(object sender, EventArgs e)
        {
            NutrientVisualizationForm nutrientVisualizationForm = new NutrientVisualizationForm(textBoxSearchHome.Text);
            nutrientVisualizationForm.Show();
            this.Hide();
        }
    }
}
