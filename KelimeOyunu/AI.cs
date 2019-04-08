using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    class AI : Oyuncu
    {
        public static int s = 0;
        public AI(string zorlukderecesi, string[] tahmini) : base(zorlukderecesi, tahmini)
        {

        }

        public AI(string zorlukderecesi) : base(zorlukderecesi)
        {

        }
        Random r = new Random();
        string[] kolay = Kelime.kolayKelimeGonder();//Kelime classından kelimeleri çekmek için.
        string[] orta = Kelime.ortaKelimeGonder();
        string[] zor = Kelime.zorKelimeGonder();
        public static string[] rasgeleKolay = new string[10];
        public static string[] rasgeleOrta = new string[10];
        public static string[] rasgeleZor = new string[10];

        public static string[] secilenKelime = new string[10];
        public string gecici;
        public string[] kelimeSec()//rasgele 10 kelime seçme
        {
            if (zorlukderecesi == "kolay")
            {
                int[] randomIndex = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    for (int z = i + 1; z < 10; z++)
                    {
                        randomIndex[i] = r.Next(0, kolay.Length);//kolay dizisine rasgele atama yapabilmek için 0'dan 50'ye kadar 10 sayı üretip onu dizinin indisine yazdık. 
                        if (randomIndex[i] == randomIndex[z])
                        {
                            randomIndex[i] = r.Next(0, kolay.Length);
                        }
                    }
                    secilenKelime[i] = kolay[randomIndex[i]];
                }
            }

            if (zorlukderecesi == "orta")
            {
                int[] randomIndex = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    for (int z = i + 1; z < 10; z++)
                    {
                        randomIndex[i] = r.Next(0, orta.Length);//orta dizisine rasgele atama yapabilmek için 0'dan 50'ye kadar 10 sayı üretip onu dizinin indisine yazdık. 
                        if (randomIndex[i] == randomIndex[z])
                        {
                            randomIndex[i] = r.Next(0, orta.Length);
                        }
                    }
                    secilenKelime[i] = orta[randomIndex[i]];
                }
            }

            if (zorlukderecesi == "zor")
            {
                int[] randomIndex = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    for (int z = i + 1; z < 10; z++)
                    {
                        randomIndex[i] = r.Next(0, zor.Length);//zor dizisine rasgele atama yapabilmek için 0'dan 50'ye kadar 10 sayı üretip onu dizinin indisine yazdık. 
                        if (randomIndex[i] == randomIndex[z])
                        {
                            randomIndex[i] = r.Next(0, zor.Length);
                        }
                    }
                    secilenKelime[i] = zor[randomIndex[i]];
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    int min;
                    min = secilenKelime[i].Length;//kullanıcıya kelimelerin küçükten büyüğe şeklinde sıralı çıkması
                    if (secilenKelime[i].Length > secilenKelime[j].Length)
                    {
                        gecici = secilenKelime[i];
                        secilenKelime[i] = secilenKelime[j];
                        secilenKelime[j] = gecici;
                    }
                }
            }
            return secilenKelime;
        }

        public static int[] sayac = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public void kelimeyazdir()
        {
            Console.WriteLine(secilenKelime[0]);
        }
        public bool dogruMu(string tahmin, string kelime)
        {
            if (tahmin == kelime)
            {
                return true;
            }
            else
            {
                sayac[Oyun.j]++;//tahmin sayısını bulmak için bir sayaç
                return false;
            }
        }


        public void ipucuVer(string tahmini, string kelime)
        {
            char[] tahminChar = tahmini.ToCharArray();//Girilen tahminin harflere ayrılarak bir diziye aktarılması
                                                     // bu sayede doğru bilip bilmediğini öğrenip ona göre ipucu verme
            char[] kelimeChaar = kelime.ToCharArray();
            if (tahmini == kelime)
            {
                Console.WriteLine("Doğru bildiniz tebrikler!!");
                Oyun.j++; //Doğru bilince yeni kelimeye geçmesi
                Console.Clear();
                
                if (Oyun.j <= 9)
                {
                    Console.WriteLine("{0}.kelimeyi tahmin ediniz.", (Oyun.j + 1));
                }
            }
            else
            {
                Console.WriteLine("Eşlesme sağlayan karakterler");
                for (int i = 0; i < tahminChar.Length; i++)
                {
                    for (int j = 0; j < kelimeChaar.Length; j++)
                    {
                        if (tahminChar[i] == kelimeChaar[j])//harfleri ve...
                        {
                            if (i == j) //..indisleride aynıysa eşleşme sağlamış demektir.
                            {
                                Console.Write("{0}" + "------->", tahminChar[i]);
                            }
                        }
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine("Sözcükten yer alan karakterler ");

                for (int j = 0; j < kelimeChaar.Length; j++)
                {
                    if (tahminChar.Contains(kelimeChaar[j]))
                    {
                        Console.WriteLine(" {0} " + "-------->", kelimeChaar[j]);
                    }
                }

            }
        }
    }
}