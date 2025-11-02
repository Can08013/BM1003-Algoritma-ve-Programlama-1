using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kulanıcıdan Alınan On Sayını Ortalamasını Hesaplar");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
           int toplam = 0;
            int sayı;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i+1}. Sayıyı Giriniz: ");
                sayı = int.Parse( Console.ReadLine() );
                toplam += sayı;
            }
            double ort = toplam / 10;
            Console.WriteLine($"Sayıların Ortalaması: {ort}");


        }
    }
}
