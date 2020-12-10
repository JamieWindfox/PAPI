
namespace GameMasterPAPI.Views
{
    partial class GameSelectionView
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
            this.savedGamesLabel = new System.Windows.Forms.Label();
            this.bottomButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.returnButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.gameTable = new System.Windows.Forms.TableLayoutPanel();
            this.genreLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.savedGamesLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bottomButtonPanel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.gameTable, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // savedGamesLabel
            // 
            this.savedGamesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.savedGamesLabel.AutoSize = true;
            this.savedGamesLabel.Location = new System.Drawing.Point(23, 30);
            this.savedGamesLabel.Name = "savedGamesLabel";
            this.savedGamesLabel.Size = new System.Drawing.Size(99, 19);
            this.savedGamesLabel.TabIndex = 0;
            this.savedGamesLabel.Text = "savedGames";
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
            this.bottomButtonPanel.Location = new System.Drawing.Point(23, 383);
            this.bottomButtonPanel.Name = "bottomButtonPanel";
            this.bottomButtonPanel.RowCount = 1;
            this.bottomButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomButtonPanel.Size = new System.Drawing.Size(754, 44);
            this.bottomButtonPanel.TabIndex = 1;
            // 
            // returnButton
            // 
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Location = new System.Drawing.Point(3, 3);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(120, 38);
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
            this.newGameButton.Size = new System.Drawing.Size(120, 38);
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
            this.gameTable.Controls.Add(this.genreLabel, 0, 0);
            this.gameTable.Controls.Add(this.dateLabel, 1, 0);
            this.gameTable.Controls.Add(this.startButton, 2, 0);
            this.gameTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameTable.Location = new System.Drawing.Point(23, 63);
            this.gameTable.Name = "gameTable";
            this.gameTable.RowCount = 1;
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gameTable.Size = new System.Drawing.Size(754, 44);
            this.gameTable.TabIndex = 2;
            // 
            // genreLabel
            // 
            this.genreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(3, 12);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(117, 19);
            this.genreLabel.TabIndex = 1;
            this.genreLabel.Text = "sessionGenre";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(339, 12);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(81, 19);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "dateText";
            // 
            // startButton
            // 
            this.startButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Location = new System.Drawing.Point(711, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(40, 38);
            this.startButton.TabIndex = 0;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Visible = false;
            // 
            // GameSelectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameSelectionView";
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
        private System.Windows.Forms.Label savedGamesLabel;
        private System.Windows.Forms.TableLayoutPanel bottomButtonPanel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.TableLayoutPanel gameTable;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}