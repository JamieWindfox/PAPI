
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.returnButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.sessionRow = new System.Windows.Forms.TableLayoutPanel();
            this.startSessionButton = new System.Windows.Forms.Button();
            this.sessionGenreText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.sessionRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.savedGamesText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.sessionRow, 1, 2);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.returnButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.newGameButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.previousPageButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nextPageButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 388);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(754, 39);
            this.tableLayoutPanel2.TabIndex = 1;
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
            // 
            // previousPageButton
            // 
            this.previousPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previousPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousPageButton.Location = new System.Drawing.Point(324, 6);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(50, 30);
            this.previousPageButton.TabIndex = 2;
            this.previousPageButton.Text = "<-";
            this.previousPageButton.UseVisualStyleBackColor = true;
            this.previousPageButton.Click += new System.EventHandler(this.previousPageButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nextPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPageButton.Location = new System.Drawing.Point(380, 6);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(50, 30);
            this.nextPageButton.TabIndex = 3;
            this.nextPageButton.Text = "->";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // sessionRow
            // 
            this.sessionRow.ColumnCount = 4;
            this.sessionRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sessionRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.sessionRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sessionRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.sessionRow.Controls.Add(this.startSessionButton, 3, 0);
            this.sessionRow.Controls.Add(this.sessionGenreText, 0, 0);
            this.sessionRow.Controls.Add(this.label2, 1, 0);
            this.sessionRow.Controls.Add(this.label3, 2, 0);
            this.sessionRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.sessionRow.Location = new System.Drawing.Point(23, 63);
            this.sessionRow.Name = "sessionRow";
            this.sessionRow.RowCount = 1;
            this.sessionRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sessionRow.Size = new System.Drawing.Size(754, 40);
            this.sessionRow.TabIndex = 2;
            // 
            // startSessionButton
            // 
            this.startSessionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startSessionButton.Location = new System.Drawing.Point(654, 3);
            this.startSessionButton.Name = "startSessionButton";
            this.startSessionButton.Size = new System.Drawing.Size(97, 34);
            this.startSessionButton.TabIndex = 0;
            this.startSessionButton.Text = "startSession";
            this.startSessionButton.UseVisualStyleBackColor = true;
            // 
            // sessionGenreText
            // 
            this.sessionGenreText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sessionGenreText.AutoSize = true;
            this.sessionGenreText.Location = new System.Drawing.Point(3, 10);
            this.sessionGenreText.Name = "sessionGenreText";
            this.sessionGenreText.Size = new System.Drawing.Size(117, 19);
            this.sessionGenreText.TabIndex = 1;
            this.sessionGenreText.Text = "sessionGenre";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "playerCharacterText";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "dateText";
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.sessionRow.ResumeLayout(false);
            this.sessionRow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label savedGamesText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.TableLayoutPanel sessionRow;
        private System.Windows.Forms.Button startSessionButton;
        private System.Windows.Forms.Label sessionGenreText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}