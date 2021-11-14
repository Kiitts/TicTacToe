
namespace TicTacToe
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.mainMenuTitle = new System.Windows.Forms.Label();
            this.player1Btn = new System.Windows.Forms.Button();
            this.player2Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenuTitle
            // 
            this.mainMenuTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuTitle.Image = global::TicTacToe.Properties.Resources.mainMenuTitle;
            resources.ApplyResources(this.mainMenuTitle, "mainMenuTitle");
            this.mainMenuTitle.Name = "mainMenuTitle";
            // 
            // player1Btn
            // 
            this.player1Btn.BackColor = System.Drawing.Color.Transparent;
            this.player1Btn.BackgroundImage = global::TicTacToe.Properties.Resources.Player1_Button;
            resources.ApplyResources(this.player1Btn, "player1Btn");
            this.player1Btn.Name = "player1Btn";
            this.player1Btn.UseVisualStyleBackColor = false;
            this.player1Btn.Click += new System.EventHandler(this.player1Btn_Click);
            // 
            // player2Btn
            // 
            this.player2Btn.BackColor = System.Drawing.Color.Transparent;
            this.player2Btn.BackgroundImage = global::TicTacToe.Properties.Resources.Player2_Button;
            resources.ApplyResources(this.player2Btn, "player2Btn");
            this.player2Btn.Name = "player2Btn";
            this.player2Btn.UseVisualStyleBackColor = false;
            this.player2Btn.Click += new System.EventHandler(this.player2Btn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.backgroundMainMenu;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player2Btn);
            this.Controls.Add(this.player1Btn);
            this.Controls.Add(this.mainMenuTitle);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuTitle;
        private System.Windows.Forms.Button player1Btn;
        private System.Windows.Forms.Button player2Btn;
        private System.Windows.Forms.Label label1;
    }
}

