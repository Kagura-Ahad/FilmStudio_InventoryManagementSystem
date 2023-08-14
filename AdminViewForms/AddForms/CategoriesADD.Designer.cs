namespace FilmStudio_InventoryManagementSystem.AdminViewForms.AddForms
{
    partial class CategoriesADD
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
            this.add_category_button = new System.Windows.Forms.Button();
            this.category_name_textBox = new System.Windows.Forms.TextBox();
            this.category_name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_category_button
            // 
            this.add_category_button.Location = new System.Drawing.Point(381, 220);
            this.add_category_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_category_button.Name = "add_category_button";
            this.add_category_button.Size = new System.Drawing.Size(75, 23);
            this.add_category_button.TabIndex = 8;
            this.add_category_button.Text = "Add Category";
            this.add_category_button.UseVisualStyleBackColor = true;
            // 
            // category_name_textBox
            // 
            this.category_name_textBox.Location = new System.Drawing.Point(381, 180);
            this.category_name_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.category_name_textBox.Name = "category_name_textBox";
            this.category_name_textBox.Size = new System.Drawing.Size(76, 20);
            this.category_name_textBox.TabIndex = 7;
            // 
            // category_name_label
            // 
            this.category_name_label.AutoSize = true;
            this.category_name_label.Location = new System.Drawing.Point(298, 183);
            this.category_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.category_name_label.Name = "category_name_label";
            this.category_name_label.Size = new System.Drawing.Size(83, 13);
            this.category_name_label.TabIndex = 6;
            this.category_name_label.Text = "Category Name:";
            // 
            // CategoriesADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_category_button);
            this.Controls.Add(this.category_name_textBox);
            this.Controls.Add(this.category_name_label);
            this.Name = "CategoriesADD";
            this.Text = "CategoriesADD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_category_button;
        private System.Windows.Forms.TextBox category_name_textBox;
        private System.Windows.Forms.Label category_name_label;
    }
}