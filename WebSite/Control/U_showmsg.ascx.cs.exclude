using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ttxy.Model;

public partial class Control_U_showmsg : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public IList<Services> msgdata
    {
        set
        {
            PagedDataSource pds = new PagedDataSource();
            if (value != null)
            {
                pds.DataSource = value;
                this.Repeater_nodelist.DataSource = pds;
                this.Repeater_nodelist.DataBind();
            }
        }
    }
}