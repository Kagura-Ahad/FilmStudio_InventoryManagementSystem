namespace FilmStudio_InventoryManagementSystem.AdminViewForms.UpdateForms
{
    partial class MajorsUPDATE
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
            this.major_textBox = new System.Windows.Forms.TextBox();
            this.update_major_button = new System.Windows.Forms.Button();
            this.major_name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // major_textBox
            // 
            this.major_textBox.Location = new System.Drawing.Point(370, 146);
            this.major_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.major_textBox.Name = "major_textBox";
            this.major_textBox.Size = new System.Drawing.Size(92, 20);
            this.major_textBox.TabIndex = 11;
            // 
            // update_major_button
            // 
            this.update_major_button.Location = new System.Drawing.Point(370, 169);
            this.update_major_button.Margin = new System.Windows.Forms.Padding(2);
            this.update_major_button.Name = "update_major_button";
            this.update_major_button.Size = new System.Drawing.Size(92, 31);
            this.update_major_button.TabIndex = 10;
            this.update_major_button.Text = "Update Major";
            this.update_major_button.UseVisualStyleBackColor = true;
            // 
            // major_name_label
            // 
            this.major_name_label.AutoSize = true;
            this.major_name_label.Location = new System.Drawing.Point(302, 149);
            this.major_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.major_name_label.Name = "major_name_label";
            this.major_name_label.Size = new System.Drawing.Size(67, 13);
            this.major_name_label.TabIndex = 9;
            this.major_name_label.Text = "Major Name:";
            // 
            // MajorsUPDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.major_textBox);
            this.Controls.Add(this.update_major_button);
            this.Controls.Add(this.major_name_label);
            this.Name = "MajorsUPDATE";
            this.Text = "MajorsUPDATE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox major_textBox;
        private System.Windows.Forms.Button update_major_button;
        private System.Windows.Forms.Label major_name_label;
    }
}