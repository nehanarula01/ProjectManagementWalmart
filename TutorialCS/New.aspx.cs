using System;
using System.Collections;
using System.Data;
using System.Web.UI.WebControls;
using DayPilot.Utils;
using DayPilot.Web.Ui.Enums;
using Util;

public partial class NewDialog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }
    }



    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        //Project projectModel = new Project();
        //projectModel.ProjectName = TextBoxName.Text; ;
        //projectModel.RequestorTeam = RequestorTeam.Text;
        //projectModel.RequestType = RequestType.Text;
        //projectModel.SkillsRequired = SkillsRequired.Text;
        //projectModel.RequestorName = RequestorName.Text;
        //projectModel.RequestorTeam = RequestorTeam.Text;
        //projectModel.EstinmatedEffort = EstinmatedEffort.Text;
        //projectModel.TargetedCompletionDate = Convert.ToDateTime(TargetedCompletionDate.Text);
        //projectModel.ProjectStatus = ProjectStatus.Text;


        

        //string name = TextBoxName.Text;
        new DataManager().CreateProject(ProjectName.Text, RequestSource.Text, RequestType.Text, SkillsRequired.Text, RequestorName.Text, RequestorTeam.Text, EstinmatedEffort.Text, TargetedCompletionDate.Text, ProjectStatus.Text);

        Hashtable ht = new Hashtable();
        ht["refresh"] = "yes";
        Modal.Close(this, ht);
    }

    public class Project
    {
        public string ProjectName { get; set; }
        public string RequestSource { get; set; }
        public string RequestType { get; set; }
        public string SkillsRequired { get; set; }
        public string RequestorName { get; set; }
        public string RequestorTeam { get; set; }
        public string EstinmatedEffort { get; set; }
        public DateTime TargetedCompletionDate { get; set; }
        public string ProjectStatus { get; set; }

    }

    protected void ButtonCancel_Click(object sender, EventArgs e)
    {
        Modal.Close(this);
    }
}
