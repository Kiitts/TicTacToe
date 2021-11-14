
namespace TicTacToe
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.justLine1 = new System.Windows.Forms.Label();
            this.justLine2 = new System.Windows.Forms.Label();
            this.justLine4 = new System.Windows.Forms.Label();
            this.justLine3 = new System.Windows.Forms.Label();
            this.goBack = new System.Windows.Forms.Button();
            this.r1c1 = new System.Windows.Forms.PictureBox();
            this.r2c2 = new System.Windows.Forms.PictureBox();
            this.r1c2 = new System.Windows.Forms.PictureBox();
            this.r1c3 = new System.Windows.Forms.PictureBox();
            this.r2c1 = new System.Windows.Forms.PictureBox();
            this.r2c3 = new System.Windows.Forms.PictureBox();
            this.r3c2 = new System.Windows.Forms.PictureBox();
            this.r3c1 = new System.Windows.Forms.PictureBox();
            this.r3c3 = new System.Windows.Forms.PictureBox();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.whoNext = new System.Windows.Forms.PictureBox();
            this.labelTurn = new System.Windows.Forms.Label();
            this.player1Score = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.Label();
            this.resetScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.r1c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r3c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r3c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r3c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whoNext)).BeginInit();
            this.SuspendLayout();
            // 
            // justLine1
            // 
            this.justLine1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.justLine1.Enabled = false;
            this.justLine1.Location = new System.Drawing.Point(177, 105);
            this.justLine1.Name = "justLine1";
            this.justLine1.Size = new System.Drawing.Size(21, 293);
            this.justLine1.TabIndex = 0;
            this.justLine1.Text = "label1";
            // 
            // justLine2
            // 
            this.justLine2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.justLine2.Enabled = false;
            this.justLine2.Location = new System.Drawing.Point(292, 105);
            this.justLine2.Name = "justLine2";
            this.justLine2.Size = new System.Drawing.Size(21, 293);
            this.justLine2.TabIndex = 1;
            this.justLine2.Text = "label1";
            // 
            // justLine4
            // 
            this.justLine4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.justLine4.Enabled = false;
            this.justLine4.Location = new System.Drawing.Point(94, 185);
            this.justLine4.Name = "justLine4";
            this.justLine4.Size = new System.Drawing.Size(308, 21);
            this.justLine4.TabIndex = 2;
            this.justLine4.Text = "label2";
            // 
            // justLine3
            // 
            this.justLine3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.justLine3.Enabled = false;
            this.justLine3.Location = new System.Drawing.Point(94, 293);
            this.justLine3.Name = "justLine3";
            this.justLine3.Size = new System.Drawing.Size(308, 21);
            this.justLine3.TabIndex = 3;
            this.justLine3.Text = "label3";
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(12, 12);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 23);
            this.goBack.TabIndex = 4;
            this.goBack.Text = "Back";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // r1c1
            // 
            this.r1c1.BackColor = System.Drawing.Color.LightSalmon;
            this.r1c1.Location = new System.Drawing.Point(96, 107);
            this.r1c1.Name = "r1c1";
            this.r1c1.Size = new System.Drawing.Size(75, 75);
            this.r1c1.TabIndex = 5;
            this.r1c1.TabStop = false;
            this.r1c1.Click += new System.EventHandler(this.r1c1_Click);
            // 
            // r2c2
            // 
            this.r2c2.BackColor = System.Drawing.Color.LightSalmon;
            this.r2c2.Location = new System.Drawing.Point(208, 211);
            this.r2c2.Name = "r2c2";
            this.r2c2.Size = new System.Drawing.Size(75, 75);
            this.r2c2.TabIndex = 6;
            this.r2c2.TabStop = false;
            this.r2c2.Click += new System.EventHandler(this.r2c2_Click);
            // 
            // r1c2
            // 
            this.r1c2.BackColor = System.Drawing.Color.LightSalmon;
            this.r1c2.Location = new System.Drawing.Point(207, 107);
            this.r1c2.Name = "r1c2";
            this.r1c2.Size = new System.Drawing.Size(75, 75);
            this.r1c2.TabIndex = 7;
            this.r1c2.TabStop = false;
            this.r1c2.Click += new System.EventHandler(this.r1c2_Click);
            // 
            // r1c3
            // 
            this.r1c3.BackColor = System.Drawing.Color.LightSalmon;
            this.r1c3.Location = new System.Drawing.Point(319, 107);
            this.r1c3.Name = "r1c3";
            this.r1c3.Size = new System.Drawing.Size(75, 75);
            this.r1c3.TabIndex = 8;
            this.r1c3.TabStop = false;
            this.r1c3.Click += new System.EventHandler(this.r1c3_Click);
            // 
            // r2c1
            // 
            this.r2c1.BackColor = System.Drawing.Color.LightSalmon;
            this.r2c1.Location = new System.Drawing.Point(96, 212);
            this.r2c1.Name = "r2c1";
            this.r2c1.Size = new System.Drawing.Size(75, 75);
            this.r2c1.TabIndex = 9;
            this.r2c1.TabStop = false;
            this.r2c1.Click += new System.EventHandler(this.r2c1_Click);
            // 
            // r2c3
            // 
            this.r2c3.BackColor = System.Drawing.Color.LightSalmon;
            this.r2c3.Location = new System.Drawing.Point(319, 212);
            this.r2c3.Name = "r2c3";
            this.r2c3.Size = new System.Drawing.Size(75, 75);
            this.r2c3.TabIndex = 10;
            this.r2c3.TabStop = false;
            this.r2c3.Click += new System.EventHandler(this.r2c3_Click);
            // 
            // r3c2
            // 
            this.r3c2.BackColor = System.Drawing.Color.LightSalmon;
            this.r3c2.Location = new System.Drawing.Point(207, 317);
            this.r3c2.Name = "r3c2";
            this.r3c2.Size = new System.Drawing.Size(75, 75);
            this.r3c2.TabIndex = 11;
            this.r3c2.TabStop = false;
            this.r3c2.Click += new System.EventHandler(this.r3c2_Click);
            // 
            // r3c1
            // 
            this.r3c1.BackColor = System.Drawing.Color.LightSalmon;
            this.r3c1.Location = new System.Drawing.Point(96, 317);
            this.r3c1.Name = "r3c1";
            this.r3c1.Size = new System.Drawing.Size(75, 75);
            this.r3c1.TabIndex = 12;
            this.r3c1.TabStop = false;
            this.r3c1.Click += new System.EventHandler(this.r3c1_Click);
            // 
            // r3c3
            // 
            this.r3c3.BackColor = System.Drawing.Color.LightSalmon;
            this.r3c3.Location = new System.Drawing.Point(319, 317);
            this.r3c3.Name = "r3c3";
            this.r3c3.Size = new System.Drawing.Size(75, 75);
            this.r3c3.TabIndex = 13;
            this.r3c3.TabStop = false;
            this.r3c3.Click += new System.EventHandler(this.r3c3_Click);
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.player1Label.Location = new System.Drawing.Point(12, 407);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(97, 30);
            this.player1Label.TabIndex = 14;
            this.player1Label.Text = "Player 1";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.player2Label.Location = new System.Drawing.Point(402, 407);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(97, 30);
            this.player2Label.TabIndex = 15;
            this.player2Label.Text = "Player 2";
            // 
            // whoNext
            // 
            this.whoNext.BackColor = System.Drawing.Color.Orange;
            this.whoNext.Image = global::TicTacToe.Properties.Resources.cross;
            this.whoNext.Location = new System.Drawing.Point(177, 12);
            this.whoNext.Name = "whoNext";
            this.whoNext.Size = new System.Drawing.Size(75, 75);
            this.whoNext.TabIndex = 16;
            this.whoNext.TabStop = false;
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Font = new System.Drawing.Font("Hobo Std", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTurn.Location = new System.Drawing.Point(273, 36);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(79, 38);
            this.labelTurn.TabIndex = 17;
            this.labelTurn.Text = "Turn";
            // 
            // player1Score
            // 
            this.player1Score.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.player1Score.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.player1Score.Location = new System.Drawing.Point(12, 450);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(97, 30);
            this.player1Score.TabIndex = 18;
            this.player1Score.Text = "0";
            this.player1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Score
            // 
            this.player2Score.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.player2Score.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.player2Score.Location = new System.Drawing.Point(402, 450);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(97, 30);
            this.player2Score.TabIndex = 19;
            this.player2Score.Text = "0";
            this.player2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetScore
            // 
            this.resetScore.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.resetScore.ForeColor = System.Drawing.Color.DarkRed;
            this.resetScore.Location = new System.Drawing.Point(177, 424);
            this.resetScore.Name = "resetScore";
            this.resetScore.Size = new System.Drawing.Size(136, 44);
            this.resetScore.TabIndex = 20;
            this.resetScore.Text = "Reset Score";
            this.resetScore.UseVisualStyleBackColor = true;
            this.resetScore.Click += new System.EventHandler(this.resetScore_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(511, 489);
            this.Controls.Add(this.resetScore);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.whoNext);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.r3c3);
            this.Controls.Add(this.r3c1);
            this.Controls.Add(this.r3c2);
            this.Controls.Add(this.r2c3);
            this.Controls.Add(this.r2c1);
            this.Controls.Add(this.r1c3);
            this.Controls.Add(this.r1c2);
            this.Controls.Add(this.r2c2);
            this.Controls.Add(this.r1c1);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.justLine3);
            this.Controls.Add(this.justLine4);
            this.Controls.Add(this.justLine2);
            this.Controls.Add(this.justLine1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(511, 489);
            this.MinimumSize = new System.Drawing.Size(511, 489);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.r1c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r3c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r3c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r3c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whoNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label justLine1;
        private System.Windows.Forms.Label justLine2;
        private System.Windows.Forms.Label justLine4;
        private System.Windows.Forms.Label justLine3;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.PictureBox r1c1;
        private System.Windows.Forms.PictureBox r2c2;
        private System.Windows.Forms.PictureBox r1c2;
        private System.Windows.Forms.PictureBox r1c3;
        private System.Windows.Forms.PictureBox r2c1;
        private System.Windows.Forms.PictureBox r2c3;
        private System.Windows.Forms.PictureBox r3c2;
        private System.Windows.Forms.PictureBox r3c1;
        private System.Windows.Forms.PictureBox r3c3;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.PictureBox whoNext;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.Button resetScore;
    }
}