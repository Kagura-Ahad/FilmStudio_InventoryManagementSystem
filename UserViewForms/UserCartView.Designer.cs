namespace FilmStudio_InventoryManagementSystem.UserViewForms
{
    partial class UserCartView
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
            this.cart_header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cart_inventory_items_grid_view = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cart_inventory_items_header = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cart_asset_items_grid_view = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cart_asset_items_header = new System.Windows.Forms.Label();
            this.issue_date_label = new System.Windows.Forms.Label();
            this.return_date_label = new System.Windows.Forms.Label();
            this.selected_cart_number_label = new System.Windows.Forms.Label();
            this.issue_date_combo_box = new System.Windows.Forms.ComboBox();
            this.return_date_combo_box = new System.Windows.Forms.ComboBox();
            this.selected_cart_number_text_box = new System.Windows.Forms.TextBox();
            this.checkout_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart_inventory_items_grid_view)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart_asset_items_grid_view)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cart_header);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(395, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 450);
            this.panel1.TabIndex = 1;
            // 
            // cart_header
            // 
            this.cart_header.AutoSize = true;
            this.cart_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart_header.Location = new System.Drawing.Point(156, 9);
            this.cart_header.Name = "cart_header";
            this.cart_header.Size = new System.Drawing.Size(106, 26);
            this.cart_header.TabIndex = 5;
            this.cart_header.Text = "Your Cart";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 404);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cart_inventory_items_grid_view);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 218);
            this.panel4.TabIndex = 1;
            // 
            // cart_inventory_items_grid_view
            // 
            this.cart_inventory_items_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart_inventory_items_grid_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cart_inventory_items_grid_view.Location = new System.Drawing.Point(0, 30);
            this.cart_inventory_items_grid_view.Name = "cart_inventory_items_grid_view";
            this.cart_inventory_items_grid_view.Size = new System.Drawing.Size(405, 188);
            this.cart_inventory_items_grid_view.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.cart_inventory_items_header);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(405, 30);
            this.panel6.TabIndex = 0;
            // 
            // cart_inventory_items_header
            // 
            this.cart_inventory_items_header.AutoSize = true;
            this.cart_inventory_items_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart_inventory_items_header.Location = new System.Drawing.Point(144, 6);
            this.cart_inventory_items_header.Name = "cart_inventory_items_header";
            this.cart_inventory_items_header.Size = new System.Drawing.Size(118, 20);
            this.cart_inventory_items_header.TabIndex = 0;
            this.cart_inventory_items_header.Text = "Inventory Items";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cart_asset_items_grid_view);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 186);
            this.panel3.TabIndex = 0;
            // 
            // cart_asset_items_grid_view
            // 
            this.cart_asset_items_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart_asset_items_grid_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cart_asset_items_grid_view.Location = new System.Drawing.Point(0, 30);
            this.cart_asset_items_grid_view.Name = "cart_asset_items_grid_view";
            this.cart_asset_items_grid_view.Size = new System.Drawing.Size(405, 156);
            this.cart_asset_items_grid_view.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.cart_asset_items_header);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(405, 30);
            this.panel5.TabIndex = 7;
            // 
            // cart_asset_items_header
            // 
            this.cart_asset_items_header.AutoSize = true;
            this.cart_asset_items_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart_asset_items_header.Location = new System.Drawing.Point(178, 7);
            this.cart_asset_items_header.Name = "cart_asset_items_header";
            this.cart_asset_items_header.Size = new System.Drawing.Size(58, 20);
            this.cart_asset_items_header.TabIndex = 0;
            this.cart_asset_items_header.Text = "Assets";
            // 
            // issue_date_label
            // 
            this.issue_date_label.AutoSize = true;
            this.issue_date_label.Location = new System.Drawing.Point(142, 156);
            this.issue_date_label.Name = "issue_date_label";
            this.issue_date_label.Size = new System.Drawing.Size(61, 13);
            this.issue_date_label.TabIndex = 2;
            this.issue_date_label.Text = "Issue Date:";
            // 
            // return_date_label
            // 
            this.return_date_label.AutoSize = true;
            this.return_date_label.Location = new System.Drawing.Point(136, 184);
            this.return_date_label.Name = "return_date_label";
            this.return_date_label.Size = new System.Drawing.Size(68, 13);
            this.return_date_label.TabIndex = 3;
            this.return_date_label.Text = "Return Date:";
            // 
            // selected_cart_number_label
            // 
            this.selected_cart_number_label.AutoSize = true;
            this.selected_cart_number_label.Location = new System.Drawing.Point(90, 215);
            this.selected_cart_number_label.Name = "selected_cart_number_label";
            this.selected_cart_number_label.Size = new System.Drawing.Size(114, 13);
            this.selected_cart_number_label.TabIndex = 4;
            this.selected_cart_number_label.Text = "Selected Cart Number:";
            // 
            // issue_date_combo_box
            // 
            this.issue_date_combo_box.FormattingEnabled = true;
            this.issue_date_combo_box.Location = new System.Drawing.Point(209, 153);
            this.issue_date_combo_box.Name = "issue_date_combo_box";
            this.issue_date_combo_box.Size = new System.Drawing.Size(122, 21);
            this.issue_date_combo_box.TabIndex = 5;
            // 
            // return_date_combo_box
            // 
            this.return_date_combo_box.FormattingEnabled = true;
            this.return_date_combo_box.Location = new System.Drawing.Point(210, 181);
            this.return_date_combo_box.Name = "return_date_combo_box";
            this.return_date_combo_box.Size = new System.Drawing.Size(121, 21);
            this.return_date_combo_box.TabIndex = 6;
            // 
            // selected_cart_number_text_box
            // 
            this.selected_cart_number_text_box.Location = new System.Drawing.Point(210, 212);
            this.selected_cart_number_text_box.Name = "selected_cart_number_text_box";
            this.selected_cart_number_text_box.Size = new System.Drawing.Size(121, 20);
            this.selected_cart_number_text_box.TabIndex = 7;
            // 
            // checkout_button
            // 
            this.checkout_button.Location = new System.Drawing.Point(210, 238);
            this.checkout_button.Name = "checkout_button";
            this.checkout_button.Size = new System.Drawing.Size(121, 44);
            this.checkout_button.TabIndex = 8;
            this.checkout_button.Text = "Checkout";
            this.checkout_button.UseVisualStyleBackColor = true;
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(210, 288);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(121, 44);
            this.refresh_button.TabIndex = 9;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            // 
            // UserCartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.checkout_button);
            this.Controls.Add(this.selected_cart_number_text_box);
            this.Controls.Add(this.return_date_combo_box);
            this.Controls.Add(this.issue_date_combo_box);
            this.Controls.Add(this.selected_cart_number_label);
            this.Controls.Add(this.return_date_label);
            this.Controls.Add(this.issue_date_label);
            this.Controls.Add(this.panel1);
            this.Name = "UserCartView";
            this.Text = "UserCartView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cart_inventory_items_grid_view)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cart_asset_items_grid_view)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cart_header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView cart_inventory_items_grid_view;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView cart_asset_items_grid_view;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label issue_date_label;
        private System.Windows.Forms.Label return_date_label;
        private System.Windows.Forms.Label selected_cart_number_label;
        private System.Windows.Forms.ComboBox issue_date_combo_box;
        private System.Windows.Forms.ComboBox return_date_combo_box;
        private System.Windows.Forms.TextBox selected_cart_number_text_box;
        private System.Windows.Forms.Button checkout_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Label cart_inventory_items_header;
        private System.Windows.Forms.Label cart_asset_items_header;
    }
}