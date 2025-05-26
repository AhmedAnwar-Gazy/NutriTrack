using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriTrack
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            InitializeCustomComponents();
            this.WindowState = FormWindowState.Maximized; // يفتح النافذة بحجم متكامل
        }
        private void LoadPage(UserControl page)
        {
            contentPanel.Controls.Clear(); // contentPanel هو Panel في الفورم
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(page);
        }
        private void buttonAboutHome_Click(object sender, EventArgs e)
        {
            /*            AboutForm aboutForm = new AboutForm();
                        aboutForm.Show();
                        this.Hide();*/
            LoadPage(new AboutForm());

        }

        private void buttonManageMyFoodsHome_Click(object sender, EventArgs e)
        {
            /*            FoodManagementForm foodManagementForm = new FoodManagementForm();
                        foodManagementForm.Show();
                        this.Hide();*/
            LoadPage(new FoodManagementForm());

        }

        private void buttonLogoutHome_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void buttonprofileHome_Click(object sender, EventArgs e)
        {
            /*            ProfileForm profileForm = new ProfileForm();
                        profileForm.Show();
                        this.Hide();*/
            LoadPage(new ProfileForm());

        }

        private void ButtonSearchViewNuData_Click(object sender, EventArgs e)
        {
            NutrientVisualizationForm nutrientVisualizationForm = new NutrientVisualizationForm(SearchTextBox.Text);
            nutrientVisualizationForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*          Ai ai = new Ai();
                      ai.Show();*/

            LoadPage(new Ai());


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            LoadPage(new HomeContent());
  

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSearchHome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private List<string> _allProducts = new List<string>
    {
        "Laptop", "Mouse", "Keyboard", "Monitor", "Webcam",
        "Gaming PC", "Headphones", "Microphone", "Printer",
        "External Hard Drive", "USB Drive", "Smartwatch",
        "Smartphone", "Tablet", "Router", "Speaker",
        "Desk Chair", "Dining Table", "Sofa", "Bookshelf",
        "Coffee Machine", "Toaster", "Blender", "Microwave",
        "Refrigerator", "Washing Machine", "Dishwasher"
    };

        private CancellationTokenSource _debounceCts;


        private void InitializeCustomComponents()
        {
            // Set up the ListBox properties
            SuggestionsListBox.Visible = false; // Initially hidden
            SuggestionsListBox.Top = SearchTextBox.Bottom; // Position right below the textbox
            SuggestionsListBox.Left = SearchTextBox.Left;
            // Set its width to match the textbox, or adjust as needed
            SuggestionsListBox.Width = SearchTextBox.Width;
            SuggestionsListBox.Height = 150; // Set a default height
            SuggestionsListBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top; // Anchor to expand with form

            // Add the ListBox to the form's controls
            // This ensures it's part of the form's layout and events
            this.Controls.Add(SuggestionsListBox);
            SuggestionsListBox.BringToFront(); // Make sure it's on top of other controls

            // Attach event handlers
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            SearchTextBox.KeyDown += SearchTextBox_KeyDown;
            SuggestionsListBox.Click += SuggestionsListBox_Click;

            // Handle focus changes to hide/show popup
            SearchTextBox.LostFocus += SearchTextBox_LostFocus;
            SuggestionsListBox.LostFocus += SuggestionsListBox_LostFocus;
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

            // Cancel the previous debounce operation if typing quickly
            _debounceCts?.Cancel();
            _debounceCts = new CancellationTokenSource();
            CancellationToken cancellationToken = _debounceCts.Token;

            string query = SearchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                HideSuggestions();
                return;
            }

            try
            {
                // Implement debouncing: wait for a short delay before performing the search
                await Task.Delay(300, cancellationToken); // 300ms delay

                // If cancellation was requested during the delay, exit
                if (cancellationToken.IsCancellationRequested) return;

                // Perform the actual search/filtering (simulated async operation)
                // Using Task.Run to simulate background work and keep UI responsive
                List<string> filteredSuggestions = await Task.Run(() =>
                {
                    // Simulate a small delay for "API call" or heavy filtering
                    Thread.Sleep(50);
                    return _allProducts
                        .Where(p => p.ToLower().Contains(query.ToLower()))
                        .Take(7) // Limit the number of suggestions
                        .ToList();
                }, cancellationToken);

                // If cancellation was requested during the actual search, exit
                if (cancellationToken.IsCancellationRequested) return;

                // Update the UI with suggestions
                UpdateSuggestions(filteredSuggestions);
            }
            catch (TaskCanceledException)
            {
                // This exception is expected when a task is cancelled, just ignore it.
            }
            catch (Exception ex)
            {
                // Handle other potential errors (e.g., network issues)
                MessageBox.Show($"Error fetching suggestions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HideSuggestions();
            }
        }



        private void UpdateSuggestions(List<string> newSuggestions)
        {
            // Clear existing items and add new ones
            SuggestionsListBox.Items.Clear();
            foreach (string suggestion in newSuggestions)
            {
                SuggestionsListBox.Items.Add(suggestion);
            }

            // Show or hide the ListBox based on whether there are suggestions
            if (SuggestionsListBox.Items.Count > 0)
            {
                SuggestionsListBox.Visible = true;
                // Adjust height dynamically based on number of suggestions, up to MaxHeight
                int itemHeight = SuggestionsListBox.GetItemRectangle(0).Height;
                int desiredHeight = Math.Min(SuggestionsListBox.Items.Count * itemHeight + 4, 200); // +4 for border/padding
                SuggestionsListBox.Height = desiredHeight;
            }
            else
            {
                HideSuggestions();
            }
        }

        private void HideSuggestions()
        {
            SuggestionsListBox.Visible = false;
            SuggestionsListBox.Items.Clear(); // Clear items when hidden
        }

        private void SuggestionsListBox_Click(object sender, EventArgs e)
        {
            // When an item in the suggestions list is clicked
            if (SuggestionsListBox.SelectedItem != null)
            {
                SearchTextBox.Text = SuggestionsListBox.SelectedItem.ToString();
                SearchTextBox.Focus(); // Put focus back on the textbox
                SearchTextBox.SelectAll(); // Select text for easy overwriting if user types again
                HideSuggestions();
                MessageBox.Show($"You selected: {SearchTextBox.Text}", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optional: Trigger a final search or navigation here
            }
        }




        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (SuggestionsListBox.Visible && SuggestionsListBox.Items.Count > 0)
            {
                if (e.KeyCode == Keys.Down)
                {
                    e.SuppressKeyPress = true; // Prevent default key press (e.g., moving cursor in textbox)
                    if (SuggestionsListBox.SelectedIndex < SuggestionsListBox.Items.Count - 1)
                    {
                        SuggestionsListBox.SelectedIndex++;
                    }
                    else
                    {
                        SuggestionsListBox.SelectedIndex = 0; // Wrap around to the first item
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    e.SuppressKeyPress = true; // Prevent default key press
                    if (SuggestionsListBox.SelectedIndex > 0)
                    {
                        SuggestionsListBox.SelectedIndex--;
                    }
                    else
                    {
                        SuggestionsListBox.SelectedIndex = SuggestionsListBox.Items.Count - 1; // Wrap around to the last item
                    }
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true; // Prevent default key press
                    if (SuggestionsListBox.SelectedItem != null)
                    {
                        // Simulate click on the selected item in the ListBox
                        SuggestionsListBox_Click(SuggestionsListBox, EventArgs.Empty);
                    }
                    else if (!string.IsNullOrEmpty(SearchTextBox.Text))
                    {
                        // If Enter is pressed and no item is selected in the listbox, but textbox has text
                        MessageBox.Show($"Direct search for: {SearchTextBox.Text}", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HideSuggestions();
                    }
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    e.SuppressKeyPress = true; // Prevent default key press
                    HideSuggestions();
                }
            }
            else if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(SearchTextBox.Text))
            {
                // If Enter is pressed in the textbox when the popup is not open
                MessageBox.Show($"Direct search for: {SearchTextBox.Text}", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HideSuggestions();
            }
        }




        private async void SearchTextBox_LostFocus(object sender, EventArgs e)
        {
            // Use a small delay to allow focus to shift to the ListBox if a suggestion is clicked.
            await Task.Delay(100); // We can await directly since this method is async

            // All UI checks and updates must happen on the UI thread.
            // Check if the control has been disposed (important for async operations)
            if (this.IsDisposed) return;

            // Use Invoke to perform the check and hide operation on the UI thread
            this.Invoke(new Action(() =>
            {
                if (!SearchTextBox.Focused && !SuggestionsListBox.Focused)
                {
                    HideSuggestions();
                }
            }));
        }

        private async void SuggestionsListBox_LostFocus(object sender, EventArgs e)
        {
            // Similar delay logic
            await Task.Delay(100);

            // Check if the control has been disposed
            if (this.IsDisposed) return;

            this.Invoke(new Action(() =>
            {
                if (!SearchTextBox.Focused && !SuggestionsListBox.Focused)
                {
                    HideSuggestions();
                }
            }));
        }


        private void startbuttonHome_Click(object sender, EventArgs e)
        {
            ScanQR qr = new ScanQR();
            qr.Show();
        }
    }
}
