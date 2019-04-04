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
        private string tahmini;
        

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
        public string tahmin
        {
            get
            {
                return tahmini;
            }
            set
            {
                tahmini = value;
            }
        }


        public Oyuncu(string kullaniciAd)
        {
            this.kullaniciAd = kullaniciAd;
        }
        public Oyuncu(string zorlukDerecesi,string tahmini)
        {
            this.tahmini = tahmini;
            this.zorlukDerecesi = zorlukDerecesi;
        }

    }

}


