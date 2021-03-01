using BusinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using System.Data.SqlClient;

namespace KursProjesi
{
    public partial class OgrenciKisisel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Baglanti.bgl.Close();
            List<EntityOgrenci> ogrList = new List<EntityOgrenci>();
            int x = Convert.ToInt32(Session["id"].ToString());

            SqlCommand cmd = new SqlCommand("select * from tbl_ogrenci where ogrID like '%" + x + "%'", Baglanti.bgl); ;
            cmd.Parameters.AddWithValue("@id", ID);
            Baglanti.bgl.Open();
            SqlDataReader dr = cmd.ExecuteReader();
          
            while (dr.Read())
            {
                var y = new EntityOgrenci
                {
                    ogrenciID = Convert.ToInt32(dr[0].ToString()),
                    ogrenciAd = dr[1].ToString(),
                    ogrenciSoyad = dr[2].ToString(),
                    ogrenciNumara = dr[3].ToString(),
                    ogrenciMail = dr[4].ToString(),
                    ogrenciTelefon = dr[5].ToString(),
                    ogrenciSifre = dr[6].ToString(),
                    ogrenciDers = dr[7].ToString()
                };
                ogrList.Add(y);

            }

           
            Repeater1.DataSource = ogrList;
            Repeater1.DataBind();
            Baglanti.bgl.Close();
        }
    }
}