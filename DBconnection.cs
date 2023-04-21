using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FilmStudio_InventoryManagementSystem
{
    public static class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MQLKQKB\SPARTA;Initial Catalog=FILMSTUDIO;Integrated Security=True");
            return con;
        }
    }
}
