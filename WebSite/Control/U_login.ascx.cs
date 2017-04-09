using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ttxy.Model;
using ttxy.Funcs;

public partial class Control_U_login : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button_login_Click(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        UsFuns uf = new UsFuns();
        Member login = uf.UserLogin(TextBox_usr.Text, TextBox_pwd.Text);
        if (login != null)
        {
            Response.Write("<script language='javascript'>alert('Login Succed.'); location.href='Manage.aspx'</script>");
        }
        else
        {
            Response.Write("<script language='javascript'>alert('Failed!!! Please login again.')</script>");
        }
    }
}