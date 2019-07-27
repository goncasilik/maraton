using System;

namespace Degiskenler
{
    class Program
    {
        static void EkranaYaz(string karakter)
        {
            Console.WriteLine(karakter);
        }

        static string DegerOku()
        {
            return Console.ReadLine();
        }

        static int DegerOkuInt()
        {
            return int.Parse(Console.ReadLine());
        }

        static float DegerOkuFloat()
        {
            return float.Parse(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            // 1.1.1
            EkranaYaz("Giriş yapınız (string): ");
            string karakter = DegerOku();
            EkranaYaz($"String : {karakter}");

            // 1.1.2
            EkranaYaz("Giriş yapınız (Tam sayı): ");
            int tamSayi = DegerOkuInt();
            EkranaYaz($"Tam sayi : {tamSayi}");
            
            // 1.1.3
            EkranaYaz("Giriş yapınız (Ondalık Sayı): ");
            float ondalikSayi = DegerOkuFloat();
            EkranaYaz($"Ondalik sayi : {ondalikSayi}");

            Console.ReadLine();
        }
    }
}
