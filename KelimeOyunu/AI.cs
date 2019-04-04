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
        string[] kolay = Kelime.kolayKelimeGonder();
        string [] orta = Kelime.ortaKelimeGonder();
        string[] zor = Kelime.zorKelimeGonder();

        private static string kullaniciAd;
        private static string zorlukDerecesi;

        public AI(string isim, string zorluk) : base(kullaniciAd, zorlukDerecesi)
        {
            isim = base.kullaniciad;
            zorluk = base.zorlukderecesi;

        }
        public static string [] rasgeleKolay;
        public static string[] rasgeleOrta;
        public static string[] rasgeleZor;
        public void kelimeSec()
        {
            if (zorlukderecesi == "kolay")
            {
                for(int i=0;i<10;i++)
                {
                    int randomIndex = r.Next(0, kolay.Length);
                    rasgeleKolay[i] = kolay[randomIndex];
                }

            }

            if (zorlukderecesi == "orta")
            {
                for (int i = 0; i < 10; i++)
                {
                    int randomIndex = r.Next(0, orta.Length);
                    rasgeleOrta[i] = orta[randomIndex];
                }
            }

            if (zorlukderecesi == "zor")
            {
                for (int i = 0; i < 10; i++)
                {
                    int randomIndex = r.Next(0, orta.Length);
                    rasgeleOrta[i] = orta[randomIndex];
                }
            }
        }

    }
}