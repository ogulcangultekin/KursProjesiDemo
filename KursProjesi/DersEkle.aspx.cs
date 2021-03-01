using BusinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KursProjesi
{
    public partial class DersEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            EntityDers ent = new EntityDers();
            ent.dersAd = txtDersAd.Text;
            ent.dersUcret = Convert.ToInt32(txtDersUcret.Text);
            BLL_Ders.dersEkleBLL(ent);
            Response.Redirect("Ogrenciler.aspx");
        }
    }
}