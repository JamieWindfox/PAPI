
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
            this.delete_game_button = new System.Windows.Forms.Button();
            this.load_game_button = new System.Windows.Forms.Button();
            this.genre_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
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
            this.gameSelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.gameSelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gameSelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.gameSelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gameSelectionPanel.Size = new System.Drawing.Size(803, 453);
            this.gameSelectionPanel.TabIndex = 0;
            // 
            // saved_games_label
            // 
            this.saved_games_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saved_games_label.AutoSize = true;
            this.saved_games_label.Location = new System.Drawing.Point(23, 35);
            this.saved_games_label.Name = "saved_games_label";
            this.saved_games_label.Size = new System.Drawing.Size(99, 19);
            this.saved_games_label.TabIndex = 0;
            this.saved_games_label.Text = "savedGames";
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
            this.bottomButtonPanel.Location = new System.Drawing.Point(23, 376);
            this.bottomButtonPanel.Name = "bottomButtonPanel";
            this.bottomButtonPanel.RowCount = 1;
            this.bottomButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomButtonPanel.Size = new System.Drawing.Size(757, 54);
            this.bottomButtonPanel.TabIndex = 1;
            // 
            // return_button
            // 
            this.return_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Location = new System.Drawing.Point(3, 11);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(200, 40);
            this.return_button.TabIndex = 0;
            this.return_button.Text = "return";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // game_creator_button
            // 
            this.game_creator_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.game_creator_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game_creator_button.Location = new System.Drawing.Point(554, 11);
            this.game_creator_button.Name = "game_creator_button";
            this.game_creator_button.Size = new System.Drawing.Size(200, 40);
            this.game_creator_button.TabIndex = 1;
            this.game_creator_button.Text = "newGame";
            this.game_creator_button.UseVisualStyleBackColor = true;
            this.game_creator_button.Click += new System.EventHandler(this.new_game_button_Click);
            // 
            // gameTable
            // 
            this.gameTable.AutoScroll = true;
            this.gameTable.ColumnCount = 4;
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gameTable.Controls.Add(this.delete_game_button, 2, 0);
            this.gameTable.Controls.Add(this.load_game_button, 3, 0);
            this.gameTable.Controls.Add(this.genre_label, 0, 0);
            this.gameTable.Controls.Add(this.date_label, 1, 0);
            this.gameTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameTable.Location = new System.Drawing.Point(23, 73);
            this.gameTable.Name = "gameTable";
            this.gameTable.RowCount = 1;
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gameTable.Size = new System.Drawing.Size(757, 50);
            this.gameTable.TabIndex = 2;
            // 
            // delete_game_button
            // 
            this.delete_game_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.delete_game_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_game_button.Location = new System.Drawing.Point(457, 5);
            this.delete_game_button.Name = "delete_game_button";
            this.delete_game_button.Size = new System.Drawing.Size(145, 40);
            this.delete_game_button.TabIndex = 4;
            this.delete_game_button.Text = "delete_game";
            this.delete_game_button.UseVisualStyleBackColor = true;
            this.delete_game_button.Visible = false;
            this.delete_game_button.Click += new System.EventHandler(this.delete_game_button_Click);
            // 
            // load_game_button
            // 
            this.load_game_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.load_game_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_game_button.Location = new System.Drawing.Point(608, 5);
            this.load_game_button.Name = "load_game_button";
            this.load_game_button.Size = new System.Drawing.Size(146, 40);
            this.load_game_button.TabIndex = 0;
            this.load_game_button.Text = "load_game";
            this.load_game_button.UseVisualStyleBackColor = true;
            this.load_game_button.Visible = false;
            // 
            // genre_label
            // 
            this.genre_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genre_label.AutoSize = true;
            this.genre_label.Location = new System.Drawing.Point(3, 15);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(117, 19);
            this.genre_label.TabIndex = 1;
            this.genre_label.Text = "sessionGenre";
            // 
            // date_label
            // 
            this.date_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(230, 15);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(81, 19);
            this.date_label.TabIndex = 3;
            this.date_label.Text = "dateText";
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
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Button delete_game_button;
    }
}