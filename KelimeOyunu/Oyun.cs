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
                   Console.Write(secilen[0] );
                   Console.Write(secilen[1] );
                  Console.Write(secilen[2] );
                Console.Write(secilen[3] );
                   Console.Write(secilen[4] );
                   Console.Write(secilen[5] );
                    Console.Write(secilen[6] );
                   Console.Write(secilen[7] );
                  Console.Write(secilen[8] );
                   Console.Write(secilen[9] );
                   
                    Console.WriteLine("Tahmininizi giriniz");
                    tahmin[i] = Console.ReadLine();
                    b.ipucuVer(tahmin[i], secilen[j]);
                   
                }
                
               
            }
            
        }

        public void bitir()
        {
            if (j == 9)
            {
                Console.WriteLine("Oyun bitti!");
            }
        }

      
    }


}

