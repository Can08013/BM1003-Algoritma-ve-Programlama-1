using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk On Doğal Sayının Toplamını Bulur");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            int toplam = 0;
            
            for (int i = 0; i < 100; i++)
            {
                toplam += i;

            }
            Console.WriteLine(toplam);
        }
    }
}
