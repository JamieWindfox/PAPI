
namespace GameMasterPAPI.Views
{
    partial class GameCreationView
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
            this.createGamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.gmInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gmNameLabel = new System.Windows.Forms.Label();
            this.gmIPLabel = new System.Windows.Forms.Label();
            this.bottomButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.createGameButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreDropdown = new System.Windows.Forms.ComboBox();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playerListPanel = new System.Windows.Forms.TableLayoutPanel();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.createGamePanel.SuspendLayout();
            this.gmInfoPanel.SuspendLayout();
            this.bottomButtonPanel.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.playerListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createGamePanel
            // 
            this.createGamePanel.ColumnCount = 3;
            this.createGamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.createGamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.createGamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.createGamePanel.Controls.Add(this.gmInfoPanel, 1, 1);
            this.createGamePanel.Controls.Add(this.bottomButtonPanel, 1, 4);
            this.createGamePanel.Controls.Add(this.tableLayoutPanel, 1, 2);
            this.createGamePanel.Controls.Add(this.playerListPanel, 1, 3);
            this.createGamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createGamePanel.Location = new System.Drawing.Point(0, 0);
            this.createGamePanel.Name = "createGamePanel";
            this.createGamePanel.RowCount = 6;
            this.createGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.createGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.createGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.createGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.createGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.createGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.createGamePanel.Size = new System.Drawing.Size(800, 450);
            this.createGamePanel.TabIndex = 0;
            // 
            // gmInfoPanel
            // 
            this.gmInfoPanel.ColumnCount = 2;
            this.gmInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gmInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gmInfoPanel.Controls.Add(this.gmNameLabel, 0, 0);
            this.gmInfoPanel.Controls.Add(this.gmIPLabel, 1, 0);
            this.gmInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmInfoPanel.Location = new System.Drawing.Point(23, 23);
            this.gmInfoPanel.Name = "gmInfoPanel";
            this.gmInfoPanel.RowCount = 1;
            this.gmInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gmInfoPanel.Size = new System.Drawing.Size(754, 34);
            this.gmInfoPanel.TabIndex = 3;
            // 
            // gmNameLabel
            // 
            this.gmNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gmNameLabel.AutoSize = true;
            this.gmNameLabel.Location = new System.Drawing.Point(3, 7);
            this.gmNameLabel.Name = "gmNameLabel";
            this.gmNameLabel.Size = new System.Drawing.Size(135, 19);
            this.gmNameLabel.TabIndex = 0;
            this.gmNameLabel.Text = "gmName";
            this.gmNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gmIPLabel
            // 
            this.gmIPLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gmIPLabel.AutoSize = true;
            this.gmIPLabel.Location = new System.Drawing.Point(380, 7);
            this.gmIPLabel.Name = "gmIPLabel";
            this.gmIPLabel.Size = new System.Drawing.Size(117, 19);
            this.gmIPLabel.TabIndex = 1;
            this.gmIPLabel.Text = "gameMasterIP";
            this.gmIPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomButtonPanel
            // 
            this.bottomButtonPanel.ColumnCount = 2;
            this.bottomButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomButtonPanel.Controls.Add(this.createGameButton, 1, 0);
            this.bottomButtonPanel.Controls.Add(this.cancelButton, 0, 0);
            this.bottomButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomButtonPanel.Location = new System.Drawing.Point(23, 383);
            this.bottomButtonPanel.Name = "bottomButtonPanel";
            this.bottomButtonPanel.RowCount = 1;
            this.bottomButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomButtonPanel.Size = new System.Drawing.Size(754, 44);
            this.bottomButtonPanel.TabIndex = 4;
            // 
            // createGameButton
            // 
            this.createGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createGameButton.Location = new System.Drawing.Point(631, 3);
            this.createGameButton.Name = "createGameButton";
            this.createGameButton.Size = new System.Drawing.Size(120, 38);
            this.createGameButton.TabIndex = 1;
            this.createGameButton.Text = "create";
            this.createGameButton.UseVisualStyleBackColor = true;
            this.createGameButton.Click += new System.EventHandler(this.createGameButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 38);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel.Controls.Add(this.genreLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.genreDropdown, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.addPlayerButton, 2, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(23, 63);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(754, 74);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // genreLabel
            // 
            this.genreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(3, 10);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(54, 19);
            this.genreLabel.TabIndex = 2;
            this.genreLabel.Text = "genre";
            // 
            // genreDropdown
            // 
            this.genreDropdown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genreDropdown.FormattingEnabled = true;
            this.genreDropdown.Items.AddRange(new object[] {
            "nuclearFallout",
            "medievalFantasy",
            "magicWorld",
            "spaceOpera"});
            this.genreDropdown.Location = new System.Drawing.Point(133, 6);
            this.genreDropdown.Name = "genreDropdown";
            this.genreDropdown.Size = new System.Drawing.Size(200, 27);
            this.genreDropdown.TabIndex = 3;
            this.genreDropdown.SelectedIndexChanged += new System.EventHandler(this.genreDropdown_SelectedIndexChanged);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayerButton.Location = new System.Drawing.Point(631, 3);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(120, 34);
            this.addPlayerButton.TabIndex = 4;
            this.addPlayerButton.Text = "addPlayer";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // playerListPanel
            // 
            this.playerListPanel.AutoScroll = true;
            this.playerListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playerListPanel.ColumnCount = 2;
            this.playerListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playerListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.playerListPanel.Controls.Add(this.playerNameLabel, 0, 0);
            this.playerListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerListPanel.Location = new System.Drawing.Point(23, 143);
            this.playerListPanel.Name = "playerListPanel";
            this.playerListPanel.RowCount = 1;
            this.playerListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playerListPanel.Size = new System.Drawing.Size(754, 234);
            this.playerListPanel.TabIndex = 6;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(3, 0);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(99, 19);
            this.playerNameLabel.TabIndex = 0;
            this.playerNameLabel.Text = "playerName";
            // 
            // GameCreationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createGamePanel);
            this.Name = "GameCreationView";
            this.Text = "CreateNewGameView";
            this.createGamePanel.ResumeLayout(false);
            this.gmInfoPanel.ResumeLayout(false);
            this.gmInfoPanel.PerformLayout();
            this.bottomButtonPanel.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.playerListPanel.ResumeLayout(false);
            this.playerListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel createGamePanel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TableLayoutPanel gmInfoPanel;
        private System.Windows.Forms.Label gmNameLabel;
        private System.Windows.Forms.Label gmIPLabel;
        private System.Windows.Forms.TableLayoutPanel bottomButtonPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createGameButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ComboBox genreDropdown;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.TableLayoutPanel playerListPanel;
        private System.Windows.Forms.Label playerNameLabel;
    }
}