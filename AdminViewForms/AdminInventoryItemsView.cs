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
    public partial class AdminInventoryItemsView : Form
    {
        SqlConnection con = DBConnection.GetConnection();
        SqlCommand cm = new SqlCommand();
        public AdminInventoryItemsView()
        {
            InitializeComponent();
            LoadAllAssets();
        }

        private void LoadAllAssets()
        {
            con.Open();
            string sql = " select * from Inventory";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            inventory_items_grid_view.DataSource = dt;
            inventory_items_grid_view.BackgroundColor = Color.White;
            inventory_items_grid_view.RowHeadersVisible = false;
            inventory_items_grid_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
