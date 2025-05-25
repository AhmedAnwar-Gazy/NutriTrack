namespace NutriTrack
{
    partial class HomeContent
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchHome = new System.Windows.Forms.TextBox();
            this.comboBoxHome = new System.Windows.Forms.ComboBox();
            this.ButtonSearchViewNuData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 35F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(383, 351);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 71);
            this.label4.TabIndex = 13;
            this.label4.Text = "NitriTrak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 30F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(385, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 60);
            this.label3.TabIndex = 12;
            this.label3.Text = "Welcome ";
            // 
            // textBoxSearchHome
            // 
            this.textBoxSearchHome.Location = new System.Drawing.Point(395, 580);
            this.textBoxSearchHome.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxSearchHome.Multiline = true;
            this.textBoxSearchHome.Name = "textBoxSearchHome";
            this.textBoxSearchHome.Size = new System.Drawing.Size(742, 44);
            this.textBoxSearchHome.TabIndex = 11;
            // 
            // comboBoxHome
            // 
            this.comboBoxHome.Font = new System.Drawing.Font("Tahoma", 18F);
            this.comboBoxHome.FormattingEnabled = true;
            this.comboBoxHome.Location = new System.Drawing.Point(1166, 580);
            this.comboBoxHome.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxHome.Name = "comboBoxHome";
            this.comboBoxHome.Size = new System.Drawing.Size(121, 44);
            this.comboBoxHome.TabIndex = 10;
            // 
            // ButtonSearchViewNuData
            // 
            this.ButtonSearchViewNuData.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonSearchViewNuData.FlatAppearance.BorderSize = 0;
            this.ButtonSearchViewNuData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchViewNuData.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ButtonSearchViewNuData.ForeColor = System.Drawing.Color.White;
            this.ButtonSearchViewNuData.Location = new System.Drawing.Point(1297, 580);
            this.ButtonSearchViewNuData.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ButtonSearchViewNuData.Name = "ButtonSearchViewNuData";
            this.ButtonSearchViewNuData.Size = new System.Drawing.Size(194, 44);
            this.ButtonSearchViewNuData.TabIndex = 9;
            this.ButtonSearchViewNuData.Text = "View Nutrition Data";
            this.ButtonSearchViewNuData.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(388, 473);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1070, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "A calorie is not just a calorie - it\'s a building block for your future self.";
            // 
            // HomeContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSearchHome);
            this.Controls.Add(this.comboBoxHome);
            this.Controls.Add(this.ButtonSearchViewNuData);
            this.Controls.Add(this.label2);
            this.Name = "HomeContent";
            this.Size = new System.Drawing.Size(1742, 884);
            this.Load += new System.EventHandler(this.HomeContent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearchHome;
        private System.Windows.Forms.ComboBox comboBoxHome;
        private System.Windows.Forms.Button ButtonSearchViewNuData;
        private System.Windows.Forms.Label label2;
    }
}