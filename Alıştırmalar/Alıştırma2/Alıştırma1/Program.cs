using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int sıra = 0;
            int ort;
            for (int i = 1; i < int.MaxValue; i++)
            {
               
                Console.WriteLine("Bir Sayı Giriniz...");

                int sayı = int.Parse(Console.ReadLine());
                if (sayı == 0 )
                {
                    sıra = i;
                    break;
                }
                
                toplam += sayı;
                

            }
            
            ort = toplam / (sıra - 1);
            int sysy = sıra - 1;
            Console.WriteLine("Girilen Sayı Sayısı: " + sysy);
            Console.WriteLine("Girilen Sayıları Ortalaması: " + ort);
            Console.WriteLine("Girilen Sayıların Toplamı: " + toplam);






        }
    }
}
