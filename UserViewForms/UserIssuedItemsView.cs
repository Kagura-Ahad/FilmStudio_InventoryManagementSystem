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
    public partial class UserIssuedItemsView : Form
    {
        SqlConnection con = DBConnection.GetConnection();
        SqlCommand cm = new SqlCommand();
        public UserIssuedItemsView()
        {
            InitializeComponent();
            loadAllIssuedAssets();
            loadAllIssuedInventoryItems();
        }
        private void loadAllIssuedAssets()
        {
            con.Open();
            string issuedAssetItems = "SELECT CA.CartID as [Cart Number], AssetID as [Asset Number], CheckOutDate, ReturnDate from CartAssests CA, Cart C where CA.CartID = C.ID and C.[Status] = 1 and C.userID = 1";
            //"SELECT CA.CartID as [Cart Number], AssetID as [Asset Number], CheckOutDate, ReturnDate from CartAssests CA, Cart C where CA.CartID = C.ID and C.[Status] = 1 and C.userID = @id";
            cm = new SqlCommand(issuedAssetItems, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            issued_inventory_items_grid_view.DataSource = dt;
            issued_inventory_items_grid_view.BackgroundColor = Color.White;
            issued_inventory_items_grid_view.RowHeadersVisible = false;
            issued_inventory_items_grid_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void loadAllIssuedInventoryItems()
        {
            con.Open();
            string issuedAssetItems = "SELECT CI.CartID as [Cart Number], InventoryID as [Inventory Number],CI.Quantity, CheckOutDate, ReturnDate from CartInventory CI, Cart C where CI.CartID = C.ID and C.[Status] = 1 and C.userID = 1";
            //"SELECT CI.CartID as [Cart Number], InventoryID as [Inventory Number],CI.Quantity, CheckOutDate, ReturnDate from CartInventory CI, Cart C where CI.CartID = C.ID and C.[Status] = 1 and C.userID = @id
            cm = new SqlCommand(issuedAssetItems, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            issued_assets_grid_view.DataSource = dt;
            issued_assets_grid_view.BackgroundColor = Color.White;
            issued_assets_grid_view.RowHeadersVisible = false;
            issued_assets_grid_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
