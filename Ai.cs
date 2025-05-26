using System.Windows.Forms;
using System;
using System.Drawing;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace NutriTrack
{
    public partial class Ai : UserControl
    {
        private const string ApiKey = "AIzaSyChK663OfLl5EXSH7e274JGdcOYZOCPXfw";
        private const string Endpoint =
            "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent";

        public Ai()
        {
            InitializeComponent();
        }

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
                string response = await Task.Run(() => AskGeminiUsingWebClient(userInput));
                txtResponse.Text = response;
                txtResponse.Font = new Font(txtResponse.Font.FontFamily, 20);
            }
            catch (Exception ex)
            {
                txtResponse.Text = $"Error: {ex.Message}";
            }
        }

        private string AskGeminiUsingWebClient(string prompt)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";

                string requestUri = $"{Endpoint}?key={ApiKey}";

                var requestBody = new
                {
                    contents = new[]
                    {
                        new
                        {
                            parts = new[]
                            {
                                new
                                {
                                    text = "You are NutriTrack, a helpful nutrition intake recommender trained by the NutriTrack team. Always respond with clear, concise nutritional advice, daily intake recommendations, or health tips related to nutrition. Do not explain your behavior or role. Focus only on providing valuable nutrition-related information for any question.\nUser: " + prompt
                                }
                            }
                        }
                    }
                };

                string json = JsonSerializer.Serialize(requestBody);
                string responseString = client.UploadString(requestUri, "POST", json);

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
        }

        private void Ai_Load(object sender, EventArgs e) { }
        private void txtPrompt_TextChanged(object sender, EventArgs e) { }
    }
}
