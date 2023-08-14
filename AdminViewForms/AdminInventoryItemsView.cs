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
            add_inventory_items_button.Enabled = true;
            update_inventory_items_button.Enabled = true;
            delete_inventory_items_button.Enabled= true;
            con.Open();
            string sql = @"
                SELECT I.ID,[Name],Description,CategoryName, QuantityinStock, TotalQuantity
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
            inventory_items_grid_view.Columns[0].Visible = false;
        }

        private void checked_out_inventory_items_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            add_inventory_items_button.Enabled = false;
            update_inventory_items_button.Enabled = false;
            delete_inventory_items_button.Enabled = false;
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
            add_inventory_items_button.Enabled = false;
            update_inventory_items_button.Enabled = false;
            delete_inventory_items_button.Enabled = false;
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
            new AddForms.InventoryItemADD().ShowDialog();
            all_inventory_items_radio_button.Checked = true;
        }

        private void update_inventory_items_button_Click(object sender, EventArgs e)
        {
            string Name = inventory_items_grid_view.SelectedRows[0].Cells[0].Value.ToString();
            string Description = inventory_items_grid_view.SelectedRows[0].Cells[0].Value.ToString();
            string CategoryName = inventory_items_grid_view.SelectedRows[0].Cells[0].Value.ToString();
            int QuantityinStock = int.Parse(inventory_items_grid_view.SelectedRows[0].Cells[0].Value.ToString());
            int TotalQuantity = int.Parse(inventory_items_grid_view.SelectedRows[0].Cells[0].Value.ToString());

            UpdateForms.InventoryItemUPDATE updateAssetsPageOPEN = new UpdateForms.InventoryItemUPDATE(Name, Description, CategoryName, QuantityinStock, TotalQuantity);
            updateAssetsPageOPEN.ShowDialog();
            all_inventory_items_radio_button.Checked = true;
        }

        private void delete_inventory_items_button_Click(object sender, EventArgs e)
        {
            all_inventory_items_radio_button.Checked = true;
            if (inventory_items_grid_view.CurrentRow != null && inventory_items_grid_view.CurrentRow.Cells.Count > 0)
            {
                string Id = inventory_items_grid_view.CurrentRow.Cells[0].Value.ToString();
                string query = "DELETE FROM Inventory WHERE ID = @Id";

                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Id", Id);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Inventory item deleted successfully.");
                    all_inventory_items_radio_button.Checked = true;
                }
                else
                {
                    MessageBox.Show("Failed to delete inventory item.");
                }
            }
        }

    }
}
