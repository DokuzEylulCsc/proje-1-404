using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    class Oyuncu
    {
        //Oyuncu bilgileri ve oyunun zorluk derecesi
        private string kullaniciAd;
        private string zorlukDerecesi;
        private int harfSayisi;

        public string kullaniciad
        {
            get
            {
                return kullaniciAd;
            }
            set
            {
                kullaniciAd = value;
            }
        }

        public string zorlukderecesi
        {
            get
            {
                return zorlukDerecesi;
            }

            set
            {
                zorlukDerecesi = value;
            }
        }

        public int Harfsayisi
        {
            get
            {
                return harfSayisi;
            }
            set
            {
                if (value > 2 && value <= 12)
                    harfSayisi = value;
                else
                    Console.WriteLine("Harf Sayısı 2 ile 12 arası olmalıdır.");
            }
        }

        public Oyuncu(string kullaniciAd,string zorlukDerecesi,int harfSayisi)
        {
            this.kullaniciAd = kullaniciAd;
            this.zorlukDerecesi = zorlukDerecesi;
            this.harfSayisi = harfSayisi;
        }
    }
}
