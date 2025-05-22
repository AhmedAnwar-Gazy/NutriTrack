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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonAboutHome_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
            this.Hide();
        }

        private void buttonManageMyFoodsHome_Click(object sender, EventArgs e)
        {
            FoodManagementForm foodManagementForm = new FoodManagementForm();
            foodManagementForm.Show();
            this.Hide();
        }

        private void buttonLogoutHome_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void buttonprofileHome_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
            this.Hide();
        }

        private void ButtonSearchViewNuData_Click(object sender, EventArgs e)
        {
            NutrientVisualizationForm nutrientVisualizationForm = new NutrientVisualizationForm();
            nutrientVisualizationForm.Show();
            this.Hide();
        }
    }
}
