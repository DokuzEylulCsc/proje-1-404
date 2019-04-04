using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    class AI : Oyuncu
    {
        Random r = new Random();
        private static string kullaniciAd;
        private static string zorlukDerecesi;

        public AI(string isim, string zorluk) : base(kullaniciAd, zorlukDerecesi)
        {
            isim = base.kullaniciad;
            zorluk = base.zorlukderecesi;

        }

        public void kelimeleriAl(Kelime kelime)
        {
            if (zorlukderecesi == "kolay")
            {

            }

            if (zorlukderecesi == "orta")
            {

            }

            if (zorlukderecesi == "zor")
            {

            }
        }

    }
}