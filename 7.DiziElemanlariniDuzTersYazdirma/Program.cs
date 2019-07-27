using System;

namespace _7._1._1
{
    class Program
    {

        static void DiziyiDuzYazdirma()
        {
            int[] sayilar = new int[5] { 10, 20, 30, 40, 50 };

            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }

        static void Main(string[] args)
        {
            DiziyiDuzYazdirma();
            Console.ReadLine();
        }
    }
}
