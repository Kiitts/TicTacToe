
namespace TicTacToe
{
    partial class AiSettings
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
            this.aiGoFirst = new System.Windows.Forms.Button();
            this.aiGoSecond = new System.Windows.Forms.Button();
            this.aiSettingsInstruction = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aiGoFirst
            // 
            this.aiGoFirst.Location = new System.Drawing.Point(37, 121);
            this.aiGoFirst.Name = "aiGoFirst";
            this.aiGoFirst.Size = new System.Drawing.Size(75, 23);
            this.aiGoFirst.TabIndex = 0;
            this.aiGoFirst.Text = "First";
            this.aiGoFirst.UseVisualStyleBackColor = true;
            this.aiGoFirst.Click += new System.EventHandler(this.aiGoFirst_Click);
            // 
            // aiGoSecond
            // 
            this.aiGoSecond.Location = new System.Drawing.Point(185, 121);
            this.aiGoSecond.Name = "aiGoSecond";
            this.aiGoSecond.Size = new System.Drawing.Size(75, 23);
            this.aiGoSecond.TabIndex = 1;
            this.aiGoSecond.Text = "Second";
            this.aiGoSecond.UseVisualStyleBackColor = true;
            this.aiGoSecond.Click += new System.EventHandler(this.aiGoSecond_Click);
            // 
            // aiSettingsInstruction
            // 
            this.aiSettingsInstruction.AutoSize = true;
            this.aiSettingsInstruction.Location = new System.Drawing.Point(105, 40);
            this.aiSettingsInstruction.Name = "aiSettingsInstruction";
            this.aiSettingsInstruction.Size = new System.Drawing.Size(82, 15);
            this.aiSettingsInstruction.TabIndex = 3;
            this.aiSettingsInstruction.Text = "Would you go";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(112, 180);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.Text = "Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click_1);
            // 
            // AiSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 231);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.aiSettingsInstruction);
            this.Controls.Add(this.aiGoSecond);
            this.Controls.Add(this.aiGoFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(296, 231);
            this.MinimumSize = new System.Drawing.Size(296, 231);
            this.Name = "AiSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AiSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aiGoFirst;
        private System.Windows.Forms.Button aiGoSecond;
        private System.Windows.Forms.Label aiSettingsInstruction;
        private System.Windows.Forms.Button btnGoBack;
    }
}