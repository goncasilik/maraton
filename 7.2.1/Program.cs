using System;

namespace _7._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5] { 1, 2, 3, 4, 5 };

            int[] tersi = new int[5];

            for (int i = 0; i <= sayilar.Length - 1; i++)
            {
                tersi[i] = sayilar[(sayilar.Length - 1) - i];
            }
            foreach (int tersSayi in tersi)
            {
                Console.WriteLine(tersSayi);
            }
            Console.ReadLine();
        }
    }
}
