namespace NutriTrack
{
    partial class Home
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.SuggestionsListBox = new System.Windows.Forms.ListBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonSearchViewNuData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonprofileHome = new System.Windows.Forms.Button();
            this.buttonManageMyFoodsHome = new System.Windows.Forms.Button();
            this.buttonLogoutHome = new System.Windows.Forms.Button();
            this.buttonAboutHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.contentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Controls.Add(this.SuggestionsListBox);
            this.contentPanel.Controls.Add(this.SearchTextBox);
            this.contentPanel.Controls.Add(this.label4);
            this.contentPanel.Controls.Add(this.label3);
            this.contentPanel.Controls.Add(this.ButtonSearchViewNuData);
            this.contentPanel.Controls.Add(this.label2);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1518, 609);
            this.contentPanel.TabIndex = 12;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // SuggestionsListBox
            // 
            this.SuggestionsListBox.FormattingEnabled = true;
            this.SuggestionsListBox.Location = new System.Drawing.Point(383, 490);
            this.SuggestionsListBox.Name = "SuggestionsListBox";
            this.SuggestionsListBox.Size = new System.Drawing.Size(414, 95);
            this.SuggestionsListBox.TabIndex = 8;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(383, 440);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(637, 36);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.textBoxSearchHome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 35F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(374, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 57);
            this.label4.TabIndex = 7;
            this.label4.Text = "NitriTrak";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 30F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(375, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcome ";
            // 
            // ButtonSearchViewNuData
            // 
            this.ButtonSearchViewNuData.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonSearchViewNuData.FlatAppearance.BorderSize = 0;
            this.ButtonSearchViewNuData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchViewNuData.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ButtonSearchViewNuData.ForeColor = System.Drawing.Color.White;
            this.ButtonSearchViewNuData.Location = new System.Drawing.Point(1083, 440);
            this.ButtonSearchViewNuData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSearchViewNuData.Name = "ButtonSearchViewNuData";
            this.ButtonSearchViewNuData.Size = new System.Drawing.Size(166, 36);
            this.ButtonSearchViewNuData.TabIndex = 2;
            this.ButtonSearchViewNuData.Text = "View Nutrition Data";
            this.ButtonSearchViewNuData.UseVisualStyleBackColor = false;
            this.ButtonSearchViewNuData.Click += new System.EventHandler(this.ButtonSearchViewNuData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(378, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(839, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "A calorie is not just a calorie - it\'s a building block for your future self.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 90);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "NitriTrak";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ask NutriTrack Ai";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonprofileHome
            // 
            this.buttonprofileHome.BackColor = System.Drawing.Color.Teal;
            this.buttonprofileHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonprofileHome.FlatAppearance.BorderSize = 0;
            this.buttonprofileHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonprofileHome.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonprofileHome.ForeColor = System.Drawing.Color.White;
            this.buttonprofileHome.Location = new System.Drawing.Point(0, 0);
            this.buttonprofileHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonprofileHome.Name = "buttonprofileHome";
            this.buttonprofileHome.Size = new System.Drawing.Size(268, 49);
            this.buttonprofileHome.TabIndex = 10;
            this.buttonprofileHome.Text = "Profile";
            this.buttonprofileHome.UseVisualStyleBackColor = false;
            this.buttonprofileHome.Click += new System.EventHandler(this.buttonprofileHome_Click);
            // 
            // buttonManageMyFoodsHome
            // 
            this.buttonManageMyFoodsHome.BackColor = System.Drawing.Color.Teal;
            this.buttonManageMyFoodsHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManageMyFoodsHome.FlatAppearance.BorderSize = 0;
            this.buttonManageMyFoodsHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageMyFoodsHome.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonManageMyFoodsHome.ForeColor = System.Drawing.Color.White;
            this.buttonManageMyFoodsHome.Location = new System.Drawing.Point(0, 0);
            this.buttonManageMyFoodsHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonManageMyFoodsHome.Name = "buttonManageMyFoodsHome";
            this.buttonManageMyFoodsHome.Size = new System.Drawing.Size(268, 49);
            this.buttonManageMyFoodsHome.TabIndex = 9;
            this.buttonManageMyFoodsHome.Text = "Manage My Foods";
            this.buttonManageMyFoodsHome.UseVisualStyleBackColor = false;
            this.buttonManageMyFoodsHome.Click += new System.EventHandler(this.buttonManageMyFoodsHome_Click);
            // 
            // buttonLogoutHome
            // 
            this.buttonLogoutHome.BackColor = System.Drawing.Color.Red;
            this.buttonLogoutHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogoutHome.FlatAppearance.BorderSize = 0;
            this.buttonLogoutHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogoutHome.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonLogoutHome.ForeColor = System.Drawing.Color.White;
            this.buttonLogoutHome.Location = new System.Drawing.Point(0, 0);
            this.buttonLogoutHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogoutHome.Name = "buttonLogoutHome";
            this.buttonLogoutHome.Size = new System.Drawing.Size(268, 49);
            this.buttonLogoutHome.TabIndex = 9;
            this.buttonLogoutHome.Text = "Logout";
            this.buttonLogoutHome.UseVisualStyleBackColor = false;
            this.buttonLogoutHome.Click += new System.EventHandler(this.buttonLogoutHome_Click);
            // 
            // buttonAboutHome
            // 
            this.buttonAboutHome.BackColor = System.Drawing.Color.Teal;
            this.buttonAboutHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAboutHome.FlatAppearance.BorderSize = 0;
            this.buttonAboutHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutHome.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonAboutHome.ForeColor = System.Drawing.Color.White;
            this.buttonAboutHome.Location = new System.Drawing.Point(0, 0);
            this.buttonAboutHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAboutHome.Name = "buttonAboutHome";
            this.buttonAboutHome.Size = new System.Drawing.Size(268, 49);
            this.buttonAboutHome.TabIndex = 2;
            this.buttonAboutHome.Text = "About";
            this.buttonAboutHome.UseVisualStyleBackColor = false;
            this.buttonAboutHome.Click += new System.EventHandler(this.buttonAboutHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 609);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.buttonLogoutHome);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 337);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(268, 49);
            this.panel9.TabIndex = 12;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.buttonManageMyFoodsHome);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 288);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(268, 49);
            this.panel8.TabIndex = 11;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 239);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(268, 49);
            this.panel7.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonAboutHome);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 190);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(268, 49);
            this.panel6.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonprofileHome);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 141);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(268, 49);
            this.panel5.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 141);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1518, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.contentPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button ButtonSearchViewNuData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonManageMyFoodsHome;
        private System.Windows.Forms.Button buttonLogoutHome;
        private System.Windows.Forms.Button buttonAboutHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonprofileHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox SuggestionsListBox;
    }
}