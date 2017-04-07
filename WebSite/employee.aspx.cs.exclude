using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ttxy.Funcs;
using ttxy.Model;

public partial class Emplyee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UsFuns uf = new UsFuns();
            User tmp = uf.UsrInfo(Session["login"].ToString());
            if (Session["login"] == null)
            {
                Response.Write("<script language='javascript'>alert('Response Timeout, Please Try Again.'); location.href='login.aspx'</script>");
            }
            else if (tmp.Admin == '2')
            {
                this.U_service1.Visible = false;
                this.U_showmsg1.Visible = false;
                this.U_showpet1.Visible = false;
                this.Button_submit.Visible = false;
                this.DropDownList_pet.Visible = false;
                SqlFuns sf = new SqlFuns();
                bindusr(sf.SearchUserByPermission('1'));
            }
            else
            {
                Response.Write("<script language='javascript'>alert('Response Timeout, Please Try Again.'); location.href='login.aspx'</script>");
            }
        }
    }

    protected void show_usr(object sender, CommandEventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        bindpet(sf.SearchPetByUsrid(e.CommandName.ToString()));
        this.DropDownList_pet.Visible = true;
        DropDownList_pet_SelectedIndexChanged(sender, e);
    }

    public void bindpet(IList<Pet> tmp)
    {
        PagedDataSource pds = new PagedDataSource();
        if (tmp != null)
        {
            pds.DataSource = tmp;
            this.DropDownList_pet.DataSource = pds;
            this.DropDownList_pet.DataTextField = "Name";
            this.DropDownList_pet.DataValueField = "Id";
            this.DropDownList_pet.DataBind();
        }
    }

    public void bindusr(IList<User> tmp)
    {
        PagedDataSource pds = new PagedDataSource();
        if (tmp != null)
        {
            pds.DataSource = tmp;
            this.Repeater_usrlist.DataSource = pds;
            this.Repeater_usrlist.DataBind();
        }
    }

    protected void Button_submit_Click(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        Services tmp = this.U_service1.services;
        tmp.Date = DateTime.Now;
        tmp.Peid = int.Parse(this.DropDownList_pet.SelectedValue);
        int result = sf.AddServices(tmp);
        if (result > 0)
        {
            Response.Write("<script language='javascript'>alert('Submit Successfully.');</script>");
            //Response.Redirect("manager.aspx");
        }
        else
        {
            Response.Write("<script language='javascript'>alert('Failed, Please Connect System Manager.');</script>");
        }
    }

    protected void DropDownList_pet_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        Pet ptmp = sf.SearchPetById(int.Parse(DropDownList_pet.SelectedValue));
        this.U_showpet1.petinfo = ptmp;
        this.U_showpet1.Visible = true;
        this.U_service1.Visible = true;
        this.Button_submit.Visible = true;
        IList<Services> pslist = sf.SearchServicesByPeid(ptmp.ID);
        if (pslist != null)
        {
            this.U_showmsg1.Visible = true;
            this.U_showmsg1.msgdata = pslist;
            DateTime ndt = pslist[0].Date.AddHours(sf.SearchOperationById(pslist[0].Operation).NextTime);
        }
        else
        {
            
        }
    }
}