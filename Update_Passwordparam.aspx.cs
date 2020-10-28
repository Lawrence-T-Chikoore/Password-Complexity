using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Password_Complexity
{
    public partial class Update_Passwordparam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Password_Strength;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("update   Password_Parameters set length = @length, uppercases = @uppercases, lowercases = @lowercases, letters= @letters , numbers= @numbers ,special_characters=@special_characters where  id = 1", conn);
            cmd.Parameters.AddWithValue("@length", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@uppercases", TextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@lowercases", TextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@letters", TextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@numbers", TextBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@special_characters", TextBox6.Text.Trim());


            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd.ExecuteNonQuery();

            Response.Redirect("Registration.aspx");

        }
    }
}