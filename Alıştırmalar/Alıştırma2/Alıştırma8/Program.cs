using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilen Sayını Faktöriyelini Hesaplar");
            Console.WriteLine();
            Console.WriteLine("Sayı Giriniz: ");
            int nm = int.Parse(Console.ReadLine());
            int sonuç = 1;
            for (int i = 1; i <= nm; i++)
            {
                sonuç *= i;



            }
            Console.WriteLine($"{nm} Sayısının Faktöriyeli {sonuç} Sayısıdır");

        }
    }
}
