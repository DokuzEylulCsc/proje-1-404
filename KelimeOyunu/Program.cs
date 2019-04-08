using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyun a = new Oyun();
            Kaydedici b = new Kaydedici();
            while (a.yenidenBasla() == true) //yenidenBasla bool fonksiyonunda tercih yeni ve eski olduğunda true döndürüyor. true olduğu sürece tercihine göre devam edecek.
            {
                b.kacTahmin(); //kaç tahminde bulduğunun istatistiği
            }
           
            Console.ReadKey();
        }
    }
}
