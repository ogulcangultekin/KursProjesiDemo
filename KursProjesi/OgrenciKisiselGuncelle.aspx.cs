using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KursProjesi
{
    public partial class OgrenciKisiselGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Baglanti.bgl.Close();
            int x = Convert.ToInt32(Request.QueryString["ogrenciID"].ToString());
            txtID.Text = x.ToString();
            txtID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> ogrList = BLL_Ogrenci.ogrenciDetayBLL(x);
                txtAd.Text = ogrList[0].ogrenciAd.ToString();
                txtSoyad.Text = ogrList[0].ogrenciSoyad.ToString();
                txtNumara.Text = ogrList[0].ogrenciNumara.ToString();
                txtMail.Text = ogrList[0].ogrenciMail.ToString();
                txtTelefon.Text = ogrList[0].ogrenciTelefon.ToString();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Baglanti.bgl.Close();
            EntityOgrenci ent = new EntityOgrenci();
            ent.ogrenciID = Convert.ToInt32(txtID.Text);
            ent.ogrenciAd = txtAd.Text;
            ent.ogrenciSoyad = txtSoyad.Text;
            ent.ogrenciNumara = txtNumara.Text;
            ent.ogrenciMail = txtMail.Text;
            ent.ogrenciTelefon = txtTelefon.Text;

            BLL_Ogrenci.ogrenciGuncelleBLL(ent);
            Response.Redirect("OgrenciKisisel.aspx");
        }
    }
}