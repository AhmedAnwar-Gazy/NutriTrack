using System.ComponentModel;

namespace NutriTrack
{
    partial class Ai
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
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.btnAsk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.BackColor = System.Drawing.Color.White;
            this.txtResponse.Location = new System.Drawing.Point(386, 104);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(4);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(798, 381);
            this.txtResponse.TabIndex = 0;
            // 
            // txtPrompt
            // 
            this.txtPrompt.Location = new System.Drawing.Point(386, 503);
            this.txtPrompt.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrompt.Multiline = true;
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(530, 40);
            this.txtPrompt.TabIndex = 1;
            this.txtPrompt.TextChanged += new System.EventHandler(this.txtPrompt_TextChanged);
            // 
            // btnAsk
            // 
            this.btnAsk.BackColor = System.Drawing.Color.Black;
            this.btnAsk.FlatAppearance.BorderSize = 0;
            this.btnAsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsk.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAsk.ForeColor = System.Drawing.Color.White;
            this.btnAsk.Location = new System.Drawing.Point(947, 503);
            this.btnAsk.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(237, 40);
            this.btnAsk.TabIndex = 2;
            this.btnAsk.Text = "ASK";
            this.btnAsk.UseVisualStyleBackColor = false;
              this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // Ai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.txtPrompt);
            this.Controls.Add(this.txtResponse);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ai";
            this.Size = new System.Drawing.Size(1522, 940);
            this.Load += new System.EventHandler(this.Ai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Button btnAsk;

        private System.Windows.Forms.TextBox txtResponse;

        #endregion
    }
}