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

namespace FilmStudio_InventoryManagementSystem.UserViewForms
{
    public partial class UserCartView : Form
    {
        SqlConnection con = DBConnection.GetConnection();
        SqlCommand cm = new SqlCommand();
        public UserCartView()
        {
            InitializeComponent();
            LoadCartInventory();
            LoadCartAssets();
            issue_date_dateTimePicker.Enabled = false;
            LoadCartNumber();

        }

        private void LoadCartNumber()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT MAX(ID) FROM Cart";
            object result = cmd.ExecuteScalar();
            con.Close();

            if (result != null && result != DBNull.Value)
            {
                int maxCartID = Convert.ToInt32(result);
                selected_cart_number_text_box.Text = maxCartID.ToString();
            }
            else
            {
                selected_cart_number_text_box.Text = "No cart data";
            }
            selected_cart_number_text_box.Enabled = false;
        }


        private void LoadCartAssets()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = @" 
            select A.ID, AD.[Name], AD.Description
            FROM Asset A, CartAssests CA, AssetDetails AD 
            Where CA.AssetID = A.ID and CA.CartID = (select max(ID) from Cart) and AD.ID = A.AssetDetailsID
            ";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            cart_asset_items_grid_view.DataSource = dt;
            cart_asset_items_grid_view.BackgroundColor = Color.White;
            cart_asset_items_grid_view.RowHeadersVisible = false;
            cart_asset_items_grid_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadCartInventory()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = @" 
            select I.Name,I.Description, CI.Quantity 
            from Inventory I, CartInventory CI
            Where CI.InventoryID = I.ID and CI.CartID = (select max(ID) from Cart);
            ";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            cart_inventory_items_grid_view.DataSource = dt;
            cart_inventory_items_grid_view.BackgroundColor = Color.White;
            cart_inventory_items_grid_view.RowHeadersVisible = false;
            cart_inventory_items_grid_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cart_asset_items_grid_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cart_inventory_items_header_Click(object sender, EventArgs e)
        {

        }

        private void checkout_button_Click(object sender, EventArgs e)
        {
            System.DateTime myDate = default(System.DateTime);
            myDate = return_date_dateTimePicker.Value;
            SqlCommand cmd = con.CreateCommand();
            // @inventoryID int, @cartID int, @quantity int
            cmd.CommandText = "UPDATE CART SET ReturnDate = @return where ID = (select max(ID) from Cart) ";
            cmd.Parameters.Add("@return", SqlDbType.DateTime).Value = myDate;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Items succesfully issued to you!", "Successful!");
        }

        private void cart_inventory_items_grid_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void return_date_label_Click(object sender, EventArgs e)
        {

        }

        private void selected_cart_number_text_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
