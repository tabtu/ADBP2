using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ttxy.Model;
using ttxy.Funcs;

public partial class ShowInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["login"] == null)
            {
                Response.Write("<script language='javascript'>alert('Response Timeout, Please Try Again.'); location.href='login.aspx'</script>");
            }
            else
            {
                SqlFuns sf = new SqlFuns();
                IList<Pet> pets = sf.SearchPetByUsrid(Session["login"].ToString());
                bindpet(pets);
                DropDownList_pet_SelectedIndexChanged(sender, e);
            }
        }
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

    protected void DropDownList_pet_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlFuns sf = new SqlFuns();
        IList<Pet> pets = sf.SearchPetByUsrid(Session["login"].ToString());
        this.U_showpet1.petinfo = pets[DropDownList_pet.SelectedIndex];
        IList<Services> pslist = sf.SearchServicesByPeid(pets[DropDownList_pet.SelectedIndex].ID);
        if (pslist != null )
        {
            this.U_showmsg1.msgdata = pslist;
            DateTime ndt = pslist[0].Date.AddHours(sf.SearchOperationById(pslist[0].Operation).NextTime);
            this.Label_lasttime.Text = ndt.ToString();
        }
        else
        {
            this.Label_lasttime.Text = "";
        }
    }

    public string Get_y()
    {
        if (this.Label_lasttime.Text != "")
        {
            DateTime tmp = DateTime.Parse(this.Label_lasttime.Text);
            return tmp.Year.ToString();
        }
        else
        {
            return DateTime.Now.Year.ToString();
        }
    }

    public string Get_m()
    {
        if (this.Label_lasttime.Text != "")
        {
            DateTime tmp = DateTime.Parse(this.Label_lasttime.Text);
            return tmp.Month.ToString();
        }
        else
        {
            return DateTime.Now.Month.ToString();
        }
    }

    public string Get_d()
    {
        if (this.Label_lasttime.Text != "")
        {
            DateTime tmp = DateTime.Parse(this.Label_lasttime.Text);
            return tmp.Day.ToString();
        }
        else
        {
            return DateTime.Now.Day.ToString();
        }
    }

    public string Get_h()
    {
        if (this.Label_lasttime.Text != "")
        {
            DateTime tmp = DateTime.Parse(this.Label_lasttime.Text);
            return tmp.Hour.ToString();
        }
        else
        {
            return DateTime.Now.Hour.ToString();
        }
    }

    public string Get_mt()
    {
        if (this.Label_lasttime.Text != "")
        {
            DateTime tmp = DateTime.Parse(this.Label_lasttime.Text);
            return tmp.Minute.ToString();
        }
        else
        {
            return DateTime.Now.Minute.ToString();
        }
    }

    public string Get_s()
    {
        if (this.Label_lasttime.Text != "")
        {
            DateTime tmp = DateTime.Parse(this.Label_lasttime.Text);
            return tmp.Second.ToString();
        }
        else
        {
            return DateTime.Now.Second.ToString();
        }
    }
}