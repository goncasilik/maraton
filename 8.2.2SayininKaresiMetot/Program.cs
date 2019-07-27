using System;

namespace _7._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 1, 2, 3, 4 };


            for (int i = 0; i < 2; i++)
            {
                int gecici = sayilar[i];
                sayilar[i] = sayilar[(sayilar.Length - 1) - i];
                sayilar[(sayilar.Length - 1) - i] = gecici;
            }

            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            Console.ReadLine();
        }
    }
}
