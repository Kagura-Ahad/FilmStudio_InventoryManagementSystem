namespace FilmStudio_InventoryManagementSystem
{
    partial class AdminView
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMajorsView = new System.Windows.Forms.Button();
            this.buttonUsersView = new System.Windows.Forms.Button();
            this.buttonCategoriesView = new System.Windows.Forms.Button();
            this.buttonInventoryItemsView = new System.Windows.Forms.Button();
            this.buttonAssetView = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonMajorsView);
            this.panelMenu.Controls.Add(this.buttonUsersView);
            this.panelMenu.Controls.Add(this.buttonCategoriesView);
            this.panelMenu.Controls.Add(this.buttonInventoryItemsView);
            this.panelMenu.Controls.Add(this.buttonAssetView);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonMajorsView
            // 
            this.buttonMajorsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMajorsView.FlatAppearance.BorderSize = 0;
            this.buttonMajorsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMajorsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMajorsView.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMajorsView.Image = global::FilmStudio_InventoryManagementSystem.Properties.Resources.majors_Admin;
            this.buttonMajorsView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMajorsView.Location = new System.Drawing.Point(0, 320);
            this.buttonMajorsView.Name = "buttonMajorsView";
            this.buttonMajorsView.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonMajorsView.Size = new System.Drawing.Size(230, 60);
            this.buttonMajorsView.TabIndex = 5;
            this.buttonMajorsView.Text = "     Majors";
            this.buttonMajorsView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMajorsView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMajorsView.UseVisualStyleBackColor = true;
            this.buttonMajorsView.Click += new System.EventHandler(this.buttonMajorsView_Click);
            // 
            // buttonUsersView
            // 
            this.buttonUsersView.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUsersView.FlatAppearance.BorderSize = 0;
            this.buttonUsersView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsersView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersView.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUsersView.Image = global::FilmStudio_InventoryManagementSystem.Properties.Resources.users_Admin;
            this.buttonUsersView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsersView.Location = new System.Drawing.Point(0, 260);
            this.buttonUsersView.Name = "buttonUsersView";
            this.buttonUsersView.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonUsersView.Size = new System.Drawing.Size(230, 60);
            this.buttonUsersView.TabIndex = 4;
            this.buttonUsersView.Text = "     Users";
            this.buttonUsersView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsersView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUsersView.UseVisualStyleBackColor = true;
            this.buttonUsersView.Click += new System.EventHandler(this.buttonUsersView_Click);
            // 
            // buttonCategoriesView
            // 
            this.buttonCategoriesView.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCategoriesView.FlatAppearance.BorderSize = 0;
            this.buttonCategoriesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategoriesView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCategoriesView.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCategoriesView.Image = global::FilmStudio_InventoryManagementSystem.Properties.Resources.Cat_Admin;
            this.buttonCategoriesView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategoriesView.Location = new System.Drawing.Point(0, 200);
            this.buttonCategoriesView.Name = "buttonCategoriesView";
            this.buttonCategoriesView.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonCategoriesView.Size = new System.Drawing.Size(230, 60);
            this.buttonCategoriesView.TabIndex = 3;
            this.buttonCategoriesView.Text = "     Categories";
            this.buttonCategoriesView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategoriesView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCategoriesView.UseVisualStyleBackColor = true;
            this.buttonCategoriesView.Click += new System.EventHandler(this.buttonCategoriesView_Click);
            // 
            // buttonInventoryItemsView
            // 
            this.buttonInventoryItemsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInventoryItemsView.FlatAppearance.BorderSize = 0;
            this.buttonInventoryItemsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventoryItemsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventoryItemsView.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonInventoryItemsView.Image = global::FilmStudio_InventoryManagementSystem.Properties.Resources.Inventory_Admin_Final;
            this.buttonInventoryItemsView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInventoryItemsView.Location = new System.Drawing.Point(0, 140);
            this.buttonInventoryItemsView.Name = "buttonInventoryItemsView";
            this.buttonInventoryItemsView.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonInventoryItemsView.Size = new System.Drawing.Size(230, 60);
            this.buttonInventoryItemsView.TabIndex = 2;
            this.buttonInventoryItemsView.Text = "     Inventory Items";
            this.buttonInventoryItemsView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInventoryItemsView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInventoryItemsView.UseVisualStyleBackColor = true;
            this.buttonInventoryItemsView.Click += new System.EventHandler(this.buttonInventoryItemsView_Click);
            // 
            // buttonAssetView
            // 
            this.buttonAssetView.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAssetView.FlatAppearance.BorderSize = 0;
            this.buttonAssetView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssetView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssetView.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAssetView.Image = global::FilmStudio_InventoryManagementSystem.Properties.Resources.Assets_Admin;
            this.buttonAssetView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAssetView.Location = new System.Drawing.Point(0, 80);
            this.buttonAssetView.Name = "buttonAssetView";
            this.buttonAssetView.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonAssetView.Size = new System.Drawing.Size(230, 60);
            this.buttonAssetView.TabIndex = 1;
            this.buttonAssetView.Text = "     Assets";
            this.buttonAssetView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAssetView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAssetView.UseVisualStyleBackColor = true;
            this.buttonAssetView.Click += new System.EventHandler(this.buttonAssetView_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(81, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FSIMS";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(570, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(233, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(98, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(230, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(570, 370);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonMajorsView;
        private System.Windows.Forms.Button buttonUsersView;
        private System.Windows.Forms.Button buttonCategoriesView;
        private System.Windows.Forms.Button buttonInventoryItemsView;
        private System.Windows.Forms.Button buttonAssetView;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}

