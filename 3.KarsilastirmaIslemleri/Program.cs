using System;

namespace KarsilastirmaIslemleri
{
    class Program
    {
        static void EkranaYaz(string yaz)
        {
            Console.WriteLine(yaz);
        }

        static string OkuString()
        {
            return Console.ReadLine();
        }

        static int OkuInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static bool KarsilastirmaString(string a, string b)
        {

            if (a == b)
            {
                return true;
            }

            return false;
        }

        static bool KarsilastirmaInt(int a, int b)
        {
            if (a == b)
            {
                return true;
            }

            return false;

        }

        static bool KarsilastirmaBuyukMu(int a, int b)
        {
            if (a > b)
            {
                return true;
            }

            return false;

        }
        static void Main(string[] args)
        {
            // 3.1.1
            EkranaYaz("String Değer Giriniz: ");
            string giris1 = OkuString();

            EkranaYaz("String Değer Giriniz: ");
            string giris2 = OkuString();

            EkranaYaz($"{giris1} = {giris2} {KarsilastirmaString(giris1, giris2)}");


            EkranaYaz("---------------");

            // 3.1.2
            EkranaYaz("Sayi Giriniz: ");
            int sayi1 = OkuInt();

            EkranaYaz("Sayi Giriniz: ");
            int sayi2 = OkuInt();

            EkranaYaz($"{sayi1} = {sayi2} {KarsilastirmaInt(sayi1, sayi2)}");

            EkranaYaz($"{sayi1} > {sayi2} {KarsilastirmaBuyukMu(sayi1, sayi2)}");

            Console.ReadLine();
        }
    }
}
