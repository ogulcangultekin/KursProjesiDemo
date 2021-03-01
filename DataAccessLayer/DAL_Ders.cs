using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
namespace DataAccessLayer
{
    public class DAL_Ders
    {
        public static List<EntityDers> dersListele()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut = new SqlCommand("Select * from tbl_Ders", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.dersID = Convert.ToInt32(dr["dersID"].ToString());
                ent.dersAd= dr["dersAD"].ToString();
                
                ent.dersUcret = Convert.ToInt32(dr["dersUcret"].ToString());
              
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }


        public static int dersEkle(EntityDers ders)
        {
            Baglanti.bgl.Close();
            SqlCommand komut1 = new SqlCommand("insert into tbl_Ders (dersAD,dersUcret) values (@p1,@p2)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", ders.dersAd);
            komut1.Parameters.AddWithValue("@p2", ders.dersUcret);
        
            return komut1.ExecuteNonQuery();

        }
        //public static int TalepEkle(EntityBasvuruForm p)
        //{
        //    SqlCommand komut1 = new SqlCommand("insert into tbl_BasvuruFormu(ogrenciID,dersID)values(@p1,@p2)", Baglanti.bgl);
        //    komut1.Parameters.AddWithValue("@p1", p.ogrenciID);
        //    komut1.Parameters.AddWithValue("@p2", p.dersID);
        //    if (komut1.Connection.State != ConnectionState.Open)
        //    {
        //        komut1.Connection.Open();
        //    }
        //    return komut1.ExecuteNonQuery();

        //}


    }
}
