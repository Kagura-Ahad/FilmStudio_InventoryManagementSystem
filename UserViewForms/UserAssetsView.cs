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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FilmStudio_InventoryManagementSystem.UserViewForms
{
    public partial class UserAssetsView : Form
    {
        SqlConnection con = DBConnection.GetConnection();
        SqlCommand cm = new SqlCommand();
        public UserAssetsView()
        {
            InitializeComponent();
            LoadAllAssets();
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
            available_assets_grid_view.DataSource = dt;
            available_assets_grid_view.BackgroundColor = Color.White;
            available_assets_grid_view.RowHeadersVisible = false;
            available_assets_grid_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            selected_asset_number_text_box.ReadOnly = true;


        }

        private void add_to_cart_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selected_asset_number_text_box.Text))
            {
                MessageBox.Show("Please select an Asset and then click Add to Cart!!");
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                // @inventoryID int, @cartID int, @quantity int
                cmd.CommandText = "Declare @id int SET @id = (select max(ID) from Cart) EXEC [ADD ASSET TO CART] @AssetID = @CID, @cartID = @ID";
                cmd.Parameters.Add("@CID", SqlDbType.Int).Value = Int16.Parse(selected_asset_number_text_box.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Asset succesfully added to your cart!", "Succesful!");
            }
        }

        private void available_assets_grid_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_asset_number_text_box.Text = available_assets_grid_view.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
