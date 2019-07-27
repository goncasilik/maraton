using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine("Sayıların düz hali:");
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Tersi:");
            for (int i = sayilar.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}
