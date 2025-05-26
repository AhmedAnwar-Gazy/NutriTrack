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
        private string _foodName; // To store the specific food name

        // Constructor now accepts the foodName
        public NutrientVisualizationForm(string foodName)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Opens the window maximized
            _foodName = foodName; // Store the food name

            // Call chart methods after setting the food name
            chartOne();
            chartTwo();
            charThree();
            charFour();
            charSix();
        }

        // Dummy DatabaseConnection class for demonstration purposes
        // You should have your actual DatabaseConnection class implementation
     

        private void chartOne()
        {
            // Pie chart for Macronutrient distribution
            string query = "SELECT ProteinGrams, FatTotalGrams, CarbohydrateGrams FROM food WHERE FoodName = @FoodName";

            using (SqlDataReader reader = DatabaseConnection.Instance.ExecuteReader(query, new SqlParameter("@FoodName", _foodName)))
            {
                chart1.Series.Clear();
                chart1.Series.Add("Macronutrients");
                chart1.Series["Macronutrients"].ChartType = SeriesChartType.Pie;
                chart1.Titles.Clear();
                chart1.Titles.Add($"Macronutrient Distribution for {_foodName}");


                if (reader.Read())
                {
                    decimal protein = reader.GetDecimal(reader.GetOrdinal("ProteinGrams"));
                    decimal fat = reader.GetDecimal(reader.GetOrdinal("FatTotalGrams"));
                    decimal carbs = reader.GetDecimal(reader.GetOrdinal("CarbohydrateGrams"));

                    chart1.Series["Macronutrients"].Points.AddXY("Protein", protein);
                    chart1.Series["Macronutrients"].Points.AddXY("Fat", fat);
                    chart1.Series["Macronutrients"].Points.AddXY("Carbohydrates", carbs);
                }

                chart1.Series["Macronutrients"].IsValueShownAsLabel = true;
                chart1.Legends[0].Enabled = true;
            }
        }

        private void chartTwo()
        {
            // Bar chart for selected Vitamins
            string query = "SELECT VitaminCMg, FolateTotalUg, VitaminB12CobalaminUg FROM food WHERE FoodName = @FoodName";

            using (SqlDataReader reader = DatabaseConnection.Instance.ExecuteReader(query, new SqlParameter("@FoodName", _foodName)))
            {
                chart2.Series.Clear();
                chart2.Series.Add("Vitamins");
                chart2.Series["Vitamins"].Color = System.Drawing.Color.MediumSeaGreen;
                chart2.Series["Vitamins"].ChartType = SeriesChartType.Bar;
                chart2.Titles.Clear();
                chart2.Titles.Add($"Key Vitamins in {_foodName}");

                chart2.Series["Vitamins"].IsValueShownAsLabel = true;
                chart2.ChartAreas[0].AxisY.Title = "Amount";
                chart2.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

                if (reader.Read())
                {
                    decimal vitaminC = reader.IsDBNull(reader.GetOrdinal("VitaminCMg")) ? 0 : reader.GetDecimal(reader.GetOrdinal("VitaminCMg"));
                    decimal folate = reader.IsDBNull(reader.GetOrdinal("FolateTotalUg")) ? 0 : reader.GetDecimal(reader.GetOrdinal("FolateTotalUg"));
                    decimal vitaminB12 = reader.IsDBNull(reader.GetOrdinal("VitaminB12CobalaminUg")) ? 0 : reader.GetDecimal(reader.GetOrdinal("VitaminB12CobalaminUg"));

                    chart2.Series["Vitamins"].Points.AddXY("Vitamin C (mg)", vitaminC);
                    chart2.Series["Vitamins"].Points.AddXY("Folate (ug)", folate);
                    chart2.Series["Vitamins"].Points.AddXY("Vitamin B12 (ug)", vitaminB12);
                }
            }
        }

        private void charThree()
        {
            // Line chart for Energy (Kcal) and potentially other general nutrients if available for multiple entries
            string query = "SELECT EnergyKcal, WaterGrams FROM food WHERE FoodName = @FoodName"; // Added WaterGrams as an example

            using (SqlDataReader reader = DatabaseConnection.Instance.ExecuteReader(query, new SqlParameter("@FoodName", _foodName)))
            {
                chart3.Series.Clear();
                chart3.Titles.Clear();
                chart3.Titles.Add($"Energy and Water Content of {_foodName}");

                chart3.Series.Add("Energy (Kcal)");
                chart3.Series["Energy (Kcal)"].ChartType = SeriesChartType.Line;
                chart3.Series["Energy (Kcal)"].BorderWidth = 3;
                chart3.Series["Energy (Kcal)"].MarkerStyle = MarkerStyle.Circle;
                chart3.Series["Energy (Kcal)"].MarkerSize = 8;
                chart3.Series["Energy (Kcal)"].IsValueShownAsLabel = true;
                chart3.Series["Energy (Kcal)"].Color = Color.OrangeRed;

                chart3.Series.Add("Water (g)"); // Another series for comparison
                chart3.Series["Water (g)"].ChartType = SeriesChartType.Line;
                chart3.Series["Water (g)"].BorderWidth = 3;
                chart3.Series["Water (g)"].MarkerStyle = MarkerStyle.Square;
                chart3.Series["Water (g)"].MarkerSize = 8;
                chart3.Series["Water (g)"].IsValueShownAsLabel = true;
                chart3.Series["Water (g)"].Color = Color.DodgerBlue;


                chart3.ChartAreas[0].AxisX.Title = "Nutrient Type";
                chart3.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                chart3.ChartAreas[0].AxisY.Title = "Amount";
                chart3.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                chart3.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                chart3.Legends[0].Enabled = true; // Enable legend for multiple series

                if (reader.Read())
                {
                    decimal energy = reader.GetDecimal(reader.GetOrdinal("EnergyKcal"));
                    decimal water = reader.IsDBNull(reader.GetOrdinal("WaterGrams")) ? 0 : reader.GetDecimal(reader.GetOrdinal("WaterGrams"));

                    chart3.Series["Energy (Kcal)"].Points.AddXY("Energy", energy);
                    chart3.Series["Water (g)"].Points.AddXY("Water", water); // Add to the second series
                }
            }
        }

        private void charFour()
        {
            // Point chart for Fat vs. Protein
            string query = "SELECT FatTotalGrams, ProteinGrams FROM food WHERE FoodName = @FoodName";

            using (SqlDataReader reader = DatabaseConnection.Instance.ExecuteReader(query, new SqlParameter("@FoodName", _foodName)))
            {
                chart4.Series.Clear();
                chart4.Series.Add("Fat vs Protein");
                chart4.Series["Fat vs Protein"].ChartType = SeriesChartType.Point;
                chart4.Series["Fat vs Protein"].MarkerStyle = MarkerStyle.Circle;
                chart4.Series["Fat vs Protein"].MarkerSize = 10;
                chart4.Series["Fat vs Protein"].IsValueShownAsLabel = true;
                chart4.Titles.Clear();
                chart4.Titles.Add($"Fat vs Protein in {_foodName}");


                chart4.ChartAreas[0].AxisX.Title = "Fat (g)";
                chart4.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                chart4.ChartAreas[0].AxisY.Title = "Protein (g)";
                chart4.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                chart4.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                chart4.Legends[0].Enabled = false;

                if (reader.Read())
                {
                    decimal fat = reader.GetDecimal(reader.GetOrdinal("FatTotalGrams"));
                    decimal protein = reader.GetDecimal(reader.GetOrdinal("ProteinGrams"));
                    chart4.Series["Fat vs Protein"].Points.AddXY(fat, protein);
                }
            }
        }

        private void charSix()
        {
            // Area chart for Fiber and selected Minerals
            string query = "SELECT FiberGrams, CalciumMg, IronMg FROM food WHERE FoodName = @FoodName";

            using (SqlDataReader reader = DatabaseConnection.Instance.ExecuteReader(query, new SqlParameter("@FoodName", _foodName)))
            {
                chart6.Series.Clear();
                chart6.Titles.Clear();
                chart6.Titles.Add($"Fiber and Key Minerals in {_foodName}");

                chart6.Series.Add("Fiber (g)");
                chart6.Series["Fiber (g)"].ChartType = SeriesChartType.Area;
                chart6.Series["Fiber (g)"].BorderWidth = 2;
                chart6.Series["Fiber (g)"].Color = System.Drawing.Color.FromArgb(120, 0, 192, 192);
                chart6.Series["Fiber (g)"].BorderColor = System.Drawing.Color.Teal;
                chart6.Series["Fiber (g)"].MarkerStyle = MarkerStyle.Circle;
                chart6.Series["Fiber (g)"].MarkerSize = 7;
                chart6.Series["Fiber (g)"].IsValueShownAsLabel = true;

                chart6.Series.Add("Calcium (mg)");
                chart6.Series["Calcium (mg)"].ChartType = SeriesChartType.Area;
                chart6.Series["Calcium (mg)"].BorderWidth = 2;
                chart6.Series["Calcium (mg)"].Color = System.Drawing.Color.FromArgb(120, 255, 165, 0); // Orange
                chart6.Series["Calcium (mg)"].BorderColor = System.Drawing.Color.DarkOrange;
                chart6.Series["Calcium (mg)"].MarkerStyle = MarkerStyle.Square;
                chart6.Series["Calcium (mg)"].MarkerSize = 7;
                chart6.Series["Calcium (mg)"].IsValueShownAsLabel = true;

                chart6.Series.Add("Iron (mg)");
                chart6.Series["Iron (mg)"].ChartType = SeriesChartType.Area;
                chart6.Series["Iron (mg)"].BorderWidth = 2;
                chart6.Series["Iron (mg)"].Color = System.Drawing.Color.FromArgb(120, 128, 0, 0); // Maroon
                chart6.Series["Iron (mg)"].BorderColor = System.Drawing.Color.DarkRed;
                chart6.Series["Iron (mg)"].MarkerStyle = MarkerStyle.Triangle;
                chart6.Series["Iron (mg)"].MarkerSize = 7;
                chart6.Series["Iron (mg)"].IsValueShownAsLabel = true;


                chart6.ChartAreas[0].AxisX.Title = "Nutrient Type";
                chart6.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                chart6.ChartAreas[0].AxisY.Title = "Amount";
                chart6.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                chart6.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                chart6.Legends[0].Enabled = true; // Enable legend for multiple series

                if (reader.Read())
                {
                    decimal fiber = reader.IsDBNull(reader.GetOrdinal("FiberGrams")) ? 0 : reader.GetDecimal(reader.GetOrdinal("FiberGrams"));
                    decimal calcium = reader.IsDBNull(reader.GetOrdinal("CalciumMg")) ? 0 : reader.GetDecimal(reader.GetOrdinal("CalciumMg"));
                    decimal iron = reader.IsDBNull(reader.GetOrdinal("IronMg")) ? 0 : reader.GetDecimal(reader.GetOrdinal("IronMg"));

                    chart6.Series["Fiber (g)"].Points.AddXY("Fiber", fiber);
                    chart6.Series["Calcium (mg)"].Points.AddXY("Calcium", calcium);
                    chart6.Series["Iron (mg)"].Points.AddXY("Iron", iron);
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