namespace FilmStudio_InventoryManagementSystem.UserViewForms
{
    partial class UserAssetsView
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.available_assets_grid_view = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.available_assets_header = new System.Windows.Forms.Label();
            this.add_to_cart_button = new System.Windows.Forms.Button();
            this.selected_asset_number_label = new System.Windows.Forms.Label();
            this.selected_asset_number_text_box = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.available_assets_grid_view)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(233, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 331);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.available_assets_grid_view);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 288);
            this.panel3.TabIndex = 2;
            // 
            // available_assets_grid_view
            // 
            this.available_assets_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.available_assets_grid_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.available_assets_grid_view.Location = new System.Drawing.Point(0, 0);
            this.available_assets_grid_view.Name = "available_assets_grid_view";
            this.available_assets_grid_view.Size = new System.Drawing.Size(321, 288);
            this.available_assets_grid_view.TabIndex = 0;
            this.available_assets_grid_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.available_assets_grid_view_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.available_assets_header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 43);
            this.panel2.TabIndex = 1;
            // 
            // available_assets_header
            // 
            this.available_assets_header.AutoSize = true;
            this.available_assets_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available_assets_header.Location = new System.Drawing.Point(80, 9);
            this.available_assets_header.Name = "available_assets_header";
            this.available_assets_header.Size = new System.Drawing.Size(173, 26);
            this.available_assets_header.TabIndex = 5;
            this.available_assets_header.Text = "Available Assets";
            // 
            // add_to_cart_button
            // 
            this.add_to_cart_button.Location = new System.Drawing.Point(127, 151);
            this.add_to_cart_button.Name = "add_to_cart_button";
            this.add_to_cart_button.Size = new System.Drawing.Size(100, 44);
            this.add_to_cart_button.TabIndex = 8;
            this.add_to_cart_button.Text = "Add to cart";
            this.add_to_cart_button.UseVisualStyleBackColor = true;
            this.add_to_cart_button.Click += new System.EventHandler(this.add_to_cart_button_Click);
            // 
            // selected_asset_number_label
            // 
            this.selected_asset_number_label.AutoSize = true;
            this.selected_asset_number_label.Location = new System.Drawing.Point(0, 128);
            this.selected_asset_number_label.Name = "selected_asset_number_label";
            this.selected_asset_number_label.Size = new System.Drawing.Size(121, 13);
            this.selected_asset_number_label.TabIndex = 7;
            this.selected_asset_number_label.Text = "Selected Asset Number:";
            // 
            // selected_asset_number_text_box
            // 
            this.selected_asset_number_text_box.Location = new System.Drawing.Point(127, 125);
            this.selected_asset_number_text_box.Name = "selected_asset_number_text_box";
            this.selected_asset_number_text_box.Size = new System.Drawing.Size(100, 20);
            this.selected_asset_number_text_box.TabIndex = 6;
            // 
            // UserAssetsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_to_cart_button);
            this.Controls.Add(this.selected_asset_number_label);
            this.Controls.Add(this.selected_asset_number_text_box);
            this.Name = "UserAssetsView";
            this.Text = "UserAssetsView";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.available_assets_grid_view)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label available_assets_header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button add_to_cart_button;
        private System.Windows.Forms.Label selected_asset_number_label;
        private System.Windows.Forms.TextBox selected_asset_number_text_box;
        private System.Windows.Forms.DataGridView available_assets_grid_view;
        private System.Windows.Forms.Panel panel3;
    }
}