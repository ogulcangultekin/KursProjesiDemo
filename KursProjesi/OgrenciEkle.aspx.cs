using EntityLayer;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KursProjesi
{
    public partial class Ogrenciler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.ogrenciAd = txtAd.Text;
            ent.ogrenciSoyad = txtSoyad.Text;
            ent.ogrenciNumara = txtNumara.Text;
            ent.ogrenciMail = txtMail.Text;
            ent.ogrenciTelefon = txtTelefon.Text;
            ent.ogrenciSifre = txtSifre.Text;
            ent.ogrenciKalan = Convert.ToString(0);
            BLL_Ogrenci.ogrenciEkleBLL(ent);
            Response.Redirect("Ogrenciler.aspx");
        }
    }
}