using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Username.Text = HttpContext.Current.User.Identity.Name;
        //if (!User.Identity.IsAuthenticated)
       
        //{
        //    FormsAuthentication.RedirectToLoginPage();
        //}
    }

    protected void Logout_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        HttpContext.Current.Session.Abandon();
        Response.Redirect("~/");
    }
}
