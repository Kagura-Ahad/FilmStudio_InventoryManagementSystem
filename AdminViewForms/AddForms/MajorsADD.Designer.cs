namespace FilmStudio_InventoryManagementSystem.AdminViewForms.AddForms
{
    partial class MajorsADD
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
            this.add_major_button = new System.Windows.Forms.Button();
            this.major_name_textBox = new System.Windows.Forms.TextBox();
            this.major_name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_major_button
            // 
            this.add_major_button.Location = new System.Drawing.Point(357, 207);
            this.add_major_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_major_button.Name = "add_major_button";
            this.add_major_button.Size = new System.Drawing.Size(75, 30);
            this.add_major_button.TabIndex = 5;
            this.add_major_button.Text = "Add Major";
            this.add_major_button.UseVisualStyleBackColor = true;
            // 
            // major_name_textBox
            // 
            this.major_name_textBox.Location = new System.Drawing.Point(357, 167);
            this.major_name_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.major_name_textBox.Name = "major_name_textBox";
            this.major_name_textBox.Size = new System.Drawing.Size(76, 20);
            this.major_name_textBox.TabIndex = 4;
            // 
            // major_name_label
            // 
            this.major_name_label.AutoSize = true;
            this.major_name_label.Location = new System.Drawing.Point(290, 167);
            this.major_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.major_name_label.Name = "major_name_label";
            this.major_name_label.Size = new System.Drawing.Size(67, 13);
            this.major_name_label.TabIndex = 3;
            this.major_name_label.Text = "Major Name:";
            // 
            // MajorsADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_major_button);
            this.Controls.Add(this.major_name_textBox);
            this.Controls.Add(this.major_name_label);
            this.Name = "MajorsADD";
            this.Text = "MajorsADD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_major_button;
        private System.Windows.Forms.TextBox major_name_textBox;
        private System.Windows.Forms.Label major_name_label;
    }
}