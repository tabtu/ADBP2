using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ttxy.Model;

public partial class Control_U_usr : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public User user
    {
        set
        {
            this.TextBox_username.Text = value.Username;
            this.TextBox_password.Text = value.Password;
            this.TextBox_name.Text = value.Name;
            this.TextBox_address.Text = value.Address;
            this.TextBox_tele.Text = value.Telenum;
            this.DropDownList_gender.SelectedValue = value.Gender.ToString();
            this.DropDownList_admin.SelectedValue = value.Admin.ToString();

        }

        get
        {
            User tmp = new User();
            tmp.Username = this.TextBox_username.Text;
            tmp.Password = this.TextBox_password.Text;
            tmp.Name = this.TextBox_name.Text;
            tmp.Address = this.TextBox_address.Text;
            tmp.Telenum = this.TextBox_tele.Text;
            tmp.Gender = char.Parse(this.DropDownList_gender.SelectedValue);
            tmp.Admin = char.Parse(this.DropDownList_admin.SelectedValue);
            return tmp;
        }
    }
}