using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class BLL_Ogrenci
    {
        public static int ogrenciEkleBLL(EntityOgrenci p)
        {
            if (p.ogrenciAd != null && p.ogrenciSoyad != null && p.ogrenciNumara != null && p.ogrenciMail != null && p.ogrenciTelefon != null && p.ogrenciSifre != null)
            {
                return DAL_Ogrenci.ogrenciEkle(p);
            }
            else
            {
                return -1;
            }
        }
        public static List<EntityOgrenci> ogrenciListeleBLL()
        {
            return DAL_Ogrenci.ogrenciListele();
        }
        public static bool ogrenciSilBLL(int sil)
        {
            if (sil>=0)
            {
                return DAL_Ogrenci.OgrenciSil(sil);
            }
            return false;
        }

        public static List<EntityOgrenci> ogrenciDetayBLL(int p)
        {
            return DAL_Ogrenci.ogrenciDetay(p);
        }
        public static bool ogrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.ogrenciID > 0 && p.ogrenciAd!="" && p.ogrenciSoyad!="" &&p.ogrenciNumara!="" &&p.ogrenciMail!="" &&p.ogrenciTelefon!=""&& p.ogrenciAd != null && p.ogrenciSoyad != null && p.ogrenciNumara != null && p.ogrenciMail != null && p.ogrenciTelefon != null)
            {
                return DAL_Ogrenci.ogrenciGuncelle(p);
            }
            
                return false;
            
        }
    }
}
