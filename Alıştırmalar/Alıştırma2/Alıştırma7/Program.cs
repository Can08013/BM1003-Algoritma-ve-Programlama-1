using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilen Sayının 10'a Kadar Olan Çarpım Tablosunu Verir");
            Console.WriteLine();
            Console.Write("Bir Sayı Giriniz: ");
            int sayı = int.Parse(Console.ReadLine());
            int snç;
            for (int i = 1; i <= 10; i++)
            {
                snç = i * sayı;
                Console.WriteLine(i +"*" + sayı + "= "+ snç);
            }









        }
    }
}
