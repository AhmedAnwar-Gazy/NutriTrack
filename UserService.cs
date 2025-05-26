
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{


    public class UserService
    {
        public async Task<bool> RegisterUserAsync(string username, string plainPassword, string email, string macIP,
            string photoPath,
            DateTime birthDate, string gender, decimal weight, decimal height, string notes)
        {
            // 1. Hash the password
            string passwordHash = HashPassword(plainPassword);

            // 2. SQL Insert query
            string query = @"
            INSERT INTO [user] 
            (Username, PasswordHash, Email, MacIP, PhotoPath, BarthDate, Gender, Weight, Height, Notes)
            VALUES 
            (@Username, @PasswordHash, @Email, @MacIP, @PhotoPath, @BarthDate, @Gender, @Weight, @Height, @Notes);
        ";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query,
                           new SqlConnection(
                               "Server=.\\SQLEXPRESS;Database=NitriTrak;Integrated Security=True;TrustServerCertificate=True")))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@MacIP", macIP);
                    cmd.Parameters.AddWithValue("@PhotoPath", photoPath);
                    cmd.Parameters.AddWithValue("@BarthDate", birthDate);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@Height", height);
                    cmd.Parameters.AddWithValue("@Notes", notes ?? "");

                    await cmd.Connection.OpenAsync();
                    int result = await cmd.ExecuteNonQueryAsync();
                    return result > 0;
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Registration failed: " + ex.Message);
                return false;
            }
        }

        private string HashPassword(string plainPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(plainPassword);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}