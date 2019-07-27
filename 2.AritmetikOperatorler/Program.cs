using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Yaz(string deger)
        {
            Console.WriteLine(deger);
        }

        static int DegerOkuInt()
        {
            return int.Parse(Console.ReadLine());
        }

        static float DegerOkuFloat()
        {
            return float.Parse(Console.ReadLine());
        }

        static float Topla(int a, float b)
        {
            return a + b;
        }

        static float Cikar(int a, float b)
        {
            return a - b;
        }

        static float Carp(int a, float b)
        {
            return a * b;
        }

        static float Bol(int a, float b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Yaz("Sayı 1: ");
            int sayi1 = DegerOkuInt();

            Yaz("Sayı 2: ");
            float sayi2 = DegerOkuFloat();

            Yaz($"{sayi1} + {sayi2} = {Topla(sayi1, sayi2)}");
            Yaz($"{sayi1} - {sayi2} = {Cikar(sayi1, sayi2)}");
            Yaz($"{sayi1} * {sayi2} = {Carp(sayi1, sayi2)}");
            Yaz($"{sayi1} / {sayi2} = {Bol(sayi1, sayi2)}");

            Console.ReadLine();
        }
    }
}
