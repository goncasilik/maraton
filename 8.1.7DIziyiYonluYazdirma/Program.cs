using System;

namespace _8._1._7
{
    class Program
    {
        static void DiziElemanlariniYazdir(int[] dizi, char yon)
        {
            foreach (int degerler in dizi)
            {
                if (yon == 'v')
                {
                    Console.WriteLine(degerler);
                }
                else
                {
                    Console.Write($"{degerler} ");
                }
            }
        }

        static void CaprazDiziYazdir(int[] dizi)
        {
            for (int i = 0; i <= dizi.Length - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(dizi[i]);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[] dizi = new int[] { 100, 200, 250, 300 };

            DiziElemanlariniYazdir(dizi, 'h'); // yönlü parametre alır
            DiziElemanlariniYazdir(dizi, 'v'); // yönlü parametre alır
            DiziElemanlariniYazdir(dizi, 'a'); // yönlü parametre alır

            CaprazDiziYazdir(dizi); // Çapraz

            Console.ReadLine();
        }
    }
}
