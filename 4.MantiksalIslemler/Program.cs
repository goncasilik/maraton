using System;

namespace _2_Logical
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
            if (a != b && b != c)
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
            if ((a > b && a > c) || (a == b && a == c))
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
        static void Main(string[] args)
        {
            EkranaYaz("Birinci Ad: ");
            string ad1 = OkuString();
            EkranaYaz("Birinci Yaş: ");
            int yas1 = OkuInt();

            EkranaYaz("İkinci Ad: ");
            string ad2 = OkuString();
            EkranaYaz("İkinci Yaş: ");
            int yas2 = OkuInt();

            EkranaYaz("Üçüncü Ad: ");
            String ad3 = OkuString();
            EkranaYaz("Üçüncü Yaş: ");
            int yas3 = OkuInt();

            EkranaYaz($"{ad1}, {ad2} ve {ad3} kişilerinin yaşları birbirine eşittir: {KarsilastirmaBir(yas1, yas2, yas3)}");
            EkranaYaz($"{ad1}, {ad2} ve {ad3} kişilerinin yaşları birbirine eşit değildir: {KarsilastirmaIki(yas1, yas2, yas3)}");
            EkranaYaz($"{ad1} isimli kişinin yaşı {ad2} ve {ad3} kişilerinin yaşlarından büyüktür: {KarsilastirmaUc(yas1, yas2, yas3)}");
            EkranaYaz($"{ad1} isimli kişinin yaşı {ad2} ve {ad3} kişilerinin yaşlarından büyüktür veya eşittir: {KarsilastirmaDort(yas1, yas2, yas3)}");
            EkranaYaz($"{ad1} isimli kişinin yaşı {ad2} ve {ad3} kişilerinin yaşlarından küçüktür: {KarsilastirmaBes(yas1, yas2, yas3)}");

            Console.ReadLine();

        }
    }
}
