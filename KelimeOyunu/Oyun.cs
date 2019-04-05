using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    class Oyun : Oyuncu
    {
        ////private static string kullaniciAd;
        ////private static string zorlukDerecesi;
        ////private static tahmi

        public Oyun()
        {

        }
        public Oyun(string kullaniciAd,string zorlukDerecesi,string tahmin):base(kullaniciAd,zorlukDerecesi,tahmin)
        {

        }

        public void basla()
        {

            // if (tahmin doğru çıkana kadar tahmin etme)
            {
                Console.WriteLine("Adınızı giriniz");
                kullaniciad = Console.ReadLine();

                Console.WriteLine("Zorluk derecesini giriniz (kolay-orta-zor)");
                zorlukderecesi = Console.ReadLine();

                
                Console.WriteLine("Tahmininizi giriniz");
                tahmin = Console.ReadLine();
                AI b = new AI(zorlukderecesi, tahmin);
               
                

            }

            
        }
    }


}

