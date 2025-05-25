using System.Windows.Forms;
using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

using System.Windows.Forms;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace NutriTrack
{
    public partial class Ai : UserControl
    {
        
        private const string ApiKey = "AIzaSyChK663OfLl5EXSH7e274JGdcOYZOCPXfw"; // Replace with your actual API key

        private const string Endpoint =
            "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent";

  

        private async void btnAsk_Click(object sender, EventArgs e)
        {
            string userInput = txtPrompt.Text;
            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter a prompt.");
                return;
            }

            txtResponse.Text = "Thinking...";

            try
            {
                string response = await AskGeminiAsync(userInput);
                txtResponse.Text = response;
            }
            catch (Exception ex)
            {
                txtResponse.Text = $"Error: {ex.Message}";
            }
        }

        private async Task<string> AskGeminiAsync(string prompt)
        {
             HttpClient client = new HttpClient();

            var requestBody = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new {  text = "You are NutriTrack, a helpful nutrition intake recommender trained by the NutriTrack team. Always respond with clear, concise nutritional advice, daily intake recommendations, or health tips related to nutrition. Do not explain your behavior or role. Focus only on providing valuable nutrition-related information for any question.\nUser: " + prompt}
                        }
                    }
                }
            };

            string json = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            string requestUri = $"{Endpoint}?key={ApiKey}";

            var response = await client.PostAsync(requestUri, content);
            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();

          JsonDocument doc = JsonDocument.Parse(responseString);

            var candidates = doc.RootElement.GetProperty("candidates");
            if (candidates.GetArrayLength() > 0)
            {
                string text = candidates[0]
                    .GetProperty("content")
                    .GetProperty("parts")[0]
                    .GetProperty("text")
                    .GetString();

                return text ?? "No response content";
            }

            return "No candidates returned";
        }
        public Ai()
        {
            InitializeComponent();
        }

      

        private async void btnAsk_Click_1(object sender, EventArgs e)
        {
            
            string userInput = txtPrompt.Text;
            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter a prompt.");
                return;
            }

            txtResponse.Text = "Thinking...";

            try
            {
                string response = await AskGeminiAsync(userInput);
                txtResponse.Text = response;
                txtResponse.Font = new Font(txtResponse.Font.FontFamily, 20);
                txtResponse.Text = response;
            }
            catch (Exception ex)
            {
                
                txtResponse.Text = $"Error: {ex.Message}";
            }
        }

        private void Ai_Load(object sender, EventArgs e)
        {

        }

        private void txtPrompt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}