using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KursProjesi
{
    public partial class OdemeSayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ogrenciID"].ToString());
            txtID.Text = x.ToString();
            txtUcret.Enabled = false;
            txtID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> ogrList = BLL_Ogrenci.ogrenciListeleBLL(); 
                txtUcret.Text = ogrList[0].ogrenciBorc.ToString();
               
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Baglanti.bgl.Close();
            EntityOgrenci ent = new EntityOgrenci();
            int son = Convert.ToInt32(txtUcret.Text) - Convert.ToInt32(txtOdenecek.Text);
            ent.ogrenciBorc = Convert.ToString(son);
            ent.ogrenciID = Convert.ToInt32(txtID.Text);
            ent.ogrenciKalan = txtOdenecek.Text;
            ent.ogrenciTime = "23/01/2021";
            SqlCommand komut5 = new SqlCommand("Update tbl_Ogrenci Set ogrBORC=@p1, ogrKALAN=@p2 ,ogrTIME=@p3 where ogrID=@p4 ", Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }

            komut5.Parameters.AddWithValue("@p2", ent.ogrenciKalan);
            komut5.Parameters.AddWithValue("@p1", ent.ogrenciBorc);
            komut5.Parameters.AddWithValue("@p3", ent.ogrenciTime);
            komut5.Parameters.AddWithValue("@p4", ent.ogrenciID);

            komut5.ExecuteNonQuery();
            Baglanti.bgl.Close();
            Response.Redirect("Ogrenciler.aspx");
        }
    }
}