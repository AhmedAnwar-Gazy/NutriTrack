using AutoGen.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriTrack
{
    
    public partial class ToastFormcs : Form
    {
        int toastX, toastY;
        public ToastFormcs(String type, String message)
        {
            InitializeComponent();
            lableType.Text = type;
            labelToastMeassage.Text = message;
            switch (type)
            {
                case "SUCCESS":
                    panelColorToastMeassage.BackColor = Color.FromArgb(57, 155, 53);
                    pictureBoxToastMeassage.Image = Properties.Resources.accept;
                    break;
                case "ERROR":
                    panelColorToastMeassage.BackColor = Color.FromArgb(227, 50, 45);
                    pictureBoxToastMeassage.Image = Properties.Resources.caution;
                    break;

                case "INFO":
                    panelColorToastMeassage.BackColor = Color.FromArgb(18, 136, 191);
                    pictureBoxToastMeassage.Image = Properties.Resources.information;
                    break;
                case "WARNING":
                    pictureBoxToastMeassage.Image = Properties.Resources.multiply;
                    panelColorToastMeassage.BackColor = Color.FromArgb(245, 171, 35);
                    break;
            }
        }

        private void ToastFormcs_Load(object sender, EventArgs e)
        {
            Position();

        }

        private void toastTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 10; 
            this.Location = new Point(toastX, toastY);
            if (toastY <= 760)
            {
                toastTimer.Stop();
                timerHide.Start();
            }
        }

        int y = 100;
        private void timerHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if (toastY > 800)
                {
                    timerHide.Stop();
                    y = 100;
                    this.Close();
                }

            }
        }

        private void Position() {

        int Screenwidth = Screen.PrimaryScreen.WorkingArea.Width;
        int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
        toastX = Screenwidth - this.Width-5;
        toastY = ScreenHeight - this. Height+70;
            this.Location = new Point(toastX, toastY);
        }
}
}
