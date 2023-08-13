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
    public partial class UserInventoryItemsView : Form
    {
        string temp;
        SqlConnection con = DBConnection.GetConnection();
        SqlCommand cm = new SqlCommand();
        public UserInventoryItemsView()
        {
            InitializeComponent();
            load_all_available_inventory_items();
            quantity_text_box.Text = "1";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void load_all_available_inventory_items()
        {
            con.Open();
            string issuedAssetItems = "select ID,[Name],Category,[Available Quantity] from [VIEW INVENTORY]";
            cm = new SqlCommand(issuedAssetItems, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            available_inventory_items_grid_view.DataSource = dt;
            available_inventory_items_grid_view.BackgroundColor = Color.White;
            available_inventory_items_grid_view.RowHeadersVisible = false;
            available_inventory_items_grid_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            selected_inventory_item_number_text_box.ReadOnly = true;
            available_inventory_items_grid_view.ReadOnly = true;
            available_inventory_items_grid_view.Columns[0].Visible = false;
        }

        private void available_inventory_items_grid_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_inventory_item_number_text_box.Text = available_inventory_items_grid_view.Rows[e.RowIndex].Cells[0].Value.ToString();
            temp = available_inventory_items_grid_view.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void add_to_cart_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selected_inventory_item_number_text_box.Text))
            {
                MessageBox.Show("Please select an inventory item and then click Add to Cart!");
            }
            else
            {
                if (Int16.Parse(temp) >= Int16.Parse(quantity_text_box.Text))
                {


                    SqlCommand cmd = con.CreateCommand();
                    // @inventoryID int, @cartID int, @quantity int
                    cmd.CommandText = "EXEC [ADD INVENTORY TO CART]  @inventoryID = @i, @quantity = @q ";

                    cmd.Parameters.Add("@i", SqlDbType.Int).Value = Int16.Parse(selected_inventory_item_number_text_box.Text);
                    cmd.Parameters.Add("@q", SqlDbType.Int).Value = Int16.Parse(quantity_text_box.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Asset succesfully added to your cart!", "Succesful!");
                }
                else
                {
                    MessageBox.Show("Please decrease the quantity you want to issue to less than or equal to the available quantity");
                }

            }

        }

    }
}
