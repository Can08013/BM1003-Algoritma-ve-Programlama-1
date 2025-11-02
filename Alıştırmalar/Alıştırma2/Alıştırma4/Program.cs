using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0-100 Arasındaki Sayıların 7 ile Bölümünden Kalan 3 Olan Sayılar");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            
            int Toplam = 0;
            for (int i = 0; i < 101; i++)
            {
                if (i % 7 == 3)
                {
                    Console.Write(i+" ");
                    Toplam++;


                }
            }
            Console.WriteLine();
            Console.WriteLine($"Toplam Sayı: {Toplam}");

        }
    }
}
