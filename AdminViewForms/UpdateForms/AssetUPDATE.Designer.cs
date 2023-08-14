namespace FilmStudio_InventoryManagementSystem.AdminViewForms.UpdateForms
{
    partial class AssetUPDATE
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
            this.update_button = new System.Windows.Forms.Button();
            this.description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.category_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(377, 312);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(139, 40);
            this.update_button.TabIndex = 15;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            // 
            // description_richTextBox
            // 
            this.description_richTextBox.Location = new System.Drawing.Point(377, 151);
            this.description_richTextBox.Name = "description_richTextBox";
            this.description_richTextBox.Size = new System.Drawing.Size(139, 146);
            this.description_richTextBox.TabIndex = 14;
            this.description_richTextBox.Text = "";
            // 
            // category_textBox
            // 
            this.category_textBox.Location = new System.Drawing.Point(377, 125);
            this.category_textBox.Name = "category_textBox";
            this.category_textBox.Size = new System.Drawing.Size(139, 20);
            this.category_textBox.TabIndex = 13;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(377, 99);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(139, 20);
            this.name_textBox.TabIndex = 12;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(285, 151);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(83, 17);
            this.description_label.TabIndex = 11;
            this.description_label.Text = "Description:";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_label.Location = new System.Drawing.Point(285, 126);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(69, 17);
            this.category_label.TabIndex = 10;
            this.category_label.Text = "Category:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(285, 100);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 9;
            this.name_label.Text = "Name:";
            // 
            // AssetUPDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.description_richTextBox);
            this.Controls.Add(this.category_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.name_label);
            this.Name = "AssetUPDATE";
            this.Text = "AssetUPDATE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.RichTextBox description_richTextBox;
        private System.Windows.Forms.TextBox category_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label name_label;
    }
}