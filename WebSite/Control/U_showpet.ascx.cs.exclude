using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ttxy.Model;
using ttxy.Funcs;

public partial class Control_U_showpet : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public Pet petinfo
    {
        set
        {
            if (value != null)
            {
                this.Image_pet.ImageUrl = MyDataContext.imageURL + value.Image0;
                this.Label_name.Text = value.Name;
                this.Label_birth.Text = value.Birth.ToShortDateString();
                if (value.Gender == '0')
                {
                    this.Label_gender.Text = "Female";
                }
                else if (value.Gender == '1')
                {
                    this.Label_gender.Text = "Male";
                }
                else
                {
                    this.Label_gender.Text = "Other";
                }
                SqlFuns sf = new SqlFuns();
                Species sp = sf.SearchSpeciesById(value.Species);
                this.Label_species.Text = sp.Name;
            }
        }
    }
}