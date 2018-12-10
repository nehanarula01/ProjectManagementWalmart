using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DayPilot.Utils;
using DayPilot.Web.Ui;
using DayPilot.Web.Ui.Events.Scheduler;
using Util.Task;
using Util.Ui;
using Resource = DayPilot.Web.Ui.Resource;
using System.Web.Security;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // var ab = Membership.GetUser();
        if (!User.Identity.IsAuthenticated)
        {
            FormsAuthentication.RedirectToLoginPage();
        }
       // var a = Membership.GetUser();
        //var FormsAuthCookie = Response.Cookies[FormsAuthentication.FormsCookieName];
        //var ExistingTicket = FormsAuthentication.Decrypt(FormsAuthCookie.Value);
        //bool IsPersistent = ExistingTicket.IsPersistent;
        if (!IsPostBack)
        {
            LoadProjects();
        }
    }

    private void LoadProjects()
    {
        RepeaterProjects.DataSource = new DataManager().GetProjects();
        DataBind();
    }

    protected void ButtonRefresh_Click(object sender, EventArgs e)
    {
        LoadProjects();
    }

    protected void UpdatePanelProjects_Load(object sender, EventArgs e)
    {
        
    }
}
