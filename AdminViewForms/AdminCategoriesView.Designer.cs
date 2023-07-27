namespace FilmStudio_InventoryManagementSystem.AdminViewForms
{
    partial class AdminCategoriesView
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
            this.delete_categories_button = new System.Windows.Forms.Button();
            this.edit_categories_button = new System.Windows.Forms.Button();
            this.add_categories_button = new System.Windows.Forms.Button();
            this.categories_grid_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.categories_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_categories_button
            // 
            this.delete_categories_button.Location = new System.Drawing.Point(329, 39);
            this.delete_categories_button.Name = "delete_categories_button";
            this.delete_categories_button.Size = new System.Drawing.Size(85, 50);
            this.delete_categories_button.TabIndex = 16;
            this.delete_categories_button.Text = "Delete Categories";
            this.delete_categories_button.UseVisualStyleBackColor = true;
            // 
            // edit_categories_button
            // 
            this.edit_categories_button.Location = new System.Drawing.Point(238, 39);
            this.edit_categories_button.Name = "edit_categories_button";
            this.edit_categories_button.Size = new System.Drawing.Size(85, 50);
            this.edit_categories_button.TabIndex = 15;
            this.edit_categories_button.Text = "Edit Categories";
            this.edit_categories_button.UseVisualStyleBackColor = true;
            // 
            // add_categories_button
            // 
            this.add_categories_button.Location = new System.Drawing.Point(147, 39);
            this.add_categories_button.Name = "add_categories_button";
            this.add_categories_button.Size = new System.Drawing.Size(85, 50);
            this.add_categories_button.TabIndex = 14;
            this.add_categories_button.Text = "Add Categories";
            this.add_categories_button.UseVisualStyleBackColor = true;
            // 
            // categories_grid_view
            // 
            this.categories_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categories_grid_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categories_grid_view.Location = new System.Drawing.Point(0, 131);
            this.categories_grid_view.Name = "categories_grid_view";
            this.categories_grid_view.Size = new System.Drawing.Size(554, 200);
            this.categories_grid_view.TabIndex = 13;
            // 
            // AdminCategoriesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 331);
            this.Controls.Add(this.delete_categories_button);
            this.Controls.Add(this.edit_categories_button);
            this.Controls.Add(this.add_categories_button);
            this.Controls.Add(this.categories_grid_view);
            this.Name = "AdminCategoriesView";
            this.Text = "AdminCategoriesView";
            ((System.ComponentModel.ISupportInitialize)(this.categories_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delete_categories_button;
        private System.Windows.Forms.Button edit_categories_button;
        private System.Windows.Forms.Button add_categories_button;
        private System.Windows.Forms.DataGridView categories_grid_view;
    }
}