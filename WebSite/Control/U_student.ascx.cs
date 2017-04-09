using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ttxy.Model;
using ttxy.Funcs;

public partial class Control_U_student : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlFuns sf = new SqlFuns();
            bind(sf.SearchStudent(true));
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

    public void bind(IList<Payment> list)
    {
        UsFuns uf = new UsFuns();
        list = uf.FillPayment(list);
        PagedDataSource pds = new PagedDataSource();
        if (list != null)
        {
            pds.DataSource = list;
            Repeater1.DataSource = pds;
            Repeater1.DataBind();
        }
    }

    public void bind(IList<StudentRank> list)
    {
        UsFuns uf = new UsFuns();
        list = uf.FillStuRank(list);
        PagedDataSource pds = new PagedDataSource();
        if (list != null)
        {
            pds.DataSource = list;
            Repeater2.DataSource = pds;
            Repeater2.DataBind();
        }
    }

    public void bind(IList<Attendance> list)
    {
        UsFuns uf = new UsFuns();
        list = uf.FillAttendance(list);
        PagedDataSource pds = new PagedDataSource();
        if (list != null)
        {
            pds.DataSource = list;
            Repeater3.DataSource = pds;
            Repeater3.DataBind();
        }
    }

    protected void DropDownList_stu_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        uint snum = uint.Parse(DropDownList_stu.SelectedValue);
        Student stu = sf.SearchStudent(snum);
        Label_name.Text = stu.Name;
        Label_birth.Text = stu.Birth.ToLongDateString();
        Label_jodate.Text = stu.Joindate.ToLongDateString();
        Label_mobile.Text = stu.Mobile;
        Label_email.Text = stu.Email;
        Label_addr.Text = stu.Address;
        bind(sf.SearchPayment(snum));
        bind(sf.SearchStudentRank(snum));
        bind(sf.SearchAttendanceSNUM(snum));
        Label1.Text = Label2.Text = "";
        IList<StuParent> spr = sf.SearchStuParent(snum);
        for (int i = 0; i < spr.Count; i++)
        {
            if (spr[i].Stpar == true)
            {
                Student pst = sf.SearchStudent(spr[i].Spnum);
                if (spr[i].Mord == true)
                {
                    Label1.Text = "Student Number: " + pst.Stnum + ", <br />Name: " + pst.Name + ", <br />Birthday: " + pst.Birth.ToShortDateString() + ", <br />Join Date: " + pst.Joindate.ToShortDateString() + ", <br />Address: " + pst.Address + ", <br />Phone Number: " + pst.Mobile + ", <br />Email: " + pst.Email;
                }
                else
                {
                    Label2.Text = "Student Number: " + pst.Stnum + ", <br />Name: " + pst.Name + ", <br />Birthday: " + pst.Birth.ToShortDateString() + ", <br />Join Date: " + pst.Joindate.ToShortDateString() + ", <br />Address: " + pst.Address + ", <br />Phone Number: " + pst.Mobile + ", <br />Email: " + pst.Email;
                }
            }
            else
            {
                Parent par = sf.SearchParent(spr[i].Spnum);
                if (spr[i].Mord == true)
                {
                    Label1.Text = "Name: " + par.Name + ", <br />Phone Number: " + par.Mobile + ", <br />Email: " + par.Email;
                }
                else
                {
                    Label2.Text = "Name: " + par.Name + ", <br />Phone Number: " + par.Mobile + ", <br />Email: " + par.Email;
                }
            }
        }
    }
}