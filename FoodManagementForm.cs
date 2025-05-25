using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriTrack
{
    public partial class FoodManagementForm : UserControl
    {
        public FoodManagementForm()
        {
            InitializeComponent();
            loadlistviewitems();

        }

        private void buttonBackFoodManagem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void ButtonExportDataFoodManagem_Click(object sender, EventArgs e)
        {
            ExportDialogcs exportDialogcs= new ExportDialogcs(listView1);
            exportDialogcs.Show();
            this.Hide();
        }

        private void loadlistviewitems()
        {
/*            using (SqlDataReader read = DatabaseConnection.Instance.ExecuteReader("SELECT * FROM Nutrients"))
            {
                while (read.Read())
                {
                    ListViewItem listView = new ListViewItem(read["NutrientID"].ToString());
                
                    listView.SubItems.Add(read["NutrientName"].ToString());
                    listView.SubItems.Add(read["Unit"].ToString());
                    listView.SubItems.Add(read["IsMacronutrient"].ToString());
                    listView1.Items.Add(listView);  
                }
            }*/
        }
        
        


        private void ButtonDeleteFoodFoodManagem_Click(object sender, EventArgs e)
        { if(listView1.SelectedItems.Count==0)return;
            listView1.SelectedItems[0].Remove();
            
            // after this we can (hafeed) 
            // make function that delete from database
        }

        private void ButtonClearFoodFoodManagem_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void ButtonUpdateFoodFoodManagem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                TextBoxFoodNameFoodManageme.Text= item.SubItems[1].Text;
                TextBoxServingSizeFoodManageme.Text=item.SubItems[2].Text;
                TextBoxCaloriesFoodManageme.Text=item.SubItems[3].Text;
     
            }
        }

        private void FoodManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
