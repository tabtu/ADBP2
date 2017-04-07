using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ttxy.Model;
using ttxy.Funcs;
public partial class InsertInfo : System.Web.UI.Page
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
            else if (tmp.Admin == '0')
            {
                SqlFuns sf = new SqlFuns();
                bindusr(sf.SearchUserAll());
            }
            else
            {
                Response.Write("<script language='javascript'>alert('Response Timeout, Please Try Again.'); location.href='login.aspx'</script>");
            }
        }
    }

    protected void Button_update_Click(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        int result = sf.EditUser(this.U_usr1.user);
        if (result > 0)
        {
            Response.Write("<script language='javascript'>alert('Update Successfully.'); location.href='manager.aspx'</script>");
        }
        else
        {
            Response.Write("<script language='javascript'>alert('Failed, Please Connect System Manager.');</script>");
        }
    }

    protected void show_pet(object sender, CommandEventArgs e)
    {
        this.U_pet1.Visible = true;
        SqlFuns sf = new SqlFuns();
        this.U_pet1.pet = sf.SearchPetById(int.Parse(e.CommandName.ToString()));
        this.U_pet1.Visible = true;
        this.Button_update.Visible = true;
        this.Button_submit_pet.Visible = true;
    }

    protected void show_usr(object sender, CommandEventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        bindpet(sf.SearchPetByUsrid(e.CommandName.ToString()));
        this.U_usr1.user = sf.SearchUserById(e.CommandName.ToString());
        this.U_usr1.Visible = true;
        this.U_usr2.Visible = false;
        this.U_pet1.Visible = false;
        this.U_pet1.Visible = false;
        this.Repeater_petlist.Visible = true;
        this.Button_newpet.Visible = true;
        this.Button_update.Visible = true;
        this.Button_submit_pet.Visible = false;
        this.Button_insert.Visible = false;
    }

    public void bindpet (IList<Pet> tmp)
    {
        PagedDataSource pds = new PagedDataSource();
        if (tmp != null)
        {
            pds.DataSource = tmp;
            this.Repeater_petlist.DataSource = pds;
            this.Repeater_petlist.DataBind();
        }
    }

    public void bindusr (IList<User> tmp)
    {
        PagedDataSource pds = new PagedDataSource();
        if (tmp != null)
        {
            pds.DataSource = tmp;
            this.Repeater_usrlist.DataSource = pds;
            this.Repeater_usrlist.DataBind();
        }
    }

    protected void Button_newpet_Click(object sender, EventArgs e)
    {
        Pet newpet = new Pet();
        newpet.Usid = this.U_usr1.user.Username;
        newpet.Name = "Default";
        newpet.Birth = DateTime.Now;
        newpet.Species = 0;
        newpet.Gender = '2';
        newpet.Image0 = "Default.png";
        SqlFuns sf = new SqlFuns();
        int result = sf.AddPet(newpet);
        if (result > 0)
        {
            Response.Write("<script language='javascript'>alert('Create Successfully.'); location.href='manager.aspx</script>");
        }
        else
        {
            Response.Write("<script language='javascript'>alert('Failed, Please Connect System Manager.');</script>");
        }
    }

    protected void Button_newusr_Click(object sender, EventArgs e)
    {
        this.U_usr1.Visible = false;
        this.U_usr2.Visible = true;
        this.U_pet1.Visible = false;
        this.Button_submit_pet.Visible = false;
        this.Button_newpet.Visible = false;
        this.Button_update.Visible = false;
        this.Button_insert.Visible = true;
        this.Repeater_petlist.Visible = false;
    }

    protected void Button_insert_Click(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        int result = sf.AddUser(this.U_usr2.user);
        if (result > 0)
        {
            Response.Write("<script language='javascript'>alert('Create Successfully.'); location.href='manager.aspx</script>");
        }
        else
        {
            Response.Write("<script language='javascript'>alert('Failed, Please Connect System Manager.');</script>");
        }
    }

    protected void Button_submit_pet_Click(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        int result = sf.EditPet(this.U_pet1.pet);
        if (result > 0)
        {
            Response.Write("<script language='javascript'>alert('Create Successfully.'); location.href='manager.aspx</script>");
        }
        else
        {
            Response.Write("<script language='javascript'>alert('Failed, Please Connect System Manager.');</script>");
        }
    }
}