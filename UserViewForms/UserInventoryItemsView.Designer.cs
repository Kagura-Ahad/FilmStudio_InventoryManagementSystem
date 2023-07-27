namespace FilmStudio_InventoryManagementSystem.UserViewForms
{
    partial class UserInventoryItemsView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.available_inventory_items_header = new System.Windows.Forms.Label();
            this.available_inventory_items_grid_view = new System.Windows.Forms.DataGridView();
            this.selected_inventory_item_number_text_box = new System.Windows.Forms.TextBox();
            this.selected_inventory_item_number_label = new System.Windows.Forms.Label();
            this.add_to_cart_button = new System.Windows.Forms.Button();
            this.quantity_label = new System.Windows.Forms.Label();
            this.quantity_text_box = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.available_inventory_items_grid_view)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.available_inventory_items_grid_view);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(254, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 331);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // available_inventory_items_header
            // 
            this.available_inventory_items_header.AutoSize = true;
            this.available_inventory_items_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available_inventory_items_header.Location = new System.Drawing.Point(16, 9);
            this.available_inventory_items_header.Name = "available_inventory_items_header";
            this.available_inventory_items_header.Size = new System.Drawing.Size(256, 26);
            this.available_inventory_items_header.TabIndex = 5;
            this.available_inventory_items_header.Text = "Available Inventory Items";
            // 
            // available_inventory_items_grid_view
            // 
            this.available_inventory_items_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.available_inventory_items_grid_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.available_inventory_items_grid_view.Location = new System.Drawing.Point(0, 0);
            this.available_inventory_items_grid_view.Name = "available_inventory_items_grid_view";
            this.available_inventory_items_grid_view.Size = new System.Drawing.Size(300, 331);
            this.available_inventory_items_grid_view.TabIndex = 1;
            // 
            // selected_inventory_item_number_text_box
            // 
            this.selected_inventory_item_number_text_box.Location = new System.Drawing.Point(166, 138);
            this.selected_inventory_item_number_text_box.Name = "selected_inventory_item_number_text_box";
            this.selected_inventory_item_number_text_box.Size = new System.Drawing.Size(100, 20);
            this.selected_inventory_item_number_text_box.TabIndex = 2;
            // 
            // selected_inventory_item_number_label
            // 
            this.selected_inventory_item_number_label.AutoSize = true;
            this.selected_inventory_item_number_label.Location = new System.Drawing.Point(-2, 141);
            this.selected_inventory_item_number_label.Name = "selected_inventory_item_number_label";
            this.selected_inventory_item_number_label.Size = new System.Drawing.Size(162, 13);
            this.selected_inventory_item_number_label.TabIndex = 3;
            this.selected_inventory_item_number_label.Text = "Selected Inventory Item Number:";
            // 
            // add_to_cart_button
            // 
            this.add_to_cart_button.Location = new System.Drawing.Point(166, 190);
            this.add_to_cart_button.Name = "add_to_cart_button";
            this.add_to_cart_button.Size = new System.Drawing.Size(100, 44);
            this.add_to_cart_button.TabIndex = 4;
            this.add_to_cart_button.Text = "Add to cart";
            this.add_to_cart_button.UseVisualStyleBackColor = true;
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Location = new System.Drawing.Point(111, 167);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(49, 13);
            this.quantity_label.TabIndex = 6;
            this.quantity_label.Text = "Quantity:";
            // 
            // quantity_text_box
            // 
            this.quantity_text_box.Location = new System.Drawing.Point(166, 164);
            this.quantity_text_box.Name = "quantity_text_box";
            this.quantity_text_box.Size = new System.Drawing.Size(100, 20);
            this.quantity_text_box.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.available_inventory_items_header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 46);
            this.panel2.TabIndex = 6;
            // 
            // UserInventoryItemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 331);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.quantity_text_box);
            this.Controls.Add(this.add_to_cart_button);
            this.Controls.Add(this.selected_inventory_item_number_label);
            this.Controls.Add(this.selected_inventory_item_number_text_box);
            this.Controls.Add(this.panel1);
            this.Name = "UserInventoryItemsView";
            this.Text = "UserInventoryItemsView";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.available_inventory_items_grid_view)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox selected_inventory_item_number_text_box;
        private System.Windows.Forms.Label available_inventory_items_header;
        private System.Windows.Forms.Label selected_inventory_item_number_label;
        private System.Windows.Forms.Button add_to_cart_button;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.TextBox quantity_text_box;
        private System.Windows.Forms.DataGridView available_inventory_items_grid_view;
        private System.Windows.Forms.Panel panel2;
    }
}