using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[2];
            Random rnd = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1, 10);
                Console.WriteLine(sayilar[i]);
            }

            int puan = 0;
            int puan2 = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("1. Oyuncu Tahmin: ");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("2. Oyuncu Tahmin: ");
                int tahmin2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (tahmin2 == sayilar[i])
                {
                    puan2 += 10;
                }
                else
                {
                    if (sayilar[i] < tahmin2)
                    {
                        puan2 += 10 - (tahmin2 - sayilar[i]);
                    }
                    else if (sayilar[i] > tahmin2)
                    {
                        puan2 += 10 - (sayilar[i] - tahmin2);
                    }
                }
                if (tahmin == sayilar[i])
                {
                    puan += 10;
                }
                else
                {
                    if (sayilar[i] < tahmin)
                    {
                        puan += 10 - (tahmin - sayilar[i]);
                    }
                    else if (sayilar[i] > tahmin)
                    {
                        puan += 10 - (sayilar[i] - tahmin);
                    }
                }
            }
            Console.WriteLine("1. Oyuncu Puan Durumu: " + puan);
            Console.WriteLine("2. Oyuncu Puan Durumu: " + puan2);
            Console.ReadKey();
        }

    }
}
