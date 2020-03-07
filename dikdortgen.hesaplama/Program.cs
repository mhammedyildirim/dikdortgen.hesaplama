using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dikdortgen.hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int kisakenar=0;
            int uzunkenar=0;
            Console.Write("Dikdortgenin uzun kenarini giriniz: ");
            uzunkenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dikdortgenin kisa kenarini giriniz: ");
            kisakenar = Convert.ToInt32(Console.ReadLine());

            int toplam=0;
            toplam = (2 * kisakenar + 2 * uzunkenar);
           
            
            int alan=0;
            alan = kisakenar * uzunkenar;

            double kosegen = 0;
            kosegen = Math.Sqrt(Convert.ToDouble(Math.Pow(kisakenar, 2)) + Convert.ToDouble(Math.Pow(uzunkenar, 2)));
            
            
            
            Console.WriteLine("Dikdortgenin kenarlar toplami {0} kosegen uzunlugu {2} alanı {1} metredir.",toplam, alan, kosegen);

            Console.ReadKey();
          
        }
    }
}
