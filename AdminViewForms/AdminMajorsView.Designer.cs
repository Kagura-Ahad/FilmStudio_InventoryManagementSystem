namespace FilmStudio_InventoryManagementSystem.AdminViewForms
{
    partial class AdminMajorsView
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
            this.delete_majors_button = new System.Windows.Forms.Button();
            this.edit_majors_button = new System.Windows.Forms.Button();
            this.add_majors_button = new System.Windows.Forms.Button();
            this.majors_grid_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.majors_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_majors_button
            // 
            this.delete_majors_button.Location = new System.Drawing.Point(329, 39);
            this.delete_majors_button.Name = "delete_majors_button";
            this.delete_majors_button.Size = new System.Drawing.Size(85, 50);
            this.delete_majors_button.TabIndex = 16;
            this.delete_majors_button.Text = "Delete Majors";
            this.delete_majors_button.UseVisualStyleBackColor = true;
            // 
            // edit_majors_button
            // 
            this.edit_majors_button.Location = new System.Drawing.Point(238, 39);
            this.edit_majors_button.Name = "edit_majors_button";
            this.edit_majors_button.Size = new System.Drawing.Size(85, 50);
            this.edit_majors_button.TabIndex = 15;
            this.edit_majors_button.Text = "Edit Majors";
            this.edit_majors_button.UseVisualStyleBackColor = true;
            // 
            // add_majors_button
            // 
            this.add_majors_button.Location = new System.Drawing.Point(147, 39);
            this.add_majors_button.Name = "add_majors_button";
            this.add_majors_button.Size = new System.Drawing.Size(85, 50);
            this.add_majors_button.TabIndex = 14;
            this.add_majors_button.Text = "Add Majors";
            this.add_majors_button.UseVisualStyleBackColor = true;
            // 
            // majors_grid_view
            // 
            this.majors_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.majors_grid_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.majors_grid_view.Location = new System.Drawing.Point(0, 131);
            this.majors_grid_view.Name = "majors_grid_view";
            this.majors_grid_view.Size = new System.Drawing.Size(554, 200);
            this.majors_grid_view.TabIndex = 13;
            // 
            // AdminMajorsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 331);
            this.Controls.Add(this.delete_majors_button);
            this.Controls.Add(this.edit_majors_button);
            this.Controls.Add(this.add_majors_button);
            this.Controls.Add(this.majors_grid_view);
            this.Name = "AdminMajorsView";
            this.Text = "AdminMajorsView";
            ((System.ComponentModel.ISupportInitialize)(this.majors_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delete_majors_button;
        private System.Windows.Forms.Button edit_majors_button;
        private System.Windows.Forms.Button add_majors_button;
        private System.Windows.Forms.DataGridView majors_grid_view;
    }
}