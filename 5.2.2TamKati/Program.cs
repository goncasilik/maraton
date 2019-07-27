using System;

namespace _5._2._1TekCift
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
        static void Main(string[] args)
        {
            EkranaYaz("Sayı 1: ");
            int sayi1 = Oku();
            EkranaYaz("Sayı 2: ");
            int sayi2 = Oku();

            if (sayi1 % sayi2 == 0)
            {
                EkranaYaz($"{sayi1} sayısı {sayi2} sayisinin katıdır.");
            }
            else
            {
                EkranaYaz($"{sayi1} sayısı {sayi2} sayisinin katı değildir.");
            }
            Console.ReadLine();
        }
    }
}
