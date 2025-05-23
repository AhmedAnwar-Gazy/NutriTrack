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
            this.txtResponse.Location = new System.Drawing.Point(13, 141);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(685, 310);
            this.txtResponse.TabIndex = 0;
            // 
            // txtPrompt
            // 
            this.txtPrompt.Location = new System.Drawing.Point(37, 24);
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(303, 20);
            this.txtPrompt.TabIndex = 1;
            // 
            // btnAsk
            // 
            this.btnAsk.Location = new System.Drawing.Point(37, 60);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(102, 23);
            this.btnAsk.TabIndex = 2;
            this.btnAsk.Text = "ASK";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click_1);
            // 
            // Ai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.txtPrompt);
            this.Controls.Add(this.txtResponse);
            this.Name = "Ai";
            this.Text = "Ai";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Button btnAsk;

        private System.Windows.Forms.TextBox txtResponse;

        #endregion
    }
}