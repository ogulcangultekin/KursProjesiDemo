using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
namespace KursProjesi
{
    public partial class Ogrenciler1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci> ogrList = BLL_Ogrenci.ogrenciListeleBLL();
            Repeater1.DataSource = ogrList;
            Repeater1.DataBind();
        }
    }
}