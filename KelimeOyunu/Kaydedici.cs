using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    class Kaydedici
    {
     public void kacTahmin()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("{0}.kelimeyi {1} tahminde bildiniz", i + 1, AI.sayac[i]);
                AI.sayac[i] = 0;
            }
        }
}
}
