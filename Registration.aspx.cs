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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
           
        }
        public void Countpassword()
        {
            string password = txtpassword.Text.Trim();
            string confirmpass = txtconfirmpass.Text.Trim();
            int upper = 0, lower = 0;
            int number = 0, special = 0;
            string messege = "";



           int dblenght ,dbupper, dblower, dbnumber, dbspecial;

            for (int i = 0; i < password.Length; i++)
            {
                char ch = password[i];
                if (ch >= 'A' && ch <= 'Z')
                    upper++;
                else if (ch >= 'a' && ch <= 'z')
                    lower++;
                else if (ch >= '0' && ch <= '9')
                    number++;
                else
                    special++;
            }

            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Password_Strength;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Password_Parameters ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            if (ds.Rows.Count > 0)
            {
                dblenght = Convert.ToInt32(ds.Rows[0]["length"].ToString());
                dbupper = Convert.ToInt32(ds.Rows[0]["uppercases"]);
                dblower = Convert.ToInt32(ds.Rows[0]["lowercases"]);
                dbnumber = Convert.ToInt32(ds.Rows[0]["numbers"]);
                dbspecial = Convert.ToInt32(ds.Rows[0]["special_characters"]);

                if (password.Length < dblenght)
                {
                  Label1.Visible = true;
                  Label1.Text = ("minimum password length is " + dblenght );
                }
                 if (upper <= dbupper)
                {
                    Label1.Visible = true;
                    Label1.Text = ("Password should have atleast  " + dbupper + "uppercase");
                }

                if (lower <= dblower)
                {
                    Label1.Visible = true;
                    Label1.Text = ("<br>minimum requred lowercases is" + dblower);
                }
                if (number <= dbnumber)
                {
                    Label1.Visible = true;
                    Label1.Text = ( "<br>minimum requred numbers is" + dbnumber);
                }
                if (special <= dbspecial)
                {
                    Label1.Visible = true;
                    Label1.Text = ("<br>minimum requred special characters is" + dbspecial);
                }
                if (password != confirmpass)
                {
                    Label1.Visible = true;
                    Label1.Text = ("password does not match ");

                }

                if (password.Length == dblenght &&  dbupper <= upper && dblower <= lower && dbnumber <= number && dbspecial <= special)
                {
                        cmd = new SqlCommand("insert into Users(Username,Password,Confirmpass)values(@Username,@Password,@Confirmpass)", conn);
                        cmd.Parameters.AddWithValue("@Username", txtusername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Confirmpass", txtconfirmpass.Text.Trim());

                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        cmd.ExecuteNonQuery();
                }
            }

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Countpassword();
           
        }
    }
 
}