﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmStudio_InventoryManagementSystem.AdminViewForms
{
    public partial class AdminCategoriesView : Form
    {
        SqlConnection con = DBConnection.GetConnection();
        SqlCommand cm = new SqlCommand();
        public AdminCategoriesView()
        {
            InitializeComponent();
            LoadAllCategories();
        }
        private void LoadAllCategories()
        {
            con.Open();
            string sql = " select * from Users";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            categories_grid_view.DataSource = dt;
            categories_grid_view.BackgroundColor = Color.White;
            categories_grid_view.RowHeadersVisible = false;
            categories_grid_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
