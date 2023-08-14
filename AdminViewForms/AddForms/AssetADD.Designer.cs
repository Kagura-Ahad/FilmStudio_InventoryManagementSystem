namespace FilmStudio_InventoryManagementSystem.AdminViewForms.AddForms
{
    partial class AssetADD
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
            this.category_comboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // category_comboBox
            // 
            this.category_comboBox.FormattingEnabled = true;
            this.category_comboBox.Location = new System.Drawing.Point(378, 130);
            this.category_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.category_comboBox.Name = "category_comboBox";
            this.category_comboBox.Size = new System.Drawing.Size(132, 21);
            this.category_comboBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // description_richTextBox
            // 
            this.description_richTextBox.Location = new System.Drawing.Point(378, 183);
            this.description_richTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.description_richTextBox.Name = "description_richTextBox";
            this.description_richTextBox.Size = new System.Drawing.Size(132, 136);
            this.description_richTextBox.TabIndex = 14;
            this.description_richTextBox.Text = "";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(378, 87);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(132, 20);
            this.name_textBox.TabIndex = 13;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(291, 184);
            this.description_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(83, 17);
            this.description_label.TabIndex = 12;
            this.description_label.Text = "Description:";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_label.Location = new System.Drawing.Point(291, 133);
            this.category_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(69, 17);
            this.category_label.TabIndex = 11;
            this.category_label.Text = "Category:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(291, 87);
            this.name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 10;
            this.name_label.Text = "Name:";
            // 
            // AssetADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.category_comboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.description_richTextBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.name_label);
            this.Name = "AssetADD";
            this.Text = "AssetADD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox category_comboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox description_richTextBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label name_label;
    }
}