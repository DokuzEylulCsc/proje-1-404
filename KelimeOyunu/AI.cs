using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    class AI : Oyuncu
    {
        public AI(string zorlukDerecesi, string tahmini) : base(zorlukDerecesi, tahmini)
        {
            
        }
        Random r = new Random();
        string[] kolay = Kelime.kolayKelimeGonder();
        string [] orta = Kelime.ortaKelimeGonder();
        string[] zor = Kelime.zorKelimeGonder();

       

       
        public static string [] rasgeleKolay;
        public static string[] rasgeleOrta;
        public static string[] rasgeleZor;
        public void kelimeSec()
        {
            if (zorlukderecesi == "kolay")
            {
                for (int i = 0; i < 10; i++)
                {
                    int randomIndex = r.Next(0, kolay.Length);
                    rasgeleKolay[i] = kolay[randomIndex];
                }

            }

            else if (zorlukderecesi == "orta")
            {
                for (int i = 0; i < 10; i++)
                {
                    int randomIndex = r.Next(0, orta.Length);
                    rasgeleOrta[i] = orta[randomIndex];
                }
            }

            else if (zorlukderecesi == "zor")
            {
                for (int i = 0; i < 10; i++)
                {
                    int randomIndex = r.Next(0, orta.Length);
                    rasgeleOrta[i] = orta[randomIndex];
                }
            }
            else Console.WriteLine("Yanlış seçim yaptınız");
        }
        
        public void ipucuVer(string tahmini,string kelime)
        {     
            char[] tahminChar = tahmini.ToCharArray();
            char[] kelimeChaar = kelime.ToCharArray();
            if (tahmini == kelime)
            {
                Console.WriteLine("Doğru bildiniz tebrikler!!");

            }
            else
            {
                for(int i = 0; i < tahminChar.Length; i++)
                {
                    for(int j=0; j < kelimeChaar.Length; j++)
                    {
                        if(tahminChar[i]==kelimeChaar[j])
                        {
                            if(i==j)
                            {
                                Console.WriteLine("Eşlesme sağlayan karakterler= {0}", tahminChar[i]);
                            }
                           
                        }
                        
                    }
                }

                for (int i = 0; i < tahminChar.Length; i++)
                {
                    for (int j = 0; j < kelimeChaar.Length; j++)
                    {
                        if (tahminChar[i] == kelimeChaar[j])
                        {
                                Console.WriteLine("Sözcükten yer alan karakterler= {0} ", tahminChar[i]);
                        }
                    }
                }


            }


        }

    }
}