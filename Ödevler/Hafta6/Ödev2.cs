using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           #Hüseyin Can 253908013
            //Matris Oluşturur
            Random rnd = new Random();
            Console.Write("Bir N Değeri Giriniz: ");
            int N = int.Parse(Console.ReadLine());
            int[,] matris = new int[N,N];
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matris[i, j] = rnd.Next(-9, 10);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Oluşturulan Matris:");
            //Matrisi Ekrana Yazdırır
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    Console.Write($"{matris[i,j],4}");



                }
                Console.WriteLine();
            }
            //Ana Köşegendeki Sayıları Toplar
            int ana_kosegen_toplam = 0;
            for (int i = 0;i < N; i++)
            ana_kosegen_toplam += matris[i, i];



            //Yardımcı Köşegendeki Sayıları Çarpar
            int yan_kosegen_carpım = 1;
            for (int i = 0; i < N; i++)
            yan_kosegen_carpım *= matris[i, N - 1 - i];


            //Matrisdeki Negatif Sayı Sayısını Bulur
            int negatifsayı = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matris[i, j] < 0)
                    {
                        negatifsayı++;
                    }
                }
            }
            //En Sık Tekrar Eden Sayıyı Bulur
            int[] dizi = new int[N * N];
            int dizielemanı = 0;
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    dizi[dizielemanı++] = matris[i, j];
            int en_sık_tekrar = dizi[0];
            int tekrar_sayac = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                int sayac = 0;
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[i] == dizi[j])
                        sayac++;
                }

                if (sayac > tekrar_sayac || (sayac == tekrar_sayac && dizi[i] < en_sık_tekrar))
                {
                    tekrar_sayac = sayac;
                    en_sık_tekrar = dizi[i];
                }


            }

            //Asal Sayıların Ortalamasını Alır
            int toplam = 0;
            int adet = 0;

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    int sayi = matris[i, j];
                    bool asal = true;

                    if (sayi < 2)
                        asal = false;
                    else
                    {
                        for (int k = 2; k <= Math.Sqrt(sayi); k++)
                        {
                            if (sayi % k == 0)
                            {
                                asal = false;
                                break;
                            }
                        }
                    }

                    if (asal)
                    {
                        toplam += sayi;
                        adet++;
                    }
                }
            }

            if (adet > 0)
            {
                double ortalama = (double)toplam / adet;
                Console.WriteLine("Asal sayıların ortalaması: " + ortalama);
            }
            else
            {
                Console.WriteLine("Asal sayı yok.");
            }

            // Matrisi 90 Derece Çevirir
            int[,] doksan_derece = new int[N, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    doksan_derece[j, N - 1 - i] = matris[i, j];

            //Sonuçları Ekrana Yazdırır
            Console.WriteLine("Asal Köşegen Toplamı: " + ana_kosegen_toplam);
            Console.WriteLine("Yardımcı Köşegen Toplamı: " + yan_kosegen_carpım);
            Console.WriteLine("Matrisdeki Negatif Sayı Sayısı: " + negatifsayı);
            Console.WriteLine("Matriste En Sık Tekrar Eden Sayı: " + en_sık_tekrar);
            Console.WriteLine("Asal Sayıların Ortalaması: " );
            Console.WriteLine("Doksan Derece Dönmüş Matris: ");
            Console.WriteLine();
            //90 Derece Dönmüş Matrisi Ekrana Yazdırır
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    Console.Write($"{doksan_derece[i, j],4}");



                }
                Console.WriteLine();
            }











        }
    }
}


