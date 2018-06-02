using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SSAC_Project;

namespace SSAC_Project
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            {

                String un = tbxUsername.Text.ToString();
                String ps = tbxPassword.Text.ToString();
                if (un != null && ps != null)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select count(customerId) from customer where customerId='" + un + "'and password='" + ps + "'";
                    cmd.Connection = conn;
                    conn.Open();
                    int LoginResult = (int)cmd.ExecuteScalar();
                    if (LoginResult == 1)
                    {
                        cmd.CommandText = "select firstName,customerId from customer where customerId='" + un + "'and password='" + ps + "'";
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            String name = reader.GetString(0);
                            Session["user"] = name;
                            int cId = reader.GetInt32(1);
                            Application["userId"] = cId;
                            Label lblMaster = (Label)Master.FindControl("lblName");
                            lblMaster.Text = Session["user"].ToString();
                        }
                        Response.Redirect("Department_SSAC.aspx");
                    }
                    else
                    {
                        Response.Write("Username or Password is wrong");
                    }
                    conn.Close();
                }
                else {
                    Response.Write("Provide input in the fields");
                }
            }

        }
    }
}