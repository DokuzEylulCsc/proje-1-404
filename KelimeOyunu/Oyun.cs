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
        public static int j = 0;
        public Oyun()
        {

        }
        public Oyun(string kullaniciAd,string zorlukDerecesi,string[] tahmin):base(kullaniciAd,zorlukDerecesi,tahmin)
        {

        }

        public void basla()
        {
            
            {
                Console.WriteLine("Adınızı giriniz");
                kullaniciad = Console.ReadLine();

                Console.WriteLine("Zorluk derecesini giriniz (kolay-orta-zor)");
                zorlukderecesi = Console.ReadLine();
                
                    
                
                AI b = new AI(zorlukderecesi);
                b.kelimeSec();

               
               
                string[] secilen = b.kelimeSec().ToArray();

                for (int i = 0; j!=10 && b.dogruMu(tahmin[i], secilen[j]) == false; i++)
                {
                //    Console.WriteLine(secilen[0]);
                //    Console.WriteLine(secilen[1]);
                //    Console.WriteLine(secilen[2]);
                //    Console.WriteLine(secilen[3]);
                //    Console.WriteLine(secilen[4]);
                //    Console.WriteLine(secilen[5]);
                //    Console.WriteLine(secilen[6]);
                //    Console.WriteLine(secilen[7]);
                //    Console.WriteLine(secilen[8]);
                //    Console.WriteLine(secilen[9]);
                   
                    Console.WriteLine("Tahmininizi giriniz");
                    tahmin[i] = Console.ReadLine();
                    b.ipucuVer(tahmin[i], secilen[j]);
                   
                }
                
               
            }
            
        }

      
    }


}

