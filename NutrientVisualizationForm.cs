using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace NutriTrack
{
    public partial class NutrientVisualizationForm : Form
    {
        public NutrientVisualizationForm()
        {
            this.WindowState = FormWindowState.Maximized; // يفتح النافذة بحجم متكامل
            InitializeComponent();
            chartOne();
            chartTwo();
            charThree();
            charFour();
            charSix();
        }
        private void chartOne()
        {

            string query = "select portion_description, sum(measure_unit_id) as Total from food_portion group by portion_description";

           
            
                using(SqlDataReader reader = DatabaseConnection.Instance.ExecuteReader(query)){

                chart1.Series.Clear();
                chart1.Series.Add("Series1");
                chart1.Series["Series1"].ChartType = SeriesChartType.Pie; 

                while (reader.Read())
                {
                    string category = reader["portion_description"].ToString();
                    int total = Convert.ToInt32(reader["Total"]);

                    chart1.Series["Series1"].Points.AddXY(category, total);
                }

                chart1.Series["Series1"].IsValueShownAsLabel = true;
                chart1.Legends[0].Enabled = true;
            }
        
         }
        private void chartTwo()
        {
            // string connstring = "Data Source=DESKTOP-D6ER14M;Initial Catalog=NutriTrack;Integrated Security=True";
            string query = "select portion_description, sum(measure_unit_id) as Total from food_portion group by portion_description ORDER BY Total";
            using(SqlDataReader reader = DatabaseConnection.Instance.ExecuteReader(query)){
              
                chart2.Series.Clear();
                chart2.Series.Add("Series2");
                chart2.Series["Series2"].Color = System.Drawing.Color.MediumSeaGreen;
                chart2.Series["Series2"].ChartType = SeriesChartType.Bar; 

                
                chart2.Series["Series2"].IsValueShownAsLabel = true;
                chart2.ChartAreas[0].AxisY.Title = "% Daily Value";
                chart2.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                while (reader.Read())
                {
                    string category = reader["portion_description"].ToString();
                    int total = Convert.ToInt32(reader["Total"]);
                    chart2.Series["Series2"].Points.AddXY(category, total);
                }
            }
         }
        private void charThree()
        {
          //  string connstring = "Data Source=DESKTOP-D6ER14M;Initial Catalog=NutriTrack;Integrated Security=True";
            string query = "select portion_description, sum(measure_unit_id) as Total from food_portion group by portion_description ORDER BY Total "; 
            using(SqlDataReader reader = DatabaseConnection.Instance.ExecuteReader(query)){

                chart3.Series.Clear();
                chart3.Series.Add("Series3"); 
                chart3.Series["Series3"].ChartType = SeriesChartType.Line; 
                chart3.Series["Series3"].BorderWidth = 3; 
                chart3.Series["Series3"].MarkerStyle = MarkerStyle.Circle; 
                chart3.Series["Series3"].MarkerSize = 8; 
                chart3.Series["Series3"].IsValueShownAsLabel = true; 
                chart3.ChartAreas[0].AxisX.Title = "Day";
                chart3.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                chart3.ChartAreas[0].AxisY.Title = "Calories (Kcal)";
                chart3.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                chart3.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                chart3.Legends[0].Enabled = false;

                while (reader.Read())
                {
                    string category = reader["portion_description"].ToString();
                    int total = Convert.ToInt32(reader["Total"]);

                    
                    chart3.Series["Series3"].Points.AddXY(category, total);
                }
            }
        }
        private void charFour()
        {
       //     string connstring = "Data Source=DESKTOP-D6ER14M;Initial Catalog=NutriTrack;Integrated Security=True";
            string query = "select portion_description, sum(measure_unit_id) as Total from food_portion group by portion_description";

            using(SqlDataReader reader = DatabaseConnection.Instance.ExecuteReader(query)){
                chart4.Series.Clear();
                chart4.Series.Add("Series4"); 
                chart4.Series["Series4"].ChartType = SeriesChartType.Point;
                chart4.Series["Series4"].MarkerStyle = MarkerStyle.Circle; 
                chart4.Series["Series4"].MarkerSize = 10; 
                chart4.Series["Series4"].IsValueShownAsLabel = true;
                chart4.ChartAreas[0].AxisX.Title = "Fat (g)";
                chart4.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                chart4.ChartAreas[0].AxisY.Title = "Protein (g)";
                chart4.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                chart4.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                //chart4.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chart4.Legends[0].Enabled = false;

                while (reader.Read())
                {
                    string category = reader["portion_description"].ToString();
                    int total = Convert.ToInt32(reader["Total"]);
                    chart4.Series["Series4"].Points.AddXY(category, total);
                }

            }
        }
        private void charSix()
        {
            string connstring = "Data Source=DESKTOP-D6ER14M;Initial Catalog=NutriTrack;Integrated Security=True";
            string query = "select portion_description, sum(measure_unit_id) as Total from food_portion group by portion_description";

            using(SqlDataReader reader = DatabaseConnection.Instance.ExecuteReader(query)){

                chart6.Series.Clear();
                chart6.Series.Add("Series6"); 
                chart6.Series["Series6"].ChartType = SeriesChartType.Area;
                chart6.Series["Series6"].BorderWidth = 2; 
                chart6.Series["Series6"].Color = System.Drawing.Color.FromArgb(120, 0, 192, 192);
                chart6.Series["Series6"].BorderColor = System.Drawing.Color.Teal; 
                chart6.Series["Series6"].MarkerStyle = MarkerStyle.Circle; 
                chart6.Series["Series6"].MarkerSize = 7; 
                chart6.Series["Series6"].IsValueShownAsLabel = true;

                chart6.ChartAreas[0].AxisX.Title = "Day Of Week";
                chart6.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                chart6.ChartAreas[0].AxisY.Title = "Fiber (g)";
                chart6.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                chart6.ChartAreas[0].AxisX.IsLabelAutoFit = true; 
                //chart6.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chart6.Legends[0].Enabled = false;
                while (reader.Read())
                {
                    string category = reader["portion_description"].ToString();
                    int total = Convert.ToInt32(reader["Total"]);
                    chart6.Series["Series6"].Points.AddXY(category, total);
                }
            }

        }
        private void buttonBackNutrientV_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
