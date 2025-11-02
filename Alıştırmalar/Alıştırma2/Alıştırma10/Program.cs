using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tpng=0; int tppz=0;
            while (true)
            {
                Console.Write("Bir Sayı Giriniz:");
                int sayı = int.Parse(Console.ReadLine());
                if (sayı > 0)
                {
                    tppz += sayı;
                }
                else if (sayı < 0) 
                {
                    tpng += sayı;
                }
                else 
                {
                    break;
                }


            }
            Console.WriteLine("Negatifler Toplamı: " + tpng);
            Console.WriteLine("Pozitifler Toplamı: " + tppz);











        }
    }
}
