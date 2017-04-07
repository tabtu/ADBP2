using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ttxy.Model;
using ttxy.Funcs;
using ttxy;

public partial class Control_U_pet : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UsFuns uf = new UsFuns();
            bindkind(uf.GetSpeciesList());
        }
    }

    public void bindkind(IList<Species> tmp)
    {
        PagedDataSource pds = new PagedDataSource();
        if (tmp != null)
        {
            pds.DataSource = tmp;
            this.DropDownList_species.DataSource = pds;
            this.DropDownList_species.DataTextField = "Name";
            this.DropDownList_species.DataValueField = "Id";
            this.DropDownList_species.DataBind();
        }
    }

    public Pet pet
    {
        set
        {
            this.Label_id.Text = value.ID.ToString();
            this.Label_owener.Text = value.Usid;
            this.TextBox_name.Text = value.Name;
            this.TextBox_birth.Text = value.Birth.ToShortDateString();
            this.DropDownList_gender.SelectedValue = value.Gender.ToString();
            this.DropDownList_species.SelectedValue = value.Species.ToString();
            this.Label_image0.Text = value.Image0;
            this.Image_0.ImageUrl = MyDataContext.imageURL + value.Image0;
        }

        get
        {
            Pet tmp = new Pet();

            tmp.ID = int.Parse(this.Label_id.Text);
            tmp.Usid = this.Label_owener.Text;
            tmp.Name = this.TextBox_name.Text;
            tmp.Birth = DateTime.Parse(this.TextBox_birth.Text);
            tmp.Gender = char.Parse(this.DropDownList_gender.SelectedValue);
            tmp.Species = int.Parse(this.DropDownList_species.SelectedValue);
            tmp.Image0 = this.Label_image0.Text;

            return tmp;
        }
    }

    protected void Upload_Click(object sender, EventArgs e)
    {
        string[] temp = FileUpload_image0.FileName.Split('.');
        string filename = DateTime.Now.ToBinary().ToString() + "." + temp[temp.Length - 1];

        Service c = new Service();
        if (c.UploadStream(FileUpload_image0.PostedFile.InputStream, filename))
        {
            this.Label_image0.Text = filename;
            this.Image_0.ImageUrl = MyDataContext.imageURL + filename;
            //this.Label_fix_tip.Text = "文件上传成功";
            Response.Write("<script language='javascript'>alert('Upload Successfully.');</script>");
        }
        else
        {
            //this.Label_fix_tip.Text = "文件上传失败";
            Response.Write("<script language='javascript'>alert('Failed, Please Connect System Manager.');</script>");
        }
    }
}