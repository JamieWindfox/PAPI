
namespace GameMasterPAPI.Views
{
    partial class SelectGameView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.savedGamesText = new System.Windows.Forms.Label();
            this.bottomButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.returnButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.gameTable = new System.Windows.Forms.TableLayoutPanel();
            this.sessionGenreText = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.Label();
            this.startSessionButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.bottomButtonPanel.SuspendLayout();
            this.gameTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.savedGamesText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bottomButtonPanel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.gameTable, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // savedGamesText
            // 
            this.savedGamesText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.savedGamesText.AutoSize = true;
            this.savedGamesText.Location = new System.Drawing.Point(23, 30);
            this.savedGamesText.Name = "savedGamesText";
            this.savedGamesText.Size = new System.Drawing.Size(99, 19);
            this.savedGamesText.TabIndex = 0;
            this.savedGamesText.Text = "savedGames";
            // 
            // bottomButtonPanel
            // 
            this.bottomButtonPanel.ColumnCount = 4;
            this.bottomButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.bottomButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.bottomButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomButtonPanel.Controls.Add(this.returnButton, 0, 0);
            this.bottomButtonPanel.Controls.Add(this.newGameButton, 3, 0);
            this.bottomButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomButtonPanel.Location = new System.Drawing.Point(23, 388);
            this.bottomButtonPanel.Name = "bottomButtonPanel";
            this.bottomButtonPanel.RowCount = 1;
            this.bottomButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomButtonPanel.Size = new System.Drawing.Size(754, 39);
            this.bottomButtonPanel.TabIndex = 1;
            // 
            // returnButton
            // 
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Location = new System.Drawing.Point(3, 3);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(120, 33);
            this.returnButton.TabIndex = 0;
            this.returnButton.Text = "return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameButton.Location = new System.Drawing.Point(631, 3);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(120, 33);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "newGame";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // gameTable
            // 
            this.gameTable.AutoScroll = true;
            this.gameTable.ColumnCount = 3;
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.56234F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.27851F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gameTable.Controls.Add(this.sessionGenreText, 0, 0);
            this.gameTable.Controls.Add(this.dateText, 1, 0);
            this.gameTable.Controls.Add(this.startSessionButton, 2, 0);
            this.gameTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameTable.Location = new System.Drawing.Point(23, 63);
            this.gameTable.Name = "gameTable";
            this.gameTable.RowCount = 1;
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gameTable.Size = new System.Drawing.Size(754, 44);
            this.gameTable.TabIndex = 2;
            // 
            // sessionGenreText
            // 
            this.sessionGenreText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sessionGenreText.AutoSize = true;
            this.sessionGenreText.Location = new System.Drawing.Point(3, 12);
            this.sessionGenreText.Name = "sessionGenreText";
            this.sessionGenreText.Size = new System.Drawing.Size(117, 19);
            this.sessionGenreText.TabIndex = 1;
            this.sessionGenreText.Text = "sessionGenre";
            // 
            // dateText
            // 
            this.dateText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateText.AutoSize = true;
            this.dateText.Location = new System.Drawing.Point(339, 12);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(81, 19);
            this.dateText.TabIndex = 3;
            this.dateText.Text = "dateText";
            // 
            // startSessionButton
            // 
            this.startSessionButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.startSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startSessionButton.Location = new System.Drawing.Point(611, 3);
            this.startSessionButton.Name = "startSessionButton";
            this.startSessionButton.Size = new System.Drawing.Size(140, 38);
            this.startSessionButton.TabIndex = 0;
            this.startSessionButton.Text = "startSession";
            this.startSessionButton.UseVisualStyleBackColor = true;
            this.startSessionButton.Visible = false;
            // 
            // SelectGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SelectGameView";
            this.Text = "CreateGameView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.bottomButtonPanel.ResumeLayout(false);
            this.gameTable.ResumeLayout(false);
            this.gameTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label savedGamesText;
        private System.Windows.Forms.TableLayoutPanel bottomButtonPanel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.TableLayoutPanel gameTable;
        private System.Windows.Forms.Button startSessionButton;
        private System.Windows.Forms.Label sessionGenreText;
        private System.Windows.Forms.Label dateText;
    }
}