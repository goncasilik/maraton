using System;

namespace Logical
{
    class Program
    {
        static void EkranaYaz(string yaz)
        {
            Console.WriteLine(yaz);
        }

        static int Oku()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static bool KarsilastirmaBir(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static bool KarsilastirmaIki(int a, int b, int c)
        {
            if (!(a == b && b == c))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static bool KarsilastirmaUc(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static bool KarsilastirmaDort(int a, int b, int c)
        {
            if ((a > b && b > c) || (a == b && a == c))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static bool KarsilastirmaBes(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static bool KarsilastirmaAlti(int a, int b, int c)
        {
            if (b > a && b > c)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static bool KarsilastirmaYedi(int a, int b, int c)
        {
            if ((b > a && b > c) || (a == b && b == c))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static bool KarsilastirmaSekiz(int a, int b, int c)
        {
            if (b < a && b < c)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static bool KarsilastirmaDokuz(int a, int b, int c)
        {
            if (c < a && c < b)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {

            EkranaYaz("Sayı 1: ");
            int sayi1 = Oku();

            EkranaYaz("Sayı 2: ");
            int sayi2 = Oku();

            EkranaYaz("Sayı 3: ");
            int sayi3 = Oku();

            EkranaYaz($"01. {sayi1}, {sayi2} ve {sayi3} sayiları birbirine eşittir: { KarsilastirmaBir(sayi1, sayi2, sayi3)}");
            EkranaYaz($"02. {sayi1}, {sayi2} ve {sayi3} sayiları birbirine eşit değildir: { KarsilastirmaIki(sayi1, sayi2, sayi3)}");
            EkranaYaz($"03. {sayi1} sayisi {sayi2} ve {sayi3} sayilarından büyüktür: { KarsilastirmaUc(sayi1, sayi2, sayi3)}");
            EkranaYaz($"04. {sayi1} sayisi {sayi2} ve {sayi3} sayilarından büyüktür veya sayılara eşittir: { KarsilastirmaUc(sayi1, sayi2, sayi3)}");
            EkranaYaz($"05. {sayi1} sayisi {sayi2} ve {sayi3} sayilarından küçüktür: { KarsilastirmaBes(sayi1, sayi2, sayi3)}");
            EkranaYaz($"06. {sayi2} sayisi {sayi1} ve {sayi3} sayilarından büyüktür: { KarsilastirmaAlti(sayi1, sayi2, sayi3)}");
            EkranaYaz($"07. {sayi2} sayisi {sayi1} ve {sayi3} sayilarından büyüktür veya sayılarına eşittir: { KarsilastirmaYedi(sayi1, sayi2, sayi3)}");
            EkranaYaz($"08. {sayi2} sayisi {sayi1} ve {sayi3} sayilarından küçüktür : { KarsilastirmaSekiz(sayi1, sayi2, sayi3)}");
            EkranaYaz($"08. {sayi3} sayisi {sayi1} ve {sayi2} sayilarından küçüktür : { KarsilastirmaDokuz(sayi1, sayi2, sayi3)}");

            Console.ReadLine();
        }
    }
}
