using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data;

namespace KursProjesi
{
    public partial class Dersler : System.Web.UI.Page
    {
        string ucret;
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ogrenciID"].ToString());
            TextBox2.Text = x.ToString();
            TextBox2.Enabled = false;
            if (Page.IsPostBack==false)
            {
                List<EntityDers> ent = BLL_Ders.dersListeleBLL();
                DropDownList1.DataSource = BLL_Ders.dersListeleBLL();
                DropDownList1.DataTextField = "dersAD";
                DropDownList1.DataValueField = "dersUcret";
                DropDownList1.DataBind();
                
            }
        
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Baglanti.bgl.Close();
            EntityOgrenci ent = new EntityOgrenci();
            ent.ogrenciDers = DropDownList1.SelectedItem.Text;
            ent.ogrenciID = Convert.ToInt32(TextBox2.Text);
            ent.ogrenciBorc = DropDownList1.SelectedValue.ToString();
            SqlCommand komut5 = new SqlCommand("Update tbl_Ogrenci Set ogrDers=@p1, ogrBORC=@p2 where ogrID=@p3 ", Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            
            komut5.Parameters.AddWithValue("@p1", ent.ogrenciDers.ToString());
            komut5.Parameters.AddWithValue("@p2", ent.ogrenciBorc);
            komut5.Parameters.AddWithValue("@p3", ent.ogrenciID);

            komut5.ExecuteNonQuery();
            Baglanti.bgl.Close();
            //TextBox1.Text = DropDownList1.SelectedValue.ToString();
            //EntityBasvuruForm ent = new EntityBasvuruForm();
            //ent.ogrenciID = int.Parse(TextBox1.Text);
            //ent.dersID = int.Parse(DropDownList1.SelectedValue.ToString());
            //BLL_Ders.TalepEkleBLL(ent);
        }
    }
}