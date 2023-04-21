namespace FilmStudio_InventoryManagementSystem
{
    partial class UserView
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
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonIssued = new System.Windows.Forms.Button();
            this.buttonCartView = new System.Windows.Forms.Button();
            this.buttonInventoryItemsView = new System.Windows.Forms.Button();
            this.buttonAssetView = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(230, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(570, 370);
            this.panelDesktopPane.TabIndex = 5;
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
            this.panelTitleBar.TabIndex = 4;
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
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonIssued);
            this.panelMenu.Controls.Add(this.buttonCartView);
            this.panelMenu.Controls.Add(this.buttonInventoryItemsView);
            this.panelMenu.Controls.Add(this.buttonAssetView);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 450);
            this.panelMenu.TabIndex = 3;
            // 
            // buttonIssued
            // 
            this.buttonIssued.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIssued.FlatAppearance.BorderSize = 0;
            this.buttonIssued.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIssued.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonIssued.Image = global::FilmStudio_InventoryManagementSystem.Properties.Resources.Issued_User;
            this.buttonIssued.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIssued.Location = new System.Drawing.Point(0, 260);
            this.buttonIssued.Name = "buttonIssued";
            this.buttonIssued.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonIssued.Size = new System.Drawing.Size(230, 60);
            this.buttonIssued.TabIndex = 4;
            this.buttonIssued.Text = "     Issued";
            this.buttonIssued.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIssued.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonIssued.UseVisualStyleBackColor = true;
            this.buttonIssued.Click += new System.EventHandler(this.buttonIssued_Click);
            // 
            // buttonCartView
            // 
            this.buttonCartView.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCartView.FlatAppearance.BorderSize = 0;
            this.buttonCartView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCartView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCartView.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCartView.Image = global::FilmStudio_InventoryManagementSystem.Properties.Resources.Cart_User;
            this.buttonCartView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCartView.Location = new System.Drawing.Point(0, 200);
            this.buttonCartView.Name = "buttonCartView";
            this.buttonCartView.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonCartView.Size = new System.Drawing.Size(230, 60);
            this.buttonCartView.TabIndex = 3;
            this.buttonCartView.Text = "     Cart";
            this.buttonCartView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCartView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCartView.UseVisualStyleBackColor = true;
            this.buttonCartView.Click += new System.EventHandler(this.buttonCartView_Click);
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
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "UserView";
            this.Text = "UserView";
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button buttonIssued;
        private System.Windows.Forms.Button buttonCartView;
        private System.Windows.Forms.Button buttonInventoryItemsView;
        private System.Windows.Forms.Button buttonAssetView;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMenu;
    }
}