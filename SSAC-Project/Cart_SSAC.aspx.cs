using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSAC_Project
{
    public partial class Cart_SSAC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label lblMaster = (Label)Master.FindControl("lblName");
            lblMaster.Text = Session["user"].ToString();

        }
        public void Cart(String price,String Name) {
            
        }
    }
}