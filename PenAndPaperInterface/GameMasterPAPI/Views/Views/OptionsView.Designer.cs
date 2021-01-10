
namespace PAPIClient.Views
{
    partial class GMOptionsView
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
            this.language_dropdown = new System.Windows.Forms.ComboBox();
            this.design_dropdown = new System.Windows.Forms.ComboBox();
            this.return_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.design_label = new System.Windows.Forms.Label();
            this.language_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.player_name_label = new System.Windows.Forms.Label();
            this.playerName_inputField = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // language_dropdown
            // 
            this.language_dropdown.FormattingEnabled = true;
            this.language_dropdown.Items.AddRange(new object[] {
            "English",
            "Deutsch"});
            this.language_dropdown.Location = new System.Drawing.Point(14, 55);
            this.language_dropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.language_dropdown.Name = "language_dropdown";
            this.language_dropdown.Size = new System.Drawing.Size(220, 27);
            this.language_dropdown.TabIndex = 0;
            this.language_dropdown.SelectedIndexChanged += new System.EventHandler(this.languageDropdown_SelectedIndexChanged);
            // 
            // design_dropdown
            // 
            this.design_dropdown.FormattingEnabled = true;
            this.design_dropdown.Items.AddRange(new object[] {
            "black_on_antique",
            "green_on_black",
            "black_on_white"});
            this.design_dropdown.Location = new System.Drawing.Point(347, 55);
            this.design_dropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.design_dropdown.Name = "design_dropdown";
            this.design_dropdown.Size = new System.Drawing.Size(220, 27);
            this.design_dropdown.TabIndex = 1;
            this.design_dropdown.SelectedIndexChanged += new System.EventHandler(this.designDropdown_SelectedIndexChanged);
            // 
            // return_button
            // 
            this.return_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.return_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Location = new System.Drawing.Point(13, 393);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(200, 36);
            this.return_button.TabIndex = 6;
            this.return_button.Text = "return_button";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 431F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel.Controls.Add(this.design_dropdown, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.language_dropdown, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.design_label, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.language_label, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.return_button, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(784, 453);
            this.tableLayoutPanel.TabIndex = 8;
            // 
            // design_label
            // 
            this.design_label.AutoSize = true;
            this.design_label.Location = new System.Drawing.Point(346, 20);
            this.design_label.Name = "design_label";
            this.design_label.Size = new System.Drawing.Size(117, 19);
            this.design_label.TabIndex = 9;
            this.design_label.Text = "design_label";
            // 
            // language_label
            // 
            this.language_label.AutoSize = true;
            this.language_label.Location = new System.Drawing.Point(13, 20);
            this.language_label.Name = "language_label";
            this.language_label.Size = new System.Drawing.Size(135, 19);
            this.language_label.TabIndex = 8;
            this.language_label.Text = "language_label";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.player_name_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerName_inputField, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(327, 266);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // player_name_label
            // 
            this.player_name_label.AutoSize = true;
            this.player_name_label.Location = new System.Drawing.Point(3, 0);
            this.player_name_label.Name = "player_name_label";
            this.player_name_label.Size = new System.Drawing.Size(162, 19);
            this.player_name_label.TabIndex = 0;
            this.player_name_label.Text = "player_name_label";
            // 
            // playerName_inputField
            // 
            this.playerName_inputField.BackColor = System.Drawing.SystemColors.Window;
            this.playerName_inputField.Dock = System.Windows.Forms.DockStyle.Top;
            this.playerName_inputField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.playerName_inputField.Location = new System.Drawing.Point(3, 33);
            this.playerName_inputField.Name = "playerName_inputField";
            this.playerName_inputField.Size = new System.Drawing.Size(321, 26);
            this.playerName_inputField.TabIndex = 1;
            this.playerName_inputField.Text = "PLAYER NAME";
            this.playerName_inputField.TextChanged += new System.EventHandler(this.playerNameInputField_TextChanged);
            // 
            // GMOptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 453);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "GMOptionsView";
            this.Text = "GMOptionsView";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox language_dropdown;
        private System.Windows.Forms.ComboBox design_dropdown;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label language_label;
        private System.Windows.Forms.Label design_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label player_name_label;
        private System.Windows.Forms.TextBox playerName_inputField;
    }
}