using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace NutriTrack
{ 
    internal static class Program
    {

       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string macIP = NetworkInterface.GetAllNetworkInterfaces().First().GetPhysicalAddress().ToString();
            
            //macIP fond in db 
            // Application.Run(new Home());
            //macIP not found 
            // Application.Run(new LoginForm());
            
            
            bool macExists = false;
            string query = "SELECT COUNT(*) FROM [user] WHERE MacIP = @mac";

            using (SqlDataReader reader = DatabaseConnection.Instance.ExecuteReader(query, new SqlParameter("@mac", macIP)))
            {
                if (reader.Read())
                {
                    macExists = reader.GetInt32(0) > 0;
                }
            }

// Run appropriate form
            if (macExists)
            {
                Application.Run(new Home()); // MAC found
            }
            else
            {
                Application.Run(new LoginForm()); // MAC not found
            }
        }
    }
}
