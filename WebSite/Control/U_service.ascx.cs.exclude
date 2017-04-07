using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ttxy.Model;
using ttxy.Funcs;

public partial class Control_U_service : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        bind_operation(sf.SearchOperationAll());
    }

    public void bind_operation(IList<Operation> tmp)
    {
        PagedDataSource pds = new PagedDataSource();
        if (tmp != null)
        {
            pds.DataSource = tmp;
            this.DropDownList_operation.DataSource = pds;
            this.DropDownList_operation.DataTextField = "Name";
            this.DropDownList_operation.DataValueField = "Id";
            this.DropDownList_operation.DataBind();
        }
    }

    public Services services
    {
        get
        {
            Services tmp = new Services();
            tmp.Operation = int.Parse(this.DropDownList_operation.SelectedValue);
            tmp.Description = this.TextBox_description.Text;
            return tmp;
        }

        set
        {
            
        }
    }
}