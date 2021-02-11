
namespace PAPIClient.Views
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
            this.gameSelectionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saved_games_label = new System.Windows.Forms.Label();
            this.bottomButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.return_button = new System.Windows.Forms.Button();
            this.game_creator_button = new System.Windows.Forms.Button();
            this.gameTable = new System.Windows.Forms.TableLayoutPanel();
            this.genre_label = new System.Windows.Forms.Label();
            this.date_game_creation_label = new System.Windows.Forms.Label();
            this.load_game_button = new System.Windows.Forms.Button();
            this.date_last_save_label = new System.Windows.Forms.Label();
            this.delte_game_button = new System.Windows.Forms.Button();
            this.gameSelectionPanel.SuspendLayout();
            this.bottomButtonPanel.SuspendLayout();
            this.gameTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameSelectionPanel
            // 
            this.gameSelectionPanel.ColumnCount = 3;
            this.gameSelectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gameSelectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gameSelectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gameSelectionPanel.Controls.Add(this.saved_games_label, 1, 1);
            this.gameSelectionPanel.Controls.Add(this.bottomButtonPanel, 1, 3);
            this.gameSelectionPanel.Controls.Add(this.gameTable, 1, 2);
            this.gameSelectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameSelectionPanel.Location = new System.Drawing.Point(0, 0);
            this.gameSelectionPanel.Name = "gameSelectionPanel";
            this.gameSelectionPanel.RowCount = 5;
            this.gameSelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gameSelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.gameSelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gameSelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.gameSelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gameSelectionPanel.Size = new System.Drawing.Size(803, 453);
            this.gameSelectionPanel.TabIndex = 0;
            // 
            // saved_games_label
            // 
            this.saved_games_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saved_games_label.AutoSize = true;
            this.saved_games_label.Location = new System.Drawing.Point(23, 30);
            this.saved_games_label.Name = "saved_games_label";
            this.saved_games_label.Size = new System.Drawing.Size(162, 19);
            this.saved_games_label.TabIndex = 0;
            this.saved_games_label.Text = "saved_games_label";
            // 
            // bottomButtonPanel
            // 
            this.bottomButtonPanel.ColumnCount = 4;
            this.bottomButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.bottomButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.bottomButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomButtonPanel.Controls.Add(this.return_button, 0, 0);
            this.bottomButtonPanel.Controls.Add(this.game_creator_button, 3, 0);
            this.bottomButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomButtonPanel.Location = new System.Drawing.Point(23, 386);
            this.bottomButtonPanel.Name = "bottomButtonPanel";
            this.bottomButtonPanel.RowCount = 1;
            this.bottomButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomButtonPanel.Size = new System.Drawing.Size(757, 44);
            this.bottomButtonPanel.TabIndex = 1;
            // 
            // return_button
            // 
            this.return_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Location = new System.Drawing.Point(3, 3);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(120, 38);
            this.return_button.TabIndex = 0;
            this.return_button.Text = "return";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // game_creator_button
            // 
            this.game_creator_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.game_creator_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game_creator_button.Location = new System.Drawing.Point(634, 3);
            this.game_creator_button.Name = "game_creator_button";
            this.game_creator_button.Size = new System.Drawing.Size(120, 38);
            this.game_creator_button.TabIndex = 1;
            this.game_creator_button.Text = "game_creator_button";
            this.game_creator_button.UseVisualStyleBackColor = true;
            this.game_creator_button.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // gameTable
            // 
            this.gameTable.AutoScroll = true;
            this.gameTable.ColumnCount = 5;
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gameTable.Controls.Add(this.genre_label, 0, 0);
            this.gameTable.Controls.Add(this.date_game_creation_label, 1, 0);
            this.gameTable.Controls.Add(this.load_game_button, 3, 0);
            this.gameTable.Controls.Add(this.date_last_save_label, 2, 0);
            this.gameTable.Controls.Add(this.delte_game_button, 4, 0);
            this.gameTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameTable.Location = new System.Drawing.Point(23, 63);
            this.gameTable.Name = "gameTable";
            this.gameTable.RowCount = 1;
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gameTable.Size = new System.Drawing.Size(757, 44);
            this.gameTable.TabIndex = 2;
            // 
            // genre_label
            // 
            this.genre_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genre_label.AutoSize = true;
            this.genre_label.Location = new System.Drawing.Point(3, 12);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(108, 19);
            this.genre_label.TabIndex = 1;
            this.genre_label.Text = "genre_label";
            // 
            // date_game_creation_label
            // 
            this.date_game_creation_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.date_game_creation_label.AutoSize = true;
            this.date_game_creation_label.Location = new System.Drawing.Point(203, 12);
            this.date_game_creation_label.Name = "date_game_creation_label";
            this.date_game_creation_label.Size = new System.Drawing.Size(225, 19);
            this.date_game_creation_label.TabIndex = 3;
            this.date_game_creation_label.Text = "date_game_creation_label";
            // 
            // load_game_button
            // 
            this.load_game_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.load_game_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_game_button.Location = new System.Drawing.Point(669, 3);
            this.load_game_button.Name = "load_game_button";
            this.load_game_button.Size = new System.Drawing.Size(39, 38);
            this.load_game_button.TabIndex = 0;
            this.load_game_button.UseVisualStyleBackColor = true;
            this.load_game_button.Visible = false;
            // 
            // date_last_save_label
            // 
            this.date_last_save_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.date_last_save_label.AutoSize = true;
            this.date_last_save_label.Location = new System.Drawing.Point(436, 12);
            this.date_last_save_label.Name = "date_last_save_label";
            this.date_last_save_label.Size = new System.Drawing.Size(189, 19);
            this.date_last_save_label.TabIndex = 4;
            this.date_last_save_label.Text = "date_last_save_label";
            // 
            // delte_game_button
            // 
            this.delte_game_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delte_game_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delte_game_button.Location = new System.Drawing.Point(714, 3);
            this.delte_game_button.Name = "delte_game_button";
            this.delte_game_button.Size = new System.Drawing.Size(40, 38);
            this.delte_game_button.TabIndex = 5;
            this.delte_game_button.UseVisualStyleBackColor = true;
            this.delte_game_button.Visible = false;
            // 
            // GameSelectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 453);
            this.Controls.Add(this.gameSelectionPanel);
            this.Name = "GameSelectionView";
            this.Text = "CreateGameView";
            this.Load += new System.EventHandler(this.GameSelectionView_Load);
            this.gameSelectionPanel.ResumeLayout(false);
            this.gameSelectionPanel.PerformLayout();
            this.bottomButtonPanel.ResumeLayout(false);
            this.gameTable.ResumeLayout(false);
            this.gameTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gameSelectionPanel;
        private System.Windows.Forms.Label saved_games_label;
        private System.Windows.Forms.TableLayoutPanel bottomButtonPanel;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button game_creator_button;
        private System.Windows.Forms.TableLayoutPanel gameTable;
        private System.Windows.Forms.Button load_game_button;
        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.Label date_game_creation_label;
        private System.Windows.Forms.Label date_last_save_label;
        private System.Windows.Forms.Button delte_game_button;
    }
}