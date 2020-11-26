
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
            this.languageText = new System.Windows.Forms.Label();
            this.designText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // languageDropdown
            // 
            this.languageDropdown.FormattingEnabled = true;
            this.languageDropdown.Items.AddRange(new object[] {
            "English",
            "Deutsch"});
            this.languageDropdown.Location = new System.Drawing.Point(8, 24);
            this.languageDropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.languageDropdown.Name = "languageDropdown";
            this.languageDropdown.Size = new System.Drawing.Size(180, 27);
            this.languageDropdown.TabIndex = 0;
            this.languageDropdown.SelectedIndexChanged += new System.EventHandler(this.languageDropdown_SelectedIndexChanged);
            // 
            // designDropdown
            // 
            this.designDropdown.FormattingEnabled = true;
            this.designDropdown.Items.AddRange(new object[] {
            "medievalDesign",
            "modernDesign"});
            this.designDropdown.Location = new System.Drawing.Point(8, 24);
            this.designDropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.designDropdown.Name = "designDropdown";
            this.designDropdown.Size = new System.Drawing.Size(180, 27);
            this.designDropdown.TabIndex = 1;
            this.designDropdown.SelectedIndexChanged += new System.EventHandler(this.designDropdown_SelectedIndexChanged);
            // 
            // languageText
            // 
            this.languageText.AutoSize = true;
            this.languageText.Location = new System.Drawing.Point(4, 0);
            this.languageText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languageText.Name = "languageText";
            this.languageText.Size = new System.Drawing.Size(81, 19);
            this.languageText.TabIndex = 2;
            this.languageText.Text = "language";
            // 
            // designText
            // 
            this.designText.AutoSize = true;
            this.designText.Location = new System.Drawing.Point(4, 0);
            this.designText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.designText.Name = "designText";
            this.designText.Size = new System.Drawing.Size(63, 19);
            this.designText.TabIndex = 3;
            this.designText.Text = "design";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.languageText);
            this.panel1.Controls.Add(this.languageDropdown);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 55);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.designDropdown);
            this.panel2.Controls.Add(this.designText);
            this.panel2.Location = new System.Drawing.Point(10, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 58);
            this.panel2.TabIndex = 5;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 622);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "button1";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Location = new System.Drawing.Point(683, 515);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(89, 34);
            this.acceptButton.TabIndex = 7;
            this.acceptButton.Text = "accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // GMFirstStartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "GMFirstStartView";
            this.Text = "GMLoadingView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox languageDropdown;
        private System.Windows.Forms.ComboBox designDropdown;
        private System.Windows.Forms.Label languageText;
        private System.Windows.Forms.Label designText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button acceptButton;
    }
}