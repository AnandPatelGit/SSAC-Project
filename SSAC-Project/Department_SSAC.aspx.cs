using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSAC_Project
{
    public partial class Department_SSAC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label lblMaster = (Label)Master.FindControl("lblName");
            lblMaster.Text = Session["user"].ToString();

        }

        protected void imgBtnClothes_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ClothesDepartmentSSAC.aspx");
        }

        protected void imgBtnBooks_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("BooksDepartmentSSAC.aspx");
        }

        protected void imgBtnHome_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("HomeDepartmentSSAC.aspx");
        }
        protected void imgBtnElectronics_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ElectronicsDepartmentSSAC.aspx");
        }
    }
}