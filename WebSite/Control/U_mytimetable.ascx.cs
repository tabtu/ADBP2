using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

using ttxy.Model;
using ttxy.Funcs;

public partial class Control_U_timetable : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void bind(IList<Timetable> list)
    {
        UsFuns uf = new UsFuns();
        list = uf.FillTimetable(list);
        PagedDataSource pds = new PagedDataSource();
        if (list != null)
        {
            pds.DataSource = list;
            Repeater_timetable.DataSource = pds;
            Repeater_timetable.DataBind();
        }
    }

    protected void DropDownList_dow_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        bind(sf.SearchTimetable(short.Parse(DropDownList_dow.SelectedValue)));
    }
}