
namespace GameMasterPAPI.Views
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
            this.languageDropdown = new System.Windows.Forms.ComboBox();
            this.designDropdown = new System.Windows.Forms.ComboBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.designText = new System.Windows.Forms.Label();
            this.languageText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gmName = new System.Windows.Forms.Label();
            this.gmNameInputField = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // languageDropdown
            // 
            this.languageDropdown.FormattingEnabled = true;
            this.languageDropdown.Items.AddRange(new object[] {
            "English",
            "Deutsch"});
            this.languageDropdown.Location = new System.Drawing.Point(14, 55);
            this.languageDropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.languageDropdown.Name = "languageDropdown";
            this.languageDropdown.Size = new System.Drawing.Size(193, 27);
            this.languageDropdown.TabIndex = 0;
            this.languageDropdown.SelectedIndexChanged += new System.EventHandler(this.languageDropdown_SelectedIndexChanged);
            // 
            // designDropdown
            // 
            this.designDropdown.FormattingEnabled = true;
            this.designDropdown.Items.AddRange(new object[] {
            "medievalDesign",
            "modernDesign"});
            this.designDropdown.Location = new System.Drawing.Point(347, 55);
            this.designDropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.designDropdown.Name = "designDropdown";
            this.designDropdown.Size = new System.Drawing.Size(193, 27);
            this.designDropdown.TabIndex = 1;
            this.designDropdown.SelectedIndexChanged += new System.EventHandler(this.designDropdown_SelectedIndexChanged);
            // 
            // returnButton
            // 
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Location = new System.Drawing.Point(13, 393);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(100, 36);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 431F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel.Controls.Add(this.designDropdown, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.languageDropdown, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.designText, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.languageText, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.returnButton, 1, 4);
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
            // designText
            // 
            this.designText.AutoSize = true;
            this.designText.Location = new System.Drawing.Point(346, 20);
            this.designText.Name = "designText";
            this.designText.Size = new System.Drawing.Size(63, 19);
            this.designText.TabIndex = 9;
            this.designText.Text = "design";
            // 
            // languageText
            // 
            this.languageText.AutoSize = true;
            this.languageText.Location = new System.Drawing.Point(13, 20);
            this.languageText.Name = "languageText";
            this.languageText.Size = new System.Drawing.Size(81, 19);
            this.languageText.TabIndex = 8;
            this.languageText.Text = "language";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gmName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gmNameInputField, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(327, 266);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // gmName
            // 
            this.gmName.AutoSize = true;
            this.gmName.Location = new System.Drawing.Point(3, 0);
            this.gmName.Name = "gmName";
            this.gmName.Size = new System.Drawing.Size(63, 19);
            this.gmName.TabIndex = 0;
            this.gmName.Text = "gmName";
            // 
            // gmNameInputField
            // 
            this.gmNameInputField.BackColor = System.Drawing.SystemColors.Window;
            this.gmNameInputField.Dock = System.Windows.Forms.DockStyle.Top;
            this.gmNameInputField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gmNameInputField.Location = new System.Drawing.Point(3, 33);
            this.gmNameInputField.Name = "gmNameInputField";
            this.gmNameInputField.Size = new System.Drawing.Size(321, 26);
            this.gmNameInputField.TabIndex = 1;
            this.gmNameInputField.Text = "GAME MASTER";
            this.gmNameInputField.TextChanged += new System.EventHandler(this.gmNameInputField_TextChanged);
            // 
            // GMOptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 453);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "GMOptionsView";
            this.Text = "GMLoadingView";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox languageDropdown;
        private System.Windows.Forms.ComboBox designDropdown;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label languageText;
        private System.Windows.Forms.Label designText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label gmName;
        private System.Windows.Forms.TextBox gmNameInputField;
    }
}