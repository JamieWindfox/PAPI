
namespace GameMasterPAPI.Views
{
    partial class GMStartScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeText = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.loadGameButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.Location = new System.Drawing.Point(401, 194);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(108, 19);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "welcomeText";
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Black;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.Lime;
            this.settingsButton.Location = new System.Drawing.Point(825, 449);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(96, 30);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // loadGameButton
            // 
            this.loadGameButton.BackColor = System.Drawing.Color.Black;
            this.loadGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadGameButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadGameButton.ForeColor = System.Drawing.Color.Lime;
            this.loadGameButton.Location = new System.Drawing.Point(348, 252);
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Size = new System.Drawing.Size(104, 30);
            this.loadGameButton.TabIndex = 2;
            this.loadGameButton.Text = "Load Game";
            this.loadGameButton.UseVisualStyleBackColor = false;
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.Black;
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.ForeColor = System.Drawing.Color.Lime;
            this.newGameButton.Location = new System.Drawing.Point(458, 252);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(104, 30);
            this.newGameButton.TabIndex = 3;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = false;
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Black;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.Lime;
            this.quitButton.Location = new System.Drawing.Point(12, 449);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(96, 30);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // GMStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(933, 491);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.loadGameButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.welcomeText);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GMStartScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Game Master Pen And Paper Interface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button loadGameButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button quitButton;
    }
}

