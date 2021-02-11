
namespace PAPIClient.Views
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
            this.gm_name_label = new System.Windows.Forms.Label();
            this.game_id_label = new System.Windows.Forms.Label();
            this.gm_name = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.bottomButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.create_and_return_button = new System.Windows.Forms.Button();
            this.create_and_start_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.genre_label = new System.Windows.Forms.Label();
            this.genreDropdown = new System.Windows.Forms.ComboBox();
            this.genre_description = new System.Windows.Forms.Label();
            this.createGamePanel.SuspendLayout();
            this.gmInfoPanel.SuspendLayout();
            this.bottomButtonPanel.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
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
            this.createGamePanel.Controls.Add(this.genre_description, 1, 3);
            this.createGamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createGamePanel.Location = new System.Drawing.Point(0, 0);
            this.createGamePanel.Name = "createGamePanel";
            this.createGamePanel.RowCount = 6;
            this.createGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.createGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.createGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.createGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.createGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.createGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.createGamePanel.Size = new System.Drawing.Size(800, 450);
            this.createGamePanel.TabIndex = 0;
            // 
            // gmInfoPanel
            // 
            this.gmInfoPanel.ColumnCount = 4;
            this.gmInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.gmInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.gmInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.gmInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.gmInfoPanel.Controls.Add(this.gm_name_label, 0, 0);
            this.gmInfoPanel.Controls.Add(this.game_id_label, 2, 0);
            this.gmInfoPanel.Controls.Add(this.gm_name, 1, 0);
            this.gmInfoPanel.Controls.Add(this.id_textbox, 3, 0);
            this.gmInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmInfoPanel.Location = new System.Drawing.Point(23, 23);
            this.gmInfoPanel.Name = "gmInfoPanel";
            this.gmInfoPanel.RowCount = 1;
            this.gmInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gmInfoPanel.Size = new System.Drawing.Size(754, 34);
            this.gmInfoPanel.TabIndex = 3;
            // 
            // gm_name_label
            // 
            this.gm_name_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gm_name_label.AutoSize = true;
            this.gm_name_label.Location = new System.Drawing.Point(3, 7);
            this.gm_name_label.Name = "gm_name_label";
            this.gm_name_label.Size = new System.Drawing.Size(126, 19);
            this.gm_name_label.TabIndex = 0;
            this.gm_name_label.Text = "gm_name_label";
            this.gm_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // game_id_label
            // 
            this.game_id_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.game_id_label.AutoSize = true;
            this.game_id_label.Location = new System.Drawing.Point(354, 0);
            this.game_id_label.Name = "game_id_label";
            this.game_id_label.Size = new System.Drawing.Size(90, 34);
            this.game_id_label.TabIndex = 1;
            this.game_id_label.Text = "game_id_label";
            this.game_id_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gm_name
            // 
            this.gm_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gm_name.AutoSize = true;
            this.gm_name.Location = new System.Drawing.Point(153, 7);
            this.gm_name.Name = "gm_name";
            this.gm_name.Size = new System.Drawing.Size(45, 19);
            this.gm_name.TabIndex = 2;
            this.gm_name.Text = "name";
            // 
            // id_textbox
            // 
            this.id_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id_textbox.Location = new System.Drawing.Point(454, 3);
            this.id_textbox.MaxLength = 100;
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.ReadOnly = true;
            this.id_textbox.Size = new System.Drawing.Size(297, 26);
            this.id_textbox.TabIndex = 3;
            // 
            // bottomButtonPanel
            // 
            this.bottomButtonPanel.ColumnCount = 3;
            this.bottomButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.bottomButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.bottomButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.bottomButtonPanel.Controls.Add(this.create_and_return_button, 0, 0);
            this.bottomButtonPanel.Controls.Add(this.create_and_start_button, 1, 0);
            this.bottomButtonPanel.Controls.Add(this.cancel_button, 0, 0);
            this.bottomButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomButtonPanel.Location = new System.Drawing.Point(23, 378);
            this.bottomButtonPanel.Name = "bottomButtonPanel";
            this.bottomButtonPanel.RowCount = 1;
            this.bottomButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomButtonPanel.Size = new System.Drawing.Size(754, 49);
            this.bottomButtonPanel.TabIndex = 4;
            // 
            // create_and_return_button
            // 
            this.create_and_return_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.create_and_return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_and_return_button.Location = new System.Drawing.Point(276, 6);
            this.create_and_return_button.Name = "create_and_return_button";
            this.create_and_return_button.Size = new System.Drawing.Size(200, 40);
            this.create_and_return_button.TabIndex = 2;
            this.create_and_return_button.Text = "create_and_return_button";
            this.create_and_return_button.UseVisualStyleBackColor = true;
            this.create_and_return_button.Click += new System.EventHandler(this.create_and_return_button_Click);
            // 
            // create_and_start_button
            // 
            this.create_and_start_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.create_and_start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_and_start_button.Location = new System.Drawing.Point(551, 6);
            this.create_and_start_button.Name = "create_and_start_button";
            this.create_and_start_button.Size = new System.Drawing.Size(200, 40);
            this.create_and_start_button.TabIndex = 1;
            this.create_and_start_button.Text = "create_and_start_button";
            this.create_and_start_button.UseVisualStyleBackColor = true;
            this.create_and_start_button.Click += new System.EventHandler(this.create_and_start_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Location = new System.Drawing.Point(3, 6);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(200, 40);
            this.cancel_button.TabIndex = 0;
            this.cancel_button.Text = "cancel_button";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel.Controls.Add(this.genre_label, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.genreDropdown, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(23, 63);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(754, 74);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // genre_label
            // 
            this.genre_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genre_label.AutoSize = true;
            this.genre_label.Location = new System.Drawing.Point(3, 10);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(108, 19);
            this.genre_label.TabIndex = 2;
            this.genre_label.Text = "genre_label";
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
            this.genreDropdown.Size = new System.Drawing.Size(289, 27);
            this.genreDropdown.TabIndex = 3;
            this.genreDropdown.SelectedIndexChanged += new System.EventHandler(this.genreDropdown_SelectedIndexChanged);
            // 
            // genre_description
            // 
            this.genre_description.AutoSize = true;
            this.genre_description.Location = new System.Drawing.Point(23, 140);
            this.genre_description.Name = "genre_description";
            this.genre_description.Size = new System.Drawing.Size(45, 19);
            this.genre_description.TabIndex = 6;
            this.genre_description.Text = "    ";
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
            this.createGamePanel.PerformLayout();
            this.gmInfoPanel.ResumeLayout(false);
            this.gmInfoPanel.PerformLayout();
            this.bottomButtonPanel.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel createGamePanel;
        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.TableLayoutPanel gmInfoPanel;
        private System.Windows.Forms.Label gm_name_label;
        private System.Windows.Forms.Label game_id_label;
        private System.Windows.Forms.TableLayoutPanel bottomButtonPanel;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button create_and_start_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ComboBox genreDropdown;
        private System.Windows.Forms.Button create_and_return_button;
        private System.Windows.Forms.Label gm_name;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Label genre_description;
    }
}