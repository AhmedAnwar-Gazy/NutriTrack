namespace NutriTrack
{
    partial class ToastFormcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelColorToastMeassage = new System.Windows.Forms.Panel();
            this.lableType = new System.Windows.Forms.Label();
            this.labelToastMeassage = new System.Windows.Forms.Label();
            this.toastTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxToastMeassage = new System.Windows.Forms.PictureBox();
            this.timerHide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToastMeassage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelColorToastMeassage
            // 
            this.panelColorToastMeassage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelColorToastMeassage.Location = new System.Drawing.Point(0, -1);
            this.panelColorToastMeassage.Name = "panelColorToastMeassage";
            this.panelColorToastMeassage.Size = new System.Drawing.Size(10, 62);
            this.panelColorToastMeassage.TabIndex = 0;
            // 
            // lableType
            // 
            this.lableType.AutoSize = true;
            this.lableType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lableType.Location = new System.Drawing.Point(63, 9);
            this.lableType.Name = "lableType";
            this.lableType.Size = new System.Drawing.Size(42, 17);
            this.lableType.TabIndex = 2;
            this.lableType.Text = "Type";
            // 
            // labelToastMeassage
            // 
            this.labelToastMeassage.AutoSize = true;
            this.labelToastMeassage.Location = new System.Drawing.Point(63, 28);
            this.labelToastMeassage.Name = "labelToastMeassage";
            this.labelToastMeassage.Size = new System.Drawing.Size(104, 17);
            this.labelToastMeassage.TabIndex = 3;
            this.labelToastMeassage.Text = "Toast Meassage";
            // 
            // toastTimer
            // 
            this.toastTimer.Enabled = true;
            this.toastTimer.Interval = 10;
            this.toastTimer.Tick += new System.EventHandler(this.toastTimer_Tick);
            // 
            // pictureBoxToastMeassage
            // 
            this.pictureBoxToastMeassage.Image = global::NutriTrack.Properties.Resources.accept;
            this.pictureBoxToastMeassage.Location = new System.Drawing.Point(24, 14);
            this.pictureBoxToastMeassage.Name = "pictureBoxToastMeassage";
            this.pictureBoxToastMeassage.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxToastMeassage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxToastMeassage.TabIndex = 1;
            this.pictureBoxToastMeassage.TabStop = false;
            // 
            // timerHide
            // 
            this.timerHide.Interval = 10;
            this.timerHide.Tick += new System.EventHandler(this.timerHide_Tick);
            // 
            // ToastFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 59);
            this.Controls.Add(this.labelToastMeassage);
            this.Controls.Add(this.lableType);
            this.Controls.Add(this.pictureBoxToastMeassage);
            this.Controls.Add(this.panelColorToastMeassage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastFormcs";
            this.Text = "ToastFormcs";
            this.Load += new System.EventHandler(this.ToastFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToastMeassage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelColorToastMeassage;
        private System.Windows.Forms.PictureBox pictureBoxToastMeassage;
        private System.Windows.Forms.Label lableType;
        private System.Windows.Forms.Label labelToastMeassage;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer timerHide;
    }
}