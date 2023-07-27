namespace FilmStudio_InventoryManagementSystem.AdminViewForms
{
    partial class AdminInventoryItemsView
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
            this.delete_inventory_items_button = new System.Windows.Forms.Button();
            this.update_inventory_items_button = new System.Windows.Forms.Button();
            this.add_inventory_items_button = new System.Windows.Forms.Button();
            this.inventory_group_box = new System.Windows.Forms.GroupBox();
            this.checked_out_inventory_items_radio_button = new System.Windows.Forms.RadioButton();
            this.available_inventory_items_radio_button = new System.Windows.Forms.RadioButton();
            this.all_inventory_items_radio_button = new System.Windows.Forms.RadioButton();
            this.inventory_items_grid_view = new System.Windows.Forms.DataGridView();
            this.inventory_group_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_items_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_inventory_items_button
            // 
            this.delete_inventory_items_button.Location = new System.Drawing.Point(332, 112);
            this.delete_inventory_items_button.Name = "delete_inventory_items_button";
            this.delete_inventory_items_button.Size = new System.Drawing.Size(93, 46);
            this.delete_inventory_items_button.TabIndex = 12;
            this.delete_inventory_items_button.Text = "Delete Inventory Items";
            this.delete_inventory_items_button.UseVisualStyleBackColor = true;
            // 
            // update_inventory_items_button
            // 
            this.update_inventory_items_button.Location = new System.Drawing.Point(233, 112);
            this.update_inventory_items_button.Name = "update_inventory_items_button";
            this.update_inventory_items_button.Size = new System.Drawing.Size(93, 46);
            this.update_inventory_items_button.TabIndex = 11;
            this.update_inventory_items_button.Text = "Update Inventory Items";
            this.update_inventory_items_button.UseVisualStyleBackColor = true;
            // 
            // add_inventory_items_button
            // 
            this.add_inventory_items_button.Location = new System.Drawing.Point(134, 112);
            this.add_inventory_items_button.Name = "add_inventory_items_button";
            this.add_inventory_items_button.Size = new System.Drawing.Size(93, 46);
            this.add_inventory_items_button.TabIndex = 10;
            this.add_inventory_items_button.Text = "Add Inventory Items";
            this.add_inventory_items_button.UseVisualStyleBackColor = true;
            // 
            // inventory_group_box
            // 
            this.inventory_group_box.Controls.Add(this.checked_out_inventory_items_radio_button);
            this.inventory_group_box.Controls.Add(this.available_inventory_items_radio_button);
            this.inventory_group_box.Controls.Add(this.all_inventory_items_radio_button);
            this.inventory_group_box.Location = new System.Drawing.Point(166, 12);
            this.inventory_group_box.Name = "inventory_group_box";
            this.inventory_group_box.Size = new System.Drawing.Size(200, 85);
            this.inventory_group_box.TabIndex = 9;
            this.inventory_group_box.TabStop = false;
            this.inventory_group_box.Text = "Inventory View";
            // 
            // checked_out_inventory_items_radio_button
            // 
            this.checked_out_inventory_items_radio_button.AutoSize = true;
            this.checked_out_inventory_items_radio_button.Location = new System.Drawing.Point(6, 40);
            this.checked_out_inventory_items_radio_button.Name = "checked_out_inventory_items_radio_button";
            this.checked_out_inventory_items_radio_button.Size = new System.Drawing.Size(163, 17);
            this.checked_out_inventory_items_radio_button.TabIndex = 2;
            this.checked_out_inventory_items_radio_button.TabStop = true;
            this.checked_out_inventory_items_radio_button.Text = "Checked Out Inventory Items";
            this.checked_out_inventory_items_radio_button.UseVisualStyleBackColor = true;
            // 
            // available_inventory_items_radio_button
            // 
            this.available_inventory_items_radio_button.AutoSize = true;
            this.available_inventory_items_radio_button.Location = new System.Drawing.Point(6, 63);
            this.available_inventory_items_radio_button.Name = "available_inventory_items_radio_button";
            this.available_inventory_items_radio_button.Size = new System.Drawing.Size(143, 17);
            this.available_inventory_items_radio_button.TabIndex = 3;
            this.available_inventory_items_radio_button.TabStop = true;
            this.available_inventory_items_radio_button.Text = "Available Inventory Items";
            this.available_inventory_items_radio_button.UseVisualStyleBackColor = true;
            // 
            // all_inventory_items_radio_button
            // 
            this.all_inventory_items_radio_button.AutoSize = true;
            this.all_inventory_items_radio_button.Location = new System.Drawing.Point(6, 19);
            this.all_inventory_items_radio_button.Name = "all_inventory_items_radio_button";
            this.all_inventory_items_radio_button.Size = new System.Drawing.Size(111, 17);
            this.all_inventory_items_radio_button.TabIndex = 1;
            this.all_inventory_items_radio_button.TabStop = true;
            this.all_inventory_items_radio_button.Text = "All Inventory Items";
            this.all_inventory_items_radio_button.UseVisualStyleBackColor = true;
            // 
            // inventory_items_grid_view
            // 
            this.inventory_items_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory_items_grid_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inventory_items_grid_view.Location = new System.Drawing.Point(0, 131);
            this.inventory_items_grid_view.Name = "inventory_items_grid_view";
            this.inventory_items_grid_view.Size = new System.Drawing.Size(554, 200);
            this.inventory_items_grid_view.TabIndex = 8;
            // 
            // AdminInventoryItemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 331);
            this.Controls.Add(this.delete_inventory_items_button);
            this.Controls.Add(this.update_inventory_items_button);
            this.Controls.Add(this.add_inventory_items_button);
            this.Controls.Add(this.inventory_group_box);
            this.Controls.Add(this.inventory_items_grid_view);
            this.Name = "AdminInventoryItemsView";
            this.Text = "AdminInventoryItemsView";
            this.inventory_group_box.ResumeLayout(false);
            this.inventory_group_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_items_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delete_inventory_items_button;
        private System.Windows.Forms.Button update_inventory_items_button;
        private System.Windows.Forms.Button add_inventory_items_button;
        private System.Windows.Forms.GroupBox inventory_group_box;
        private System.Windows.Forms.RadioButton checked_out_inventory_items_radio_button;
        private System.Windows.Forms.RadioButton available_inventory_items_radio_button;
        private System.Windows.Forms.RadioButton all_inventory_items_radio_button;
        private System.Windows.Forms.DataGridView inventory_items_grid_view;
    }
}