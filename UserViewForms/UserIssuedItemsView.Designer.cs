namespace FilmStudio_InventoryManagementSystem.UserViewForms
{
    partial class UserIssuedItemsView
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
            this.issued_inventory_items_grid_view = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.issued_inventory_items_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.issued_assets_grid_view = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.issued_assets_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issued_inventory_items_grid_view)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issued_assets_grid_view)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.issued_inventory_items_grid_view);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 331);
            this.panel1.TabIndex = 0;
            // 
            // issued_inventory_items_grid_view
            // 
            this.issued_inventory_items_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issued_inventory_items_grid_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issued_inventory_items_grid_view.Location = new System.Drawing.Point(0, 50);
            this.issued_inventory_items_grid_view.Name = "issued_inventory_items_grid_view";
            this.issued_inventory_items_grid_view.Size = new System.Drawing.Size(250, 281);
            this.issued_inventory_items_grid_view.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.issued_inventory_items_label);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 50);
            this.panel3.TabIndex = 0;
            // 
            // issued_inventory_items_label
            // 
            this.issued_inventory_items_label.AutoSize = true;
            this.issued_inventory_items_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issued_inventory_items_label.Location = new System.Drawing.Point(12, 9);
            this.issued_inventory_items_label.Name = "issued_inventory_items_label";
            this.issued_inventory_items_label.Size = new System.Drawing.Size(231, 26);
            this.issued_inventory_items_label.TabIndex = 0;
            this.issued_inventory_items_label.Text = "Issued Inventory Items";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.issued_assets_grid_view);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(304, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 331);
            this.panel2.TabIndex = 1;
            // 
            // issued_assets_grid_view
            // 
            this.issued_assets_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issued_assets_grid_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issued_assets_grid_view.Location = new System.Drawing.Point(0, 50);
            this.issued_assets_grid_view.Name = "issued_assets_grid_view";
            this.issued_assets_grid_view.Size = new System.Drawing.Size(250, 281);
            this.issued_assets_grid_view.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.issued_assets_label);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 50);
            this.panel4.TabIndex = 1;
            // 
            // issued_assets_label
            // 
            this.issued_assets_label.AutoSize = true;
            this.issued_assets_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issued_assets_label.Location = new System.Drawing.Point(51, 9);
            this.issued_assets_label.Name = "issued_assets_label";
            this.issued_assets_label.Size = new System.Drawing.Size(148, 26);
            this.issued_assets_label.TabIndex = 1;
            this.issued_assets_label.Text = "Issued Assets";
            // 
            // UserIssuedItemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 331);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserIssuedItemsView";
            this.Text = "UserIssuedItemsView";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.issued_inventory_items_grid_view)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.issued_assets_grid_view)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView issued_inventory_items_grid_view;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label issued_inventory_items_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label issued_assets_label;
        private System.Windows.Forms.DataGridView issued_assets_grid_view;
    }
}