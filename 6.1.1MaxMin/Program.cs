using System;

namespace MaxMinBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxSayi = Double.MinValue;
            double minSayi = Double.MaxValue;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sayı Giriniz: ");
                bool sayiMi = Double.TryParse(Console.ReadLine(), out double sayi);
                if (sayiMi)
                {
                    if (sayi > maxSayi)
                    {
                        maxSayi = sayi;
                    }

                    if (sayi < minSayi)
                    {
                        minSayi = sayi;
                    }
                }

                else
                {
                    Console.WriteLine("Girdiğiniz sayi geçersizdir!!");
                }
            }

            Console.WriteLine($"Girilen en büyük değer: {maxSayi}");
            Console.WriteLine($"Girilen en küçük değer: {minSayi}");

            Console.ReadLine();
        }
    }
}
