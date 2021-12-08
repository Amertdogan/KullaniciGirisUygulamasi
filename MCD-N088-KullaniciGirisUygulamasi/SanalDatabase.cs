using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_N088_KullaniciGirisUygulamasi
{
   public class SanalDatabase
    {
        public static List<Kulanici> KullaniciTaplosu = new List<Kulanici>();

        static SanalDatabase()
        {
            KullaniciTaplosu.Add(new Kulanici()
            {
                Id = 1,
                isim = "Ali Mert",
                soyisim = "Doğan",
                kullaniciAdi = "ali.mert",
                sifre = "Mersin330",
                aciklama = "Ali Mert Kullanici profil bilgisi"
            });
            KullaniciTaplosu.Add(new Kulanici()
            {
                Id = 2,
                isim = "Esra ",
                soyisim = "Alkan",
                kullaniciAdi = "esra.alkan",
                sifre = "Sivas580",
                aciklama = "Esra Alkan Kullanici profil bilgisi"
            });
        }
    }
}
