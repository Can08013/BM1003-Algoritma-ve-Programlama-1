using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Tam Sayını Rakamlarını Toplar");
            Console.WriteLine();
            Console.Write("Bir Sayı Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int toplam = 0;
             



            while (sayi > 0)
            {
                toplam = toplam + sayi % 10;
                sayi = sayi / 10;
            }

            Console.WriteLine($"Rakamların toplamı: {toplam}");




        }
    }
}
