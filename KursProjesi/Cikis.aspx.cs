﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KursProjesi
{
    public partial class Cikis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("anasayfa.aspx");

            //SqlCommand komut1 = new SqlCommand("select * from tbl_Ogrenci where ogrNUMARA=@p1", Baglanti.bgl);
            //komut1.Parameters.AddWithValue("@p1", txtLogin.Text);
            //if (komut1.Connection.State != ConnectionState.Open)
            //{
            //    komut1.Connection.Open();
            //}
            //SqlDataReader dr = komut1.ExecuteReader();
            //if (dr.Read())
            //{
            //    if (dr[6].ToString() == txtLoginSifre.Text)
            //    {

            //        Session.Add("kullanici", txtLogin.Text);
            //        Session.Add("id", dr[0].ToString());
            //        Baglanti.bgl.Close();
            //        Response.Redirect("OgrenciKisisel.aspx");
            //    }

            //}
            //else
            //{

            //    Label1.Text = "Hatali giris";
            //    Label1.Visible = true;
            //}

            //Baglanti.bgl.Close();


        }
    }
}