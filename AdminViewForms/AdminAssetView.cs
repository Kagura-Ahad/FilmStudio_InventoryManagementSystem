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
            radioButton1.Checked = true;
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
            dataGridView1.DataSource = dt;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dataGridView1.DataSource = dt;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                dataGridView1.DataSource = dt;
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }   
}

    

 