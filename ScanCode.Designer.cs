using System.ComponentModel;

namespace NutriTrack
{
    partial class ScanCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ComaraDevices = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textQRcode = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ComaraDevices
            // 
            this.ComaraDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComaraDevices.FormattingEnabled = true;
            this.ComaraDevices.Location = new System.Drawing.Point(205, 27);
            this.ComaraDevices.Name = "ComaraDevices";
            this.ComaraDevices.Size = new System.Drawing.Size(222, 21);
            this.ComaraDevices.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(450, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 31);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.Load += new System.EventHandler(this.ScanCode_Load);

            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(74, 78);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(563, 243);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // textQRcode
            // 
            this.textQRcode.Location = new System.Drawing.Point(176, 327);
            this.textQRcode.Multiline = true;
            this.textQRcode.Name = "textQRcode";
            this.textQRcode.Size = new System.Drawing.Size(416, 92);
            this.textQRcode.TabIndex = 4;
            // 
            // ScanCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textQRcode);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.ComaraDevices);
            this.Name = "ScanCode";
            this.Text = "ScanCode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanCode_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Timer timer;

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textQRcode;

        private System.Windows.Forms.ComboBox ComaraDevices;
        private System.Windows.Forms.Button btnStart;

        #endregion
    }
}