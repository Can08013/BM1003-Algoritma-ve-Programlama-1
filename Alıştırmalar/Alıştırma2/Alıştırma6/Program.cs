using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilen Sayıyı Kadar Olan Tam Sayıların Küpünü Alır");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.Write("Bir Sayı Giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int küp;
            for (int i = 1; i <= number; i++)
            {
                küp = i * i * i;
                Console.WriteLine($"{i} nin Küpü: {küp}");
            }
        }
    }
}
