using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSAC_Project
{
    public partial class Order : System.Web.UI.Page
    {
        Object price;
        int j = 0;
        float total;
        protected void Page_Load(object sender, EventArgs e)
        {
           // String product = 
            Label lblMaster = (Label)Master.FindControl("lblName");
            lblMaster.Text = Session["user"].ToString();
            oName.Text = Session["user"].ToString();
            oProduct.Text = Application["userItem"].ToString();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            {
                //Int32 pId = Convert.ToInt32(Application["productId"].ToString());
                //String pId = Application["productId"].ToString();
                    SqlCommand cmd = new SqlCommand();
                    //cmd.CommandText = "select productPrice from Product where productId = "+pId+ "";
                    
                    cmd.CommandText = "select productPrice,productImage,productCategoryName from Product where productId = '" +Application["productId"] + "'";
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //double price = reader.GetDouble(0);
                        price = reader.GetValue(0);
                        oPrice.Text = price.ToString();
                        String image = reader.GetString(1);
                        imgProduct.ImageUrl = image;
                    String category = reader.GetString(2);
                    oCategory.Text = category;
                    //oCategory.Text = image;
                    //conn.Close();
                    int i = 1;
                    tbxQuantity.Text = i.ToString();
                    int qty = Convert.ToInt32(tbxQuantity.Text);
                    total = qty * (Convert.ToInt32(price));
                    oTotal.Text = total.ToString();
                }
                    conn.Close();
            }


        }

        protected void Check_Out_Click(object sender, EventArgs e)
        {
            String payMethod = Payment.SelectedIndex.ToString();
            int payId;
            if (payMethod == "Dedit") payId = 301;
            else if (payMethod == "Crebit") payId = 302;
            else payId = 303;
            //DateTime dt = new DateTime();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO Orders values('" + (j + 1) + "','" + Application["userId"].ToString() + "','" + payId + "','" + total + "','" + payMethod + "')";
            command.Connection = conn;
            conn.Open();
            command.ExecuteNonQuery();
                conn.Close();
            }
        }
    

        protected void tbxQuantity_TextChanged(object sender, EventArgs e)
        {
            int qty =Convert.ToInt32(tbxQuantity.Text);
            float total = qty * (Convert.ToInt32(price));
            oTotal.Text = total.ToString();
        }

        protected void Payment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}