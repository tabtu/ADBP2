using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

using ttxy.Model;
using ttxy.Funcs;

public partial class Control_AddFee : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlFuns sf = new SqlFuns();
            bind(sf.SearchStudent(true));
            bind(sf.SearchPayFor());
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

    public void bind(IList<PayFor> list)
    {
        PagedDataSource pds = new PagedDataSource();
        if (list != null)
        {
            pds.DataSource = list;
            DropDownList_pf.DataSource = pds;
            DropDownList_pf.DataTextField = "Description";
            DropDownList_pf.DataValueField = "Id";
            DropDownList_pf.DataBind();
        }
    }

    protected void Button_submit_Click(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        Payment tmp = new Payment();
        tmp.Stnum = uint.Parse(DropDownList_stu.SelectedValue);
        tmp.Payfor = ushort.Parse(DropDownList_pf.SelectedValue);
        tmp.Fee = double.Parse(TextBox_fee.Text);
        tmp.Paydt = DateTime.Now;
        int result = sf.AddPayment(tmp);
        if (result > 0)
        {
            Response.Write("<script language='javascript'>alert('Success!!!');</script>");
        }
        else
        {
            Response.Write("<script language='javascript'>alert('Failed!!!');</script>");
        }
    }
}