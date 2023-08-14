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
            all_inventory_items_radio_button.Checked = true;
        }

        private void all_inventory_items_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = @"
                SELECT [Name],Description,CategoryName, QuantityinStock, TotalQuantity
                FROM Inventory I , Categories C
                WHERE I.CategoryID = C.ID 
                ";
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

        private void checked_out_inventory_items_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = @"
                SELECT [Name],[Description],CategoryName,TotalQuantity - QuantityinStock AS [Quantity]
                FROM Inventory I , Categories C
                WHERE I.CategoryID = C.ID AND TotalQuantity - QuantityinStock <> 0;
                ";
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

        private void available_inventory_items_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = @"
                SELECT [Name],Description,CategoryName, QuantityinStock
                FROM Inventory I , Categories C
                WHERE I.CategoryID = C.ID AND QuantityinStock <> 0;
                ";
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

        private void add_inventory_items_button_Click(object sender, EventArgs e)
        {
            string dataToSend = "Hello from the previous form!";
            AddForms.AssetADD addAssetsPageOPEN = new AddForms.AssetADD(dataToSend);
            addAssetsPageOPEN.Show();
            all_inventory_items_radio_button.Checked = true;
        }

        private void update_inventory_items_button_Click(object sender, EventArgs e)
        {
            new UpdateForms.InventoryItemUPDATE().Show();
            all_inventory_items_radio_button.Checked = true;
        }

        private void delete_inventory_items_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
