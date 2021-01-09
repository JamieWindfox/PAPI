
namespace PAPIClient.Views
{
    partial class ShowGameOverviewView
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
            this.showGamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.gameInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.genreLabel = new System.Windows.Forms.Label();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.lastSaveLabel = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.playerCharacterPanel = new System.Windows.Forms.TableLayoutPanel();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.speciesLabel = new System.Windows.Forms.Label();
            this.careerLabel = new System.Windows.Forms.Label();
            this.showGamePanel.SuspendLayout();
            this.gameInfoPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.playerCharacterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // showGamePanel
            // 
            this.showGamePanel.ColumnCount = 3;
            this.showGamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.showGamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.showGamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.showGamePanel.Controls.Add(this.gameInfoPanel, 1, 1);
            this.showGamePanel.Controls.Add(this.buttonPanel, 1, 3);
            this.showGamePanel.Controls.Add(this.playerCharacterPanel, 1, 2);
            this.showGamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showGamePanel.Location = new System.Drawing.Point(0, 0);
            this.showGamePanel.Name = "showGamePanel";
            this.showGamePanel.RowCount = 5;
            this.showGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.showGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.showGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.showGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.showGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.showGamePanel.Size = new System.Drawing.Size(800, 450);
            this.showGamePanel.TabIndex = 0;
            // 
            // gameInfoPanel
            // 
            this.gameInfoPanel.ColumnCount = 2;
            this.gameInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameInfoPanel.Controls.Add(this.genreLabel, 0, 0);
            this.gameInfoPanel.Controls.Add(this.creationDateLabel, 1, 0);
            this.gameInfoPanel.Controls.Add(this.lastSaveLabel, 1, 1);
            this.gameInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameInfoPanel.Location = new System.Drawing.Point(23, 23);
            this.gameInfoPanel.Name = "gameInfoPanel";
            this.gameInfoPanel.RowCount = 2;
            this.gameInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameInfoPanel.Size = new System.Drawing.Size(754, 94);
            this.gameInfoPanel.TabIndex = 0;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(3, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(54, 19);
            this.genreLabel.TabIndex = 0;
            this.genreLabel.Text = "genre";
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.Location = new System.Drawing.Point(380, 0);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(117, 19);
            this.creationDateLabel.TabIndex = 1;
            this.creationDateLabel.Text = "creationDate";
            // 
            // lastSaveLabel
            // 
            this.lastSaveLabel.AutoSize = true;
            this.lastSaveLabel.Location = new System.Drawing.Point(380, 47);
            this.lastSaveLabel.Name = "lastSaveLabel";
            this.lastSaveLabel.Size = new System.Drawing.Size(81, 19);
            this.lastSaveLabel.TabIndex = 2;
            this.lastSaveLabel.Text = "lastSave";
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 3;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonPanel.Controls.Add(this.cancelButton, 0, 0);
            this.buttonPanel.Controls.Add(this.deleteButton, 1, 0);
            this.buttonPanel.Controls.Add(this.startButton, 2, 0);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(23, 383);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 1;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonPanel.Size = new System.Drawing.Size(754, 44);
            this.buttonPanel.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 38);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(316, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 38);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Location = new System.Drawing.Point(631, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 38);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // playerCharacterPanel
            // 
            this.playerCharacterPanel.AutoScroll = true;
            this.playerCharacterPanel.ColumnCount = 4;
            this.playerCharacterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.playerCharacterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.playerCharacterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.playerCharacterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.playerCharacterPanel.Controls.Add(this.playerNameLabel, 0, 0);
            this.playerCharacterPanel.Controls.Add(this.characterNameLabel, 1, 0);
            this.playerCharacterPanel.Controls.Add(this.speciesLabel, 2, 0);
            this.playerCharacterPanel.Controls.Add(this.careerLabel, 3, 0);
            this.playerCharacterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.playerCharacterPanel.Location = new System.Drawing.Point(23, 123);
            this.playerCharacterPanel.Name = "playerCharacterPanel";
            this.playerCharacterPanel.RowCount = 2;
            this.playerCharacterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.playerCharacterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.playerCharacterPanel.Size = new System.Drawing.Size(754, 100);
            this.playerCharacterPanel.TabIndex = 2;
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
            // characterNameLabel
            // 
            this.characterNameLabel.AutoSize = true;
            this.characterNameLabel.Location = new System.Drawing.Point(191, 0);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(126, 19);
            this.characterNameLabel.TabIndex = 1;
            this.characterNameLabel.Text = "characterName";
            // 
            // speciesLabel
            // 
            this.speciesLabel.AutoSize = true;
            this.speciesLabel.Location = new System.Drawing.Point(379, 0);
            this.speciesLabel.Name = "speciesLabel";
            this.speciesLabel.Size = new System.Drawing.Size(72, 19);
            this.speciesLabel.TabIndex = 2;
            this.speciesLabel.Text = "species";
            // 
            // careerLabel
            // 
            this.careerLabel.AutoSize = true;
            this.careerLabel.Location = new System.Drawing.Point(567, 0);
            this.careerLabel.Name = "careerLabel";
            this.careerLabel.Size = new System.Drawing.Size(63, 19);
            this.careerLabel.TabIndex = 3;
            this.careerLabel.Text = "career";
            // 
            // ShowGameOverviewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showGamePanel);
            this.Name = "ShowGameOverviewView";
            this.Text = "ShowGamePopup";
            this.showGamePanel.ResumeLayout(false);
            this.gameInfoPanel.ResumeLayout(false);
            this.gameInfoPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.playerCharacterPanel.ResumeLayout(false);
            this.playerCharacterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel showGamePanel;
        private System.Windows.Forms.TableLayoutPanel gameInfoPanel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.Label lastSaveLabel;
        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TableLayoutPanel playerCharacterPanel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.Label speciesLabel;
        private System.Windows.Forms.Label careerLabel;
    }
}