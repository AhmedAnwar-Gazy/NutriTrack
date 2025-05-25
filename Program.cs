using System;
using System.Collections.Generic;
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
            Application.Run(new Home());
            //macIP not found 
            // Application.Run(new LoginForm());
        }
    }
}
