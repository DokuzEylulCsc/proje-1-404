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
        private string[] tahmini=new string[200];

        public string kullaniciad //kullanıcı adı get ve set
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

        public string zorlukderecesi//zorluk derecesi get ve set
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
        public string[] tahmin //tahmin get ve set
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

        public Oyuncu()
        {

        }
        public Oyuncu(string zorlukDerecesi)
        {
            this.zorlukDerecesi =zorlukDerecesi;
        }
        public Oyuncu(string kullaniciAd,string zorlukDerecesi,string[] tahmini)
        {
            this.kullaniciAd = kullaniciAd;
            this.tahmini = tahmini;
            this.zorlukDerecesi = zorlukDerecesi;
        }
        public Oyuncu(string zorlukDerecesi, string[] tahmini)
        {
            this.tahmini = tahmini;
            this.zorlukDerecesi = zorlukDerecesi;
        }
    }
}


