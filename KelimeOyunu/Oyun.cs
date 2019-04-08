using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    class Oyun : Oyuncu
    {
        
        public static int j = 0;
        public Oyun()
        {

        }
        public Oyun(string kullaniciAd,string zorlukDerecesi,string[] tahmin):base(kullaniciAd,zorlukDerecesi,tahmin)
        {

        }
        public static string zorlukd;
        public static string tercih;
        // public static bool yeniden()
        //{
        //    if (tercih == "Yeni")
        //    {
                
        //        return true;
                
        //    }
        //    if (tercih == "yeni")
        //    {
                
        //        return true;
        //    }
        //    else return false;

        //}
        public bool yenidenBasla() // Kullanıcının tercihine göre oyunu yeniden başlatma, 
                                  //ilk bir oyun oynadıysa eski ayarlarla oynamaya devam etme ve oyunu bitirme 
        {
            Console.WriteLine("Yeni oyunla başlamak için (yeni), ilk oynadıysanız ilk(eski) oyun ayarlarla devam etmek mi? Yada bitirmek mi?(yeni-eski-bitir)");
            tercih = Console.ReadLine();

            if (tercih == "yeni" || tercih=="Yeni")
            {
                yeniBasla();
                return true;
            }

            if (tercih == "eski" || tercih == "Eski")
            {
            
                eskiBasla();
                return true;
            }
            if(tercih=="bitir"||tercih=="Bitir")
            {
                Console.WriteLine("Oyun bitti!");
                return false;
            }
            else
            return false;
        }

        public void yeniBasla() //yeni oyuna başlama metodu
        {
            {
                Console.WriteLine("Adınızı giriniz");
                kullaniciad = Console.ReadLine();

                Console.WriteLine("Zorluk derecesini giriniz (kolay-orta-zor)");
                zorlukderecesi = Console.ReadLine();

                zorlukd = zorlukderecesi;
                
                AI b = new AI(zorlukderecesi);
                b.kelimeSec();
                
                string[] secilen = b.kelimeSec().ToArray(); //AI classında rastgele seçtiğimiz 10 kelimenin Oyun classına aktarımı için

                for (int i = 0; j!=10 && b.dogruMu(tahmin[i], secilen[j]) == false; i++) //kullanıcının tahmini ile seçilen kelime birbirini tutmadığı sürece tahmin almaya devam etme
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
                   
                    Console.WriteLine("{0} harfli kelime için tahmininizi giriniz",secilen[j].Length);
                    tahmin[i] = Console.ReadLine();
                    if (tahmin[i].Length != secilen[j].Length)
                    {
                        Console.WriteLine("Lütfen {0} karakterli tahmin giriniz", secilen[j].Length);
                    }
                    else
                    {
                        b.ipucuVer(tahmin[i], secilen[j]); //AI'daki ipucu verme metodu.
                    }
                }
            }
            j = 0;
        }

        public void eskiBasla() //bir önceki oyunun zorluk derecesi ayarlarıyla oynama metofu
        {
                AI b = new AI(zorlukd);
                b.kelimeSec();

                string[] secilen = b.kelimeSec().ToArray();//AI classında rastgele seçtiğimiz 10 kelimenin Oyun classına aktarımı için

            for (int i = 0; j != 10 && b.dogruMu(tahmin[i], secilen[j]) == false; i++) //kullanıcının tahmini ile seçilen kelime birbirini tutmadığı sürece tahmin almaya devam etme
            {
                    Console.Write(secilen[0]);
                    Console.Write(secilen[1]);
                    Console.Write(secilen[2]);
                    Console.Write(secilen[3]);
                    Console.Write(secilen[4]);
                    Console.Write(secilen[5]);
                    Console.Write(secilen[6]);
                    Console.Write(secilen[7]);
                    Console.Write(secilen[8]);
                    Console.Write(secilen[9]);

                    Console.WriteLine("{0}"+"harfli tahmininizi giriniz",secilen[j].Length);
                    tahmin[i] = Console.ReadLine();
                    if (tahmin[i].Length != secilen[j].Length)
                    {
                        Console.WriteLine("Lütfen {0} karakterli tahmin giriniz", secilen[j].Length);
                    }
                    else
                    {
                        b.ipucuVer(tahmin[i], secilen[j]); //AI'daki ipucu verme metodu.
                }
                }
            
            j = 0;
        }
    }
    
}

