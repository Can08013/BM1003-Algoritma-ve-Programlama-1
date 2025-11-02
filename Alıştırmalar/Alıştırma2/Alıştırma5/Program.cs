using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1-1000 Arasındaki Sayılardan 12 Tam Bölünenlerin Ortalamsı");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            int toplam = 0; 
            int sayı = 0;
            for (int i = 1; i < 1001; i++)
            {
                if (i % 12 == 0)
                {
                    toplam += i;
                    sayı++;
                    
                }
            }
            Console.WriteLine();
            double ort = toplam / sayı;
            Console.WriteLine("Sayıların Ortalaması: " + ort);
        }
        
    }
}
