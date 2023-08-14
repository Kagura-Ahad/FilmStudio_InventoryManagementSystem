namespace FilmStudio_InventoryManagementSystem.AdminViewForms.UpdateForms
{
    partial class CategoriesUPDATE
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
            this.category_textBox = new System.Windows.Forms.TextBox();
            this.update_category_button = new System.Windows.Forms.Button();
            this.category_name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // category_textBox
            // 
            this.category_textBox.Location = new System.Drawing.Point(375, 178);
            this.category_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.category_textBox.Name = "category_textBox";
            this.category_textBox.Size = new System.Drawing.Size(92, 20);
            this.category_textBox.TabIndex = 15;
            // 
            // update_category_button
            // 
            this.update_category_button.Location = new System.Drawing.Point(375, 202);
            this.update_category_button.Margin = new System.Windows.Forms.Padding(2);
            this.update_category_button.Name = "update_category_button";
            this.update_category_button.Size = new System.Drawing.Size(91, 37);
            this.update_category_button.TabIndex = 14;
            this.update_category_button.Text = "Update Category";
            this.update_category_button.UseVisualStyleBackColor = true;
            // 
            // category_name_label
            // 
            this.category_name_label.AutoSize = true;
            this.category_name_label.Location = new System.Drawing.Point(291, 180);
            this.category_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.category_name_label.Name = "category_name_label";
            this.category_name_label.Size = new System.Drawing.Size(83, 13);
            this.category_name_label.TabIndex = 13;
            this.category_name_label.Text = "Category Name:";
            // 
            // CategoriesUPDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.category_textBox);
            this.Controls.Add(this.update_category_button);
            this.Controls.Add(this.category_name_label);
            this.Name = "CategoriesUPDATE";
            this.Text = "CategoriesUPDATE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox category_textBox;
        private System.Windows.Forms.Button update_category_button;
        private System.Windows.Forms.Label category_name_label;
    }
}