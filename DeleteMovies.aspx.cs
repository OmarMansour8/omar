using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class DeleteMovies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (gv.SelectedIndex != -1)
            {
                string moviename = (gv.SelectedRow.Cells[0].Text);
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True";

                string strDelete = "DELETE FROM Movies " + "WHERE MovieName = '" + moviename + "'";

                SqlCommand cmdDelete = new SqlCommand(strDelete, conn);

                conn.Open();
                cmdDelete.ExecuteNonQuery();
                conn.Close();

                Label.Text = moviename + " Successfully Deleted";


            }
        }
    }
}