using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

using ttxy.Model;
using ttxy.Funcs;

public partial class Control_U_rank : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlFuns sf = new SqlFuns();
            bind(sf.SearchStudent(true));
            bind(sf.SearchLevel());
        }
    }

    public void bind(IList<Level> list)
    {
        PagedDataSource pds = new PagedDataSource();
        if (list != null)
        {
            pds.DataSource = list;
            DropDownList_level.DataSource = pds;
            DropDownList_level.DataTextField = "Name";
            DropDownList_level.DataValueField = "Levid";
            DropDownList_level.DataBind();
        }
    }

    public void bind(IList<Course> list)
    {
        PagedDataSource pds = new PagedDataSource();
        if (list != null)
        {
            pds.DataSource = list;
            DropDownList_cos.DataSource = pds;
            DropDownList_cos.DataTextField = "Name";
            DropDownList_cos.DataValueField = "Cosid";
            DropDownList_cos.DataBind();
        }
    }

    public void bind(IList<Student> list)
    {
        PagedDataSource pds = new PagedDataSource();
        if (list != null)
        {
            pds.DataSource = list;
            DropDownList_stu.DataSource = pds;
            DropDownList_stu.DataTextField = "Name";
            DropDownList_stu.DataValueField = "Stnum";
            DropDownList_stu.DataBind();
        }
    }

    protected void Button_submit_Click(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        Attendance tmp = new Attendance();
        tmp.Course = uint.Parse(DropDownList_cos.SelectedValue);
        tmp.Student = uint.Parse(DropDownList_stu.SelectedValue);
        tmp.Date = DateTime.Parse(TextBox_dt.Text);
        int result = sf.AddAttendance(tmp);
        if (result > 0)
        {
            Response.Write("<script language='javascript'>alert('Success!!!');</script>");
        }
        else
        {
            Response.Write("<script language='javascript'>alert('Failed!!!');</script>");
        }
    }

    protected void DropDownList_level_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        bind(sf.SearchCourseLEVEL(ushort.Parse(DropDownList_level.SelectedValue)));
    }
}