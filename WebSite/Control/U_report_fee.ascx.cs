using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

using ttxy.Model;
using ttxy.Funcs;

public partial class Control_U_report : System.Web.UI.UserControl
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

    private void ShowTotal(IList<Payment> list)
    {
        double total = 0;
        foreach (Payment tmp in list)
        {
            total += tmp.Fee;
        }
        Label_result.Text = "Sum: " + total + "<br/>Count: " + list.Count + "<br/>";
    }

    protected void Button_submit_Click(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        IList<Payment> res = sf.SearchPayment(DateTime.Parse(TextBox1.Text), DateTime.Parse(TextBox2.Text));
        bind(res);
        ShowTotal(res);
    }

    protected void Button_s_Click(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        IList<Payment> res = sf.SearchPayment(uint.Parse(DropDownList_stu.SelectedValue));
        bind(res);
        ShowTotal(res);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        IList<Payment> res = sf.SearchPayment(ushort.Parse(DropDownList_pf.SelectedValue));
        bind(res);
        ShowTotal(res);
    }

    protected void Button_all_Click(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        IList<Payment> res = sf.SearchPayment(uint.Parse(DropDownList_stu.SelectedValue), ushort.Parse(DropDownList_pf.SelectedValue), DateTime.Parse(TextBox1.Text), DateTime.Parse(TextBox2.Text));
        bind(res);
        ShowTotal(res);
    }
}