using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;
namespace DataAccessLayer
{
    public class DAL_Ogrenci
    {

        public static int ogrenciEkle(EntityOgrenci ogrenci)
        {

            SqlCommand komut1 = new SqlCommand("insert into tbl_Ogrenci (ogrAD,ogrSOYAD,ogrNumara,ogrMAIL,ogrTELEFON,ogrSIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", ogrenci.ogrenciAd);
            komut1.Parameters.AddWithValue("@p2", ogrenci.ogrenciSoyad);
            komut1.Parameters.AddWithValue("@p3", ogrenci.ogrenciNumara);
            komut1.Parameters.AddWithValue("@p4", ogrenci.ogrenciMail);
            komut1.Parameters.AddWithValue("@p5", ogrenci.ogrenciTelefon);
            komut1.Parameters.AddWithValue("@p6", ogrenci.ogrenciSifre);
            //komut1.Parameters.AddWithValue("@p7", ogrenci.ogrenciBorc);
            //komut1.Parameters.AddWithValue("@p8", ogrenci.ogrenciKalan);
            return komut1.ExecuteNonQuery();

        }
        public static List<EntityOgrenci> ogrenciListele()
        {
         
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("Select * from tbl_Ogrenci", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ogrenciID = Convert.ToInt32(dr["ogrID"].ToString());
                ent.ogrenciAd = dr["ogrAD"].ToString();
                ent.ogrenciSoyad = dr["ogrSOYAD"].ToString();
                ent.ogrenciNumara = dr["ogrNUMARA"].ToString();
                ent.ogrenciMail = dr["ogrMAIL"].ToString();
                ent.ogrenciTelefon = dr["ogrTELEFON"].ToString();
                ent.ogrenciSifre = dr["ogrSIFRE"].ToString();
                ent.ogrenciDers = dr["ogrDERS"].ToString();
                ent.ogrenciBorc = dr["ogrBORC"].ToString();
                ent.ogrenciKalan = dr["ogrKALAN"].ToString();
                ent.ogrenciTime =dr["ogrTIME"].ToString();

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static  bool OgrenciSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete From tbl_Ogrenci where ogrID=@p1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }

            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery()>0;
        }

        public static List<EntityOgrenci> ogrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("Select * from tbl_Ogrenci where ogrID=@p1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1",id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ogrenciAd = dr["ogrAD"].ToString();
                ent.ogrenciSoyad = dr["ogrSOYAD"].ToString();
                ent.ogrenciNumara = dr["ogrNUMARA"].ToString();
                ent.ogrenciMail = dr["ogrMAIL"].ToString();
                ent.ogrenciTelefon = dr["ogrTELEFON"].ToString();
                ent.ogrenciSifre = dr["ogrSIFRE"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool ogrenciGuncelle(EntityOgrenci ogrenci)
        {
            SqlCommand komut5 = new SqlCommand("Update tbl_Ogrenci Set ogrAD=@p1,ogrSOYAD=@p2, ogrNUMARA=@p3,ogrMAIL=@p4,ogrTELEFON=@p5 where ogrID=@p8 ",Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@p1", ogrenci.ogrenciAd);
            komut5.Parameters.AddWithValue("@p2", ogrenci.ogrenciSoyad);
            komut5.Parameters.AddWithValue("@p3", ogrenci.ogrenciNumara);
            komut5.Parameters.AddWithValue("@p4", ogrenci.ogrenciMail);
            komut5.Parameters.AddWithValue("@p5", ogrenci.ogrenciTelefon);
            komut5.Parameters.AddWithValue("@p8", ogrenci.ogrenciID);
            return komut5.ExecuteNonQuery() > 0;
            Baglanti.bgl.Close();
        }
    }
}
