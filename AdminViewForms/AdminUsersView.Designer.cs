namespace FilmStudio_InventoryManagementSystem.AdminViewForms
{
    partial class AdminUsersView
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
            this.delete_user_button = new System.Windows.Forms.Button();
            this.edit_user_button = new System.Windows.Forms.Button();
            this.add_user_button = new System.Windows.Forms.Button();
            this.user_grid_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.user_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_user_button
            // 
            this.delete_user_button.Location = new System.Drawing.Point(634, 75);
            this.delete_user_button.Name = "delete_user_button";
            this.delete_user_button.Size = new System.Drawing.Size(93, 46);
            this.delete_user_button.TabIndex = 16;
            this.delete_user_button.Text = "Delete Users";
            this.delete_user_button.UseVisualStyleBackColor = true;
            // 
            // edit_user_button
            // 
            this.edit_user_button.Location = new System.Drawing.Point(356, 75);
            this.edit_user_button.Name = "edit_user_button";
            this.edit_user_button.Size = new System.Drawing.Size(93, 46);
            this.edit_user_button.TabIndex = 15;
            this.edit_user_button.Text = "Edit Users";
            this.edit_user_button.UseVisualStyleBackColor = true;
            // 
            // add_user_button
            // 
            this.add_user_button.Location = new System.Drawing.Point(72, 75);
            this.add_user_button.Name = "add_user_button";
            this.add_user_button.Size = new System.Drawing.Size(93, 46);
            this.add_user_button.TabIndex = 14;
            this.add_user_button.Text = "Add Users";
            this.add_user_button.UseVisualStyleBackColor = true;
            // 
            // user_grid_view
            // 
            this.user_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_grid_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.user_grid_view.Location = new System.Drawing.Point(0, 181);
            this.user_grid_view.Name = "user_grid_view";
            this.user_grid_view.Size = new System.Drawing.Size(800, 269);
            this.user_grid_view.TabIndex = 13;
            // 
            // AdminUsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_user_button);
            this.Controls.Add(this.edit_user_button);
            this.Controls.Add(this.add_user_button);
            this.Controls.Add(this.user_grid_view);
            this.Name = "AdminUsersView";
            this.Text = "AdminUsersView";
            ((System.ComponentModel.ISupportInitialize)(this.user_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delete_user_button;
        private System.Windows.Forms.Button edit_user_button;
        private System.Windows.Forms.Button add_user_button;
        private System.Windows.Forms.DataGridView user_grid_view;
    }
}