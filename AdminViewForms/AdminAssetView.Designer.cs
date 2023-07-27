namespace FilmStudio_InventoryManagementSystem.AdminViewForms
{
    partial class AdminAssetView
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
            this.asset_grid_view = new System.Windows.Forms.DataGridView();
            this.all_assets_radio_button = new System.Windows.Forms.RadioButton();
            this.checked_out_assets_radio_button = new System.Windows.Forms.RadioButton();
            this.available_assets_radio_button = new System.Windows.Forms.RadioButton();
            this.asset_group_box = new System.Windows.Forms.GroupBox();
            this.add_assets_button = new System.Windows.Forms.Button();
            this.update_assets_button = new System.Windows.Forms.Button();
            this.delete_assets_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.asset_grid_view)).BeginInit();
            this.asset_group_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // asset_grid_view
            // 
            this.asset_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asset_grid_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.asset_grid_view.Location = new System.Drawing.Point(0, 131);
            this.asset_grid_view.Name = "asset_grid_view";
            this.asset_grid_view.Size = new System.Drawing.Size(554, 200);
            this.asset_grid_view.TabIndex = 0;
            // 
            // all_assets_radio_button
            // 
            this.all_assets_radio_button.AutoSize = true;
            this.all_assets_radio_button.Location = new System.Drawing.Point(6, 19);
            this.all_assets_radio_button.Name = "all_assets_radio_button";
            this.all_assets_radio_button.Size = new System.Drawing.Size(70, 17);
            this.all_assets_radio_button.TabIndex = 1;
            this.all_assets_radio_button.TabStop = true;
            this.all_assets_radio_button.Text = "All Assets";
            this.all_assets_radio_button.UseVisualStyleBackColor = true;
            this.all_assets_radio_button.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checked_out_assets_radio_button
            // 
            this.checked_out_assets_radio_button.AutoSize = true;
            this.checked_out_assets_radio_button.Location = new System.Drawing.Point(6, 40);
            this.checked_out_assets_radio_button.Name = "checked_out_assets_radio_button";
            this.checked_out_assets_radio_button.Size = new System.Drawing.Size(122, 17);
            this.checked_out_assets_radio_button.TabIndex = 2;
            this.checked_out_assets_radio_button.TabStop = true;
            this.checked_out_assets_radio_button.Text = "Checked Out Assets";
            this.checked_out_assets_radio_button.UseVisualStyleBackColor = true;
            this.checked_out_assets_radio_button.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // available_assets_radio_button
            // 
            this.available_assets_radio_button.AutoSize = true;
            this.available_assets_radio_button.Location = new System.Drawing.Point(6, 63);
            this.available_assets_radio_button.Name = "available_assets_radio_button";
            this.available_assets_radio_button.Size = new System.Drawing.Size(102, 17);
            this.available_assets_radio_button.TabIndex = 3;
            this.available_assets_radio_button.TabStop = true;
            this.available_assets_radio_button.Text = "Available Assets";
            this.available_assets_radio_button.UseVisualStyleBackColor = true;
            this.available_assets_radio_button.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // asset_group_box
            // 
            this.asset_group_box.Controls.Add(this.checked_out_assets_radio_button);
            this.asset_group_box.Controls.Add(this.available_assets_radio_button);
            this.asset_group_box.Controls.Add(this.all_assets_radio_button);
            this.asset_group_box.Location = new System.Drawing.Point(166, 12);
            this.asset_group_box.Name = "asset_group_box";
            this.asset_group_box.Size = new System.Drawing.Size(200, 85);
            this.asset_group_box.TabIndex = 4;
            this.asset_group_box.TabStop = false;
            this.asset_group_box.Text = "Asset View";
            // 
            // add_assets_button
            // 
            this.add_assets_button.Location = new System.Drawing.Point(134, 112);
            this.add_assets_button.Name = "add_assets_button";
            this.add_assets_button.Size = new System.Drawing.Size(93, 46);
            this.add_assets_button.TabIndex = 5;
            this.add_assets_button.Text = "Add Assets";
            this.add_assets_button.UseVisualStyleBackColor = true;
            // 
            // update_assets_button
            // 
            this.update_assets_button.Location = new System.Drawing.Point(233, 112);
            this.update_assets_button.Name = "update_assets_button";
            this.update_assets_button.Size = new System.Drawing.Size(93, 46);
            this.update_assets_button.TabIndex = 6;
            this.update_assets_button.Text = "Update Assets";
            this.update_assets_button.UseVisualStyleBackColor = true;
            // 
            // delete_assets_button
            // 
            this.delete_assets_button.Location = new System.Drawing.Point(332, 112);
            this.delete_assets_button.Name = "delete_assets_button";
            this.delete_assets_button.Size = new System.Drawing.Size(93, 46);
            this.delete_assets_button.TabIndex = 7;
            this.delete_assets_button.Text = "Delete Assets";
            this.delete_assets_button.UseVisualStyleBackColor = true;
            // 
            // AdminAssetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 331);
            this.Controls.Add(this.delete_assets_button);
            this.Controls.Add(this.update_assets_button);
            this.Controls.Add(this.add_assets_button);
            this.Controls.Add(this.asset_group_box);
            this.Controls.Add(this.asset_grid_view);
            this.Name = "AdminAssetView";
            this.Text = "AdminAssetView";
            ((System.ComponentModel.ISupportInitialize)(this.asset_grid_view)).EndInit();
            this.asset_group_box.ResumeLayout(false);
            this.asset_group_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView asset_grid_view;
        private System.Windows.Forms.RadioButton all_assets_radio_button;
        private System.Windows.Forms.RadioButton checked_out_assets_radio_button;
        private System.Windows.Forms.RadioButton available_assets_radio_button;
        private System.Windows.Forms.GroupBox asset_group_box;
        private System.Windows.Forms.Button add_assets_button;
        private System.Windows.Forms.Button update_assets_button;
        private System.Windows.Forms.Button delete_assets_button;
    }
}