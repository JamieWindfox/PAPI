
namespace PAPIClient.Views
{
    partial class DeleteGamePromptPopup
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
            this.promptPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.deleteGameQuestionLabel = new System.Windows.Forms.Label();
            this.promptPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // promptPanel
            // 
            this.promptPanel.ColumnCount = 3;
            this.promptPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.promptPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.promptPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.promptPanel.Controls.Add(this.buttonPanel, 1, 2);
            this.promptPanel.Controls.Add(this.deleteGameQuestionLabel, 1, 1);
            this.promptPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promptPanel.Location = new System.Drawing.Point(0, 0);
            this.promptPanel.Name = "promptPanel";
            this.promptPanel.RowCount = 4;
            this.promptPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.promptPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.promptPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.promptPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.promptPanel.Size = new System.Drawing.Size(410, 213);
            this.promptPanel.TabIndex = 0;
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 2;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.Controls.Add(this.yesButton, 0, 0);
            this.buttonPanel.Controls.Add(this.noButton, 1, 0);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(23, 146);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 1;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.Size = new System.Drawing.Size(364, 44);
            this.buttonPanel.TabIndex = 0;
            // 
            // yesButton
            // 
            this.yesButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Location = new System.Drawing.Point(3, 3);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(120, 38);
            this.yesButton.TabIndex = 0;
            this.yesButton.Text = "yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Location = new System.Drawing.Point(241, 3);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(120, 38);
            this.noButton.TabIndex = 1;
            this.noButton.Text = "no";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // deleteGameQuestionLabel
            // 
            this.deleteGameQuestionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteGameQuestionLabel.AutoSize = true;
            this.deleteGameQuestionLabel.Location = new System.Drawing.Point(169, 72);
            this.deleteGameQuestionLabel.Name = "deleteGameQuestionLabel";
            this.deleteGameQuestionLabel.Size = new System.Drawing.Size(72, 19);
            this.deleteGameQuestionLabel.TabIndex = 1;
            this.deleteGameQuestionLabel.Text = "delete?";
            // 
            // DeleteGamePromptPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 213);
            this.Controls.Add(this.promptPanel);
            this.Name = "DeleteGamePromptPopup";
            this.Text = "DeleteGamePromptPopup";
            this.promptPanel.ResumeLayout(false);
            this.promptPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel promptPanel;
        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label deleteGameQuestionLabel;
    }
}