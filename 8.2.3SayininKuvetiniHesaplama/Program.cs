using System;

namespace _8._2._3
{
    class Program
    {
        static int Topla(int a, int b)
        {
            return a + b;
        }
        static int Karesi(int a)
        {
            return a * a;
        }
        static int SayininKuvvetiniAlma(int sayi, int kuvvet)
        {
            int sonuc = 1;
            for (int i = 1; i <= kuvvet; i++)
            {
                sonuc *= sayi;
            }
            return sonuc;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"2 ve 3 sayısının toplamı: {Topla(2, 3)}");
            Console.WriteLine($"2 sayısının karesi: {Karesi(2)}");
            Console.WriteLine($"Kuvvet Alma: {SayininKuvvetiniAlma(2, 3)}");
            Console.ReadLine();
        }
    }
}
