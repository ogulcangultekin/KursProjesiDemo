using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class BLL_Ders
    {
        public static int dersEkleBLL(EntityDers p)
        {
            if (p.dersAd != null && p.dersUcret>0)
            {
                return DAL_Ders.dersEkle(p);
            }
            else
            {
                return -1;
            }
        }
        public static List<EntityDers> dersListeleBLL()
        {
            return DAL_Ders.dersListele();
        }
        //public static int TalepEkleBLL(EntityBasvuruForm p)
        //{
        //    if(p.ogrenciID !=null && p.dersID !=null)
        //    {
        //        return DAL_Ders.TalepEkle(p);
        //    }
        //    return -1;
        //}


    }
}
