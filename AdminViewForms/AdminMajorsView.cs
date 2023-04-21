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
    public partial class AdminMajorsView : Form
    {
        SqlConnection con = DBConnection.GetConnection();
        SqlCommand cm = new SqlCommand();
        public AdminMajorsView()
        {
            InitializeComponent();
            LoadAllMajors();
        }
        private void LoadAllMajors()
        {
            con.Open();
            string sql = " select * from Users";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
