
namespace PAPIClient.Views
{
    partial class StartView
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
            this.start_view_panel = new System.Windows.Forms.TableLayoutPanel();
            this.selection_label = new System.Windows.Forms.Label();
            this.return_button = new System.Windows.Forms.Button();
            this.button_panel = new System.Windows.Forms.TableLayoutPanel();
            this.building_selection_button = new System.Windows.Forms.Button();
            this.vehicle_selection_button = new System.Windows.Forms.Button();
            this.item_selection_button = new System.Windows.Forms.Button();
            this.character_selection_button = new System.Windows.Forms.Button();
            this.game_selection_button = new System.Windows.Forms.Button();
            this.description_panel = new System.Windows.Forms.TableLayoutPanel();
            this.description_label = new System.Windows.Forms.Label();
            this.selection_description_label = new System.Windows.Forms.Label();
            this.open_creator_button = new System.Windows.Forms.Button();
            this.start_view_panel.SuspendLayout();
            this.button_panel.SuspendLayout();
            this.description_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_view_panel
            // 
            this.start_view_panel.ColumnCount = 4;
            this.start_view_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.start_view_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.start_view_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.start_view_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.start_view_panel.Controls.Add(this.selection_label, 1, 1);
            this.start_view_panel.Controls.Add(this.return_button, 1, 3);
            this.start_view_panel.Controls.Add(this.button_panel, 1, 2);
            this.start_view_panel.Controls.Add(this.description_panel, 2, 2);
            this.start_view_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start_view_panel.Location = new System.Drawing.Point(0, 0);
            this.start_view_panel.Name = "start_view_panel";
            this.start_view_panel.RowCount = 5;
            this.start_view_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.start_view_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.start_view_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.start_view_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.start_view_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.start_view_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.start_view_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.start_view_panel.Size = new System.Drawing.Size(800, 450);
            this.start_view_panel.TabIndex = 0;
            // 
            // selection_label
            // 
            this.selection_label.AutoSize = true;
            this.selection_label.Location = new System.Drawing.Point(23, 20);
            this.selection_label.Name = "selection_label";
            this.selection_label.Size = new System.Drawing.Size(144, 19);
            this.selection_label.TabIndex = 0;
            this.selection_label.Text = "selection_label";
            // 
            // return_button
            // 
            this.return_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Location = new System.Drawing.Point(23, 385);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(200, 40);
            this.return_button.TabIndex = 1;
            this.return_button.Text = "return";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // button_panel
            // 
            this.button_panel.ColumnCount = 1;
            this.button_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.button_panel.Controls.Add(this.building_selection_button, 0, 4);
            this.button_panel.Controls.Add(this.vehicle_selection_button, 0, 3);
            this.button_panel.Controls.Add(this.item_selection_button, 0, 2);
            this.button_panel.Controls.Add(this.character_selection_button, 0, 1);
            this.button_panel.Controls.Add(this.game_selection_button, 0, 0);
            this.button_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_panel.Location = new System.Drawing.Point(23, 73);
            this.button_panel.Name = "button_panel";
            this.button_panel.RowCount = 6;
            this.button_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.button_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.button_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.button_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.button_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.button_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.button_panel.Size = new System.Drawing.Size(374, 304);
            this.button_panel.TabIndex = 3;
            // 
            // building_selection_button
            // 
            this.building_selection_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.building_selection_button.Location = new System.Drawing.Point(3, 227);
            this.building_selection_button.Name = "building_selection_button";
            this.building_selection_button.Size = new System.Drawing.Size(200, 40);
            this.building_selection_button.TabIndex = 4;
            this.building_selection_button.Text = "buildings";
            this.building_selection_button.UseVisualStyleBackColor = true;
            this.building_selection_button.Click += new System.EventHandler(this.building_selection_button_Click);
            // 
            // vehicle_selection_button
            // 
            this.vehicle_selection_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicle_selection_button.Location = new System.Drawing.Point(3, 171);
            this.vehicle_selection_button.Name = "vehicle_selection_button";
            this.vehicle_selection_button.Size = new System.Drawing.Size(200, 40);
            this.vehicle_selection_button.TabIndex = 3;
            this.vehicle_selection_button.Text = "vehicles";
            this.vehicle_selection_button.UseVisualStyleBackColor = true;
            this.vehicle_selection_button.Click += new System.EventHandler(this.vehicle_selection_button_Click);
            // 
            // item_selection_button
            // 
            this.item_selection_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_selection_button.Location = new System.Drawing.Point(3, 115);
            this.item_selection_button.Name = "item_selection_button";
            this.item_selection_button.Size = new System.Drawing.Size(200, 40);
            this.item_selection_button.TabIndex = 2;
            this.item_selection_button.Text = "items";
            this.item_selection_button.UseVisualStyleBackColor = true;
            this.item_selection_button.Click += new System.EventHandler(this.item_selection_button_Click);
            // 
            // character_selection_button
            // 
            this.character_selection_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.character_selection_button.Location = new System.Drawing.Point(3, 59);
            this.character_selection_button.Name = "character_selection_button";
            this.character_selection_button.Size = new System.Drawing.Size(200, 40);
            this.character_selection_button.TabIndex = 1;
            this.character_selection_button.Text = "characters";
            this.character_selection_button.UseVisualStyleBackColor = true;
            this.character_selection_button.Click += new System.EventHandler(this.character_selection_button_Click);
            // 
            // game_selection_button
            // 
            this.game_selection_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game_selection_button.Location = new System.Drawing.Point(3, 3);
            this.game_selection_button.Name = "game_selection_button";
            this.game_selection_button.Size = new System.Drawing.Size(200, 40);
            this.game_selection_button.TabIndex = 0;
            this.game_selection_button.Text = "games";
            this.game_selection_button.UseVisualStyleBackColor = true;
            this.game_selection_button.Click += new System.EventHandler(this.game_selection_button_Click);
            // 
            // description_panel
            // 
            this.description_panel.ColumnCount = 1;
            this.description_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.description_panel.Controls.Add(this.description_label, 0, 0);
            this.description_panel.Controls.Add(this.selection_description_label, 0, 1);
            this.description_panel.Controls.Add(this.open_creator_button, 0, 2);
            this.description_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.description_panel.Location = new System.Drawing.Point(403, 73);
            this.description_panel.Name = "description_panel";
            this.description_panel.RowCount = 3;
            this.description_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.description_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.description_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.description_panel.Size = new System.Drawing.Size(374, 304);
            this.description_panel.TabIndex = 4;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Location = new System.Drawing.Point(3, 0);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(108, 19);
            this.description_label.TabIndex = 2;
            this.description_label.Text = "description";
            // 
            // selection_description_label
            // 
            this.selection_description_label.AutoSize = true;
            this.selection_description_label.Location = new System.Drawing.Point(3, 50);
            this.selection_description_label.Name = "selection_description_label";
            this.selection_description_label.Size = new System.Drawing.Size(198, 19);
            this.selection_description_label.TabIndex = 3;
            this.selection_description_label.Text = "selection_description";
            // 
            // open_creator_button
            // 
            this.open_creator_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.open_creator_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_creator_button.Location = new System.Drawing.Point(171, 259);
            this.open_creator_button.Name = "open_creator_button";
            this.open_creator_button.Size = new System.Drawing.Size(200, 40);
            this.open_creator_button.TabIndex = 4;
            this.open_creator_button.Text = "open_creator";
            this.open_creator_button.UseVisualStyleBackColor = true;
            this.open_creator_button.Click += new System.EventHandler(this.open_creator_button_Click);
            // 
            // StartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start_view_panel);
            this.Name = "StartView";
            this.Text = "StartView";
            this.start_view_panel.ResumeLayout(false);
            this.start_view_panel.PerformLayout();
            this.button_panel.ResumeLayout(false);
            this.description_panel.ResumeLayout(false);
            this.description_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel start_view_panel;
        private System.Windows.Forms.Label selection_label;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.TableLayoutPanel button_panel;
        private System.Windows.Forms.Button building_selection_button;
        private System.Windows.Forms.Button vehicle_selection_button;
        private System.Windows.Forms.Button item_selection_button;
        private System.Windows.Forms.Button character_selection_button;
        private System.Windows.Forms.Button game_selection_button;
        private System.Windows.Forms.TableLayoutPanel description_panel;
        private System.Windows.Forms.Label selection_description_label;
        private System.Windows.Forms.Button open_creator_button;
    }
}