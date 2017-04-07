using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ttxy.Model;
using ttxy.Funcs;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button_login_Click(object sender, EventArgs e)
    {
        UsFuns uf = new UsFuns();
        User lgre = uf.UserLogin(this.TextBox_account.Text, this.TextBox_passwd.Text);
        if (lgre != null)
        {
            Session["login"] = lgre.Username;
            if (lgre.Admin == '0')
            {
                Response.Write("<script language='javascript'>alert('Welcome System Manager'); location.href='manager.aspx'</script>");
            }
            else if (lgre.Admin == '2')
            {
                Response.Write("<script language='javascript'>alert('Welcome " + lgre.Name + "'); location.href='employee.aspx'</script>");
            }
            else
            {
                Response.Write("<script language='javascript'>alert('Login Success！'); location.href='petnote.aspx'</script>");
            }
        }
        else
        {
            Session["login"] = null;
            Response.Write("<script language='javascript'>alert('Login Faild, Please Try Again.'); location.href='login.aspx'</script>");
        }
    }
}