namespace FilmStudio_InventoryManagementSystem.AdminViewForms.UpdateForms
{
    partial class UsersUPDATE
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
            this.major_comboBox = new System.Windows.Forms.ComboBox();
            this.clearance_comboBox = new System.Windows.Forms.ComboBox();
            this.update_user_button = new System.Windows.Forms.Button();
            this.hu_student_id_textBox = new System.Windows.Forms.TextBox();
            this.batch_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.major_label = new System.Windows.Forms.Label();
            this.clearance_label = new System.Windows.Forms.Label();
            this.hu_student_id_label = new System.Windows.Forms.Label();
            this.bach_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // major_comboBox
            // 
            this.major_comboBox.FormattingEnabled = true;
            this.major_comboBox.Items.AddRange(new object[] {
            "Computer Science",
            "Computer Engineering",
            "Electrical Engineering",
            "Communication & Design",
            "Social Developement & Policy",
            "Comparative Humanities"});
            this.major_comboBox.Location = new System.Drawing.Point(373, 224);
            this.major_comboBox.Name = "major_comboBox";
            this.major_comboBox.Size = new System.Drawing.Size(100, 21);
            this.major_comboBox.TabIndex = 36;
            // 
            // clearance_comboBox
            // 
            this.clearance_comboBox.FormattingEnabled = true;
            this.clearance_comboBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.clearance_comboBox.Location = new System.Drawing.Point(373, 197);
            this.clearance_comboBox.Name = "clearance_comboBox";
            this.clearance_comboBox.Size = new System.Drawing.Size(100, 21);
            this.clearance_comboBox.TabIndex = 35;
            // 
            // update_user_button
            // 
            this.update_user_button.Location = new System.Drawing.Point(373, 250);
            this.update_user_button.Name = "update_user_button";
            this.update_user_button.Size = new System.Drawing.Size(100, 46);
            this.update_user_button.TabIndex = 34;
            this.update_user_button.Text = "Update User";
            this.update_user_button.UseVisualStyleBackColor = true;
            // 
            // hu_student_id_textBox
            // 
            this.hu_student_id_textBox.Location = new System.Drawing.Point(373, 168);
            this.hu_student_id_textBox.Name = "hu_student_id_textBox";
            this.hu_student_id_textBox.Size = new System.Drawing.Size(100, 20);
            this.hu_student_id_textBox.TabIndex = 33;
            // 
            // batch_textBox
            // 
            this.batch_textBox.Location = new System.Drawing.Point(373, 142);
            this.batch_textBox.Name = "batch_textBox";
            this.batch_textBox.Size = new System.Drawing.Size(100, 20);
            this.batch_textBox.TabIndex = 32;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(373, 116);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(100, 20);
            this.name_textBox.TabIndex = 31;
            // 
            // major_label
            // 
            this.major_label.AutoSize = true;
            this.major_label.Location = new System.Drawing.Point(288, 230);
            this.major_label.Name = "major_label";
            this.major_label.Size = new System.Drawing.Size(36, 13);
            this.major_label.TabIndex = 30;
            this.major_label.Text = "Major:";
            // 
            // clearance_label
            // 
            this.clearance_label.AutoSize = true;
            this.clearance_label.Location = new System.Drawing.Point(288, 197);
            this.clearance_label.Name = "clearance_label";
            this.clearance_label.Size = new System.Drawing.Size(58, 13);
            this.clearance_label.TabIndex = 29;
            this.clearance_label.Text = "Clearance:";
            // 
            // hu_student_id_label
            // 
            this.hu_student_id_label.AutoSize = true;
            this.hu_student_id_label.Location = new System.Drawing.Point(288, 171);
            this.hu_student_id_label.Name = "hu_student_id_label";
            this.hu_student_id_label.Size = new System.Drawing.Size(80, 13);
            this.hu_student_id_label.TabIndex = 28;
            this.hu_student_id_label.Text = "HU Student ID:";
            // 
            // bach_label
            // 
            this.bach_label.AutoSize = true;
            this.bach_label.Location = new System.Drawing.Point(288, 145);
            this.bach_label.Name = "bach_label";
            this.bach_label.Size = new System.Drawing.Size(38, 13);
            this.bach_label.TabIndex = 27;
            this.bach_label.Text = "Batch:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(288, 119);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(38, 13);
            this.name_label.TabIndex = 26;
            this.name_label.Text = "Name:";
            // 
            // UsersUPDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.major_comboBox);
            this.Controls.Add(this.clearance_comboBox);
            this.Controls.Add(this.update_user_button);
            this.Controls.Add(this.hu_student_id_textBox);
            this.Controls.Add(this.batch_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.major_label);
            this.Controls.Add(this.clearance_label);
            this.Controls.Add(this.hu_student_id_label);
            this.Controls.Add(this.bach_label);
            this.Controls.Add(this.name_label);
            this.Name = "UsersUPDATE";
            this.Text = "UsersUPDATE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox major_comboBox;
        private System.Windows.Forms.ComboBox clearance_comboBox;
        private System.Windows.Forms.Button update_user_button;
        private System.Windows.Forms.TextBox hu_student_id_textBox;
        private System.Windows.Forms.TextBox batch_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label major_label;
        private System.Windows.Forms.Label clearance_label;
        private System.Windows.Forms.Label hu_student_id_label;
        private System.Windows.Forms.Label bach_label;
        private System.Windows.Forms.Label name_label;
    }
}