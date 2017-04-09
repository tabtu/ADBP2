using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

using ttxy.Model;
using ttxy.Funcs;

public partial class Control_U_requirement : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void bind(IList<Requirement> list)
    {
        UsFuns uf = new UsFuns();
        list = uf.FillRequirement(list);
        PagedDataSource pds = new PagedDataSource();
        if (list != null)
        {
            pds.DataSource = list;
            Repeater_req.DataSource = pds;
            Repeater_req.DataBind();
        }
    }

    protected void DropDownList_req_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        bind(sf.SearchRequirement(uint.Parse(DropDownList_req.SelectedValue)));
    }
}