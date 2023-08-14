using System;
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
    public partial class AdminAssetView : Form
    {
        SqlConnection con = DBConnection.GetConnection();
        SqlCommand cm = new SqlCommand();

        public AdminAssetView()
        {
            InitializeComponent();
            all_assets_radio_button.Checked = true;
        }

        private void LoadAllAssets()
        {
            con.Open();
            string sql = " select * from [view assets]";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            asset_grid_view.DataSource = dt;
            asset_grid_view.BackgroundColor = Color.White;
            asset_grid_view.RowHeadersVisible = false;
            asset_grid_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadAllAssets();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = " SELECT ID,[NAME] FROM [VIEW ASSETS]";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            asset_grid_view.DataSource = dt;
            asset_grid_view.BackgroundColor = Color.White;
            asset_grid_view.RowHeadersVisible = false;
            asset_grid_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            {
                con.Open();
                string sql = " SELECT ID,[NAME],[Description] FROM [VIEW ASSETS]";
                cm = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                asset_grid_view.DataSource = dt;
                asset_grid_view.BackgroundColor = Color.White;
                asset_grid_view.RowHeadersVisible = false;
                asset_grid_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }   
}

    

 