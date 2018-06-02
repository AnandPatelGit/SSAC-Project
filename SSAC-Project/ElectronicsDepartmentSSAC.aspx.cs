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
    public partial class ElectronicsDepartmentSSAC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label lblMaster = (Label)Master.FindControl("lblName");
            lblMaster.Text = Session["user"].ToString();
            //lblCart.Text = Application["cartctr"].ToString();
        }

        protected void imgBtnElectronics1_Click(object sender, ImageClickEventArgs e)
        {
            if (Application["userItem"] == null)
            {
                Application["userItem"] = "Apple iPhone 7";
                Application["productId"] = 1;
            }
            else
            {
                Application["userItem"] += "Apple iPhone 7";
                Application["productId"] = 1;
            }
            Response.Redirect("Order.aspx");
        }
        protected void imgBtnElectronics2_Click(object sender, ImageClickEventArgs e)
        {
         
            if (Application["userItem"] == null)
            {
                Application["userItem"] = "Apple MacBook Pro";
                Application["productId"] = 2;
            }
            else
            {
                Application["userItem"] += "Apple MacBook Pro";
                Application["productId"] = 2;
            }
            Response.Redirect("Order.aspx");
        }

        protected void imgBtnElectronics3_Click(object sender, ImageClickEventArgs e)
        {
            if (Application["userItem"] == null)
            {
                Application["userItem"] = "Sony Bravia 45' 4K";
                Application["productId"] = 3;
            }
            else
            {
                Application["userItem"] += "Sony Bravia 45' 4K";
                Application["productId"] = 3; 
            }
            Response.Redirect("Order.aspx");
        }

        protected void imgBtnElectronics4_Click(object sender, ImageClickEventArgs e)
        {
            
            if (Application["userItem"] == null)
            {
                Application["userItem"] = "Beats HeadPhones";
                Application["productId"] = 4;
            }
            else
            {
                Application["userItem"] += "Beats HeadPhones";
                Application["productId"] = 4;
            }
            Response.Redirect("Order.aspx");
        }

        protected void imgBtnElectronics5_Click(object sender, ImageClickEventArgs e)
        {
            if (Application["userItem"] == null)
            {
                Application["userItem"] = "Sony PlayStation 4";
                Application["productId"] = 5;
            }
            else
            {
                Application["userItem"] += "Sony Play Station 4";
                Application["productId"] = 5;
            }
            Response.Redirect("Order.aspx");
        }

        protected void imgBtnElectronics6_Click(object sender, ImageClickEventArgs e)
        {
            if (Application["userItem"] == null)
            {
                Application["userItem"] = "Philips Soundbar";
                Application["productId"] = 6;
            }
            else
            {
                Application["userItem"] += "Philips Soundbar";
                Application["productId"] = 6;
            }
            Response.Redirect("Order.aspx");
        }

        protected void imgBtnElectronics7_Click(object sender, ImageClickEventArgs e)
        {

            if (Application["userItem"] == null)
            {
                Application["userItem"] = "Apple iMac 20' ";
                Application["productId"] = 7;
            }
            else
            {
                Application["userItem"] += "Apple iMac 20' ";
                Application["productId"] = 7;
            }
            Response.Redirect("Order.aspx");
        }
        protected void imgBtnElectronics8_Click(object sender, ImageClickEventArgs e)
        {
            
            if (Application["userItem"] == null)
            {
                Application["userItem"] = "Apple iWatch Series 2";
                Application["productId"] = 8;
            }
            else
            {
                Application["userItem"] += "Apple iWatch Series 2 ";
                Application["productId"] = 8;
            }
            Response.Redirect("Order.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Application["cartctr"] = (int)Application["cartctr"] + 1;
            Label lblMaster = (Label)Master.FindControl("lblCart");
            lblMaster.Text = Application["cartctr"].ToString();
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Application["cartctr"] = (int)Application["cartctr"] + 1;
            Label lblMaster = (Label)Master.FindControl("lblCart");
            lblMaster.Text = Application["cartctr"].ToString();
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Application["cartctr"] = (int)Application["cartctr"] + 1;
            Label lblMaster = (Label)Master.FindControl("lblCart");
            lblMaster.Text = Application["cartctr"].ToString();
        }
        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Application["cartctr"] = (int)Application["cartctr"] + 1;
            Label lblMaster = (Label)Master.FindControl("lblCart");
            lblMaster.Text = Application["cartctr"].ToString();
        }
        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Application["cartctr"] = (int)Application["cartctr"] + 1;
            Label lblMaster = (Label)Master.FindControl("lblCart");
            lblMaster.Text = Application["cartctr"].ToString();
        }
        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Application["cartctr"] = (int)Application["cartctr"] + 1;
            Label lblMaster = (Label)Master.FindControl("lblCart");
            lblMaster.Text = Application["cartctr"].ToString();
        }
        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            Application["cartctr"] = (int)Application["cartctr"] + 1;
            Label lblMaster = (Label)Master.FindControl("lblCart");
            lblMaster.Text = Application["cartctr"].ToString();
        }
        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            Application["cartctr"] = (int)Application["cartctr"] + 1;
            Label lblMaster = (Label)Master.FindControl("lblCart");
            lblMaster.Text = Application["cartctr"].ToString();
        }
    }
}