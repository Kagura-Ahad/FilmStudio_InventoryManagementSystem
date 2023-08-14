namespace FilmStudio_InventoryManagementSystem.AdminViewForms.AddForms
{
    partial class InventoryItemADD
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
            this.quantity_textBox = new System.Windows.Forms.TextBox();
            this.category_comboBox = new System.Windows.Forms.ComboBox();
            this.description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.quantity_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.add_inventory_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quantity_textBox
            // 
            this.quantity_textBox.Location = new System.Drawing.Point(373, 142);
            this.quantity_textBox.Name = "quantity_textBox";
            this.quantity_textBox.Size = new System.Drawing.Size(131, 20);
            this.quantity_textBox.TabIndex = 19;
            // 
            // category_comboBox
            // 
            this.category_comboBox.FormattingEnabled = true;
            this.category_comboBox.Location = new System.Drawing.Point(373, 115);
            this.category_comboBox.Name = "category_comboBox";
            this.category_comboBox.Size = new System.Drawing.Size(131, 21);
            this.category_comboBox.TabIndex = 18;
            // 
            // description_richTextBox
            // 
            this.description_richTextBox.Location = new System.Drawing.Point(373, 168);
            this.description_richTextBox.Name = "description_richTextBox";
            this.description_richTextBox.Size = new System.Drawing.Size(131, 121);
            this.description_richTextBox.TabIndex = 17;
            this.description_richTextBox.Text = "";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(373, 89);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(131, 20);
            this.name_textBox.TabIndex = 16;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Location = new System.Drawing.Point(297, 171);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(63, 13);
            this.description_label.TabIndex = 15;
            this.description_label.Text = "Description:";
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Location = new System.Drawing.Point(297, 145);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(49, 13);
            this.quantity_label.TabIndex = 14;
            this.quantity_label.Text = "Quantity:";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Location = new System.Drawing.Point(297, 118);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(52, 13);
            this.category_label.TabIndex = 13;
            this.category_label.Text = "Category:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(297, 92);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(38, 13);
            this.name_label.TabIndex = 12;
            this.name_label.Text = "Name:";
            // 
            // add_inventory_button
            // 
            this.add_inventory_button.Location = new System.Drawing.Point(389, 319);
            this.add_inventory_button.Name = "add_inventory_button";
            this.add_inventory_button.Size = new System.Drawing.Size(94, 42);
            this.add_inventory_button.TabIndex = 11;
            this.add_inventory_button.Text = "Add";
            this.add_inventory_button.UseVisualStyleBackColor = true;
            // 
            // InventoryItemADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quantity_textBox);
            this.Controls.Add(this.category_comboBox);
            this.Controls.Add(this.description_richTextBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.add_inventory_button);
            this.Name = "InventoryItemADD";
            this.Text = "InventoryItemADD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox quantity_textBox;
        private System.Windows.Forms.ComboBox category_comboBox;
        private System.Windows.Forms.RichTextBox description_richTextBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button add_inventory_button;
    }
}