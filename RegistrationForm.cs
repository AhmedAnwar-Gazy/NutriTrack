using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Json.More;
using MyNamespace;

namespace NutriTrack
{
    public partial class RegistrationForm : Form
    {
        private string imagePath;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private async void  Login_Click(object sender, EventArgs e)
        {
            // Home home = new Home();
            // home.Show();
            // this.Hide();
            string username = textBoxUserNameSignUp.Text;
            string email = textBoxEmailSignUP.Text;
            string password = textBoxPasswordSignUP.Text;
            DateTime birthDate = dateTimeDateofBirthProfile.Value;
            // string height = TextboxHeightProfile.Text;
            if (!decimal.TryParse(TextboxWeightProfile.Text, out decimal weight))
            {
                MessageBox.Show("Please enter a valid weight (e.g., 65.5).");
                return;
            }
            if (!decimal.TryParse(TextboxWeightProfile.Text, out decimal height))
            {
                MessageBox.Show("Please enter a valid weight (e.g., 65.5).");
                return;
            }
            string gender = textgender.Text;
            string note = richTextBox.Text;
            
            UserService user = new UserService();
          bool UserRegister= await user.RegisterUserAsync(username, email, password, MacAddresses.FirstMac, imagePath,birthDate,gender,weight,height,note);
          if (UserRegister)
          {
              ToastFormcs toast = new ToastFormcs("SUCCESS","You are register successfully,please go to login");
              toast.Show();
              this.Hide();
              LoginForm login = new LoginForm();
              login.Show();
              
          }
          
            
            
        }

        private void BacktoLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void textBoxUserNameSignUp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxEmailSignUP_TextChanged(object sender, EventArgs e)
        {

        }

        // Event handler for the "Browse Image" button click
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            openFileDialog1.Title = "Select an Image File";
            openFileDialog1.FileName = ""; // Clear any previously selected file name

            // Show the dialog and check if the user clicked OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Get the selected file path
                     imagePath = openFileDialog1.FileName;

                    // Load the image from the selected path
                    // Use Image.FromFile to create an Image object from the file
                    // Important: Creating a copy of the image data in memory
                    // to prevent locking the file, which can happen with Image.FromFile directly.
                    Image originalImage = Image.FromFile(imagePath);
                    Image imageCopy = new Bitmap(originalImage); // Create a copy
                    originalImage.Dispose(); // Dispose of the original to release file lock

                    // Display the image in the PictureBox
                    pictureBoxDisplay.Image = imageCopy;

                    // Optional: Display the file path in a status bar or label
                    // lblImagePath.Text = "Image loaded: " + Path.GetFileName(imagePath);
                    // (You would need to add a Label control named lblImagePath to your form)
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during file loading
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
