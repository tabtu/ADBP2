using System;

public partial class Manage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (! IsPostBack)
        {
            U_rank1.Visible = false;
            U_requirement1.Visible = false;
            U_student1.Visible = false;
            U_mytimetable1.Visible = false;
            U_report_fee1.Visible = false;
            U_Fee1.Visible = false;
        }
    }

    protected void Button_timetable_Click(object sender, EventArgs e)
    {
        U_rank1.Visible = false;
        U_requirement1.Visible = false;
        U_student1.Visible = false;
        U_mytimetable1.Visible = true;
        U_report_fee1.Visible = false;
        U_Fee1.Visible = false;
    }

    protected void Button_fee_Click(object sender, EventArgs e)
    {
        U_rank1.Visible = false;
        U_requirement1.Visible = false;
        U_student1.Visible = false;
        U_mytimetable1.Visible = false;
        U_report_fee1.Visible = false;
        U_Fee1.Visible = true;
    }

    protected void Button_report_Click(object sender, EventArgs e)
    {
        U_rank1.Visible = false;
        U_requirement1.Visible = false;
        U_student1.Visible = false;
        U_mytimetable1.Visible = false;
        U_report_fee1.Visible = true;
        U_Fee1.Visible = false;
        
    }

    protected void Button_student_Click(object sender, EventArgs e)
    {
        U_rank1.Visible = false;
        U_requirement1.Visible = false;
        U_student1.Visible = true;
        U_mytimetable1.Visible = false;
        U_report_fee1.Visible = false;
        U_Fee1.Visible = false;
    }

    protected void Button_rank_Click(object sender, EventArgs e)
    {
        U_rank1.Visible = false;
        U_requirement1.Visible = true;
        U_student1.Visible = false;
        U_mytimetable1.Visible = false;
        U_report_fee1.Visible = false;
        U_Fee1.Visible = false;
    }

    protected void Button_atd_Click(object sender, EventArgs e)
    {
        U_rank1.Visible = true;
        U_requirement1.Visible = false;
        U_student1.Visible = false;
        U_mytimetable1.Visible = false;
        U_report_fee1.Visible = false;
        U_Fee1.Visible = false;
    }
}