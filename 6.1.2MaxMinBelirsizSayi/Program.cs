using System;

namespace MaxMinBulma
{
    class Program
    {
        static void EkranaYaz(string yaz)
        {
            Console.WriteLine(yaz);
        }
        static void Main(string[] args)
        {
            double maxSayi = Double.MinValue;
            double minSayi = Double.MaxValue;
            bool anahtar = true;
            int sayac = 0;

            while (anahtar)
            {
                EkranaYaz("Sayı Giriniz: ");

                string okunanDeger = Console.ReadLine();
                sayac++;

                bool sayiMi = Double.TryParse(okunanDeger, out double sayi);
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
                    if ((okunanDeger.ToString()).Equals("end"))
                    {
                        if (sayac > 2)
                        {
                            Console.WriteLine("Programdan çıkılıyor...");
                            anahtar = false;
                        }
                        else
                        {
                            Console.WriteLine($"Programdan çıkmak icin tekrar end yazmaniz gerekiyor.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Programdan çıkılıyor...");
                    }
                    if ((okunanDeger.ToString()).Equals("exit"))
                    {
                        Console.WriteLine("Programdan çıkılıyor...");
                        anahtar = false;
                    }
                }

            }

            Console.WriteLine($"Girilen en büyük değer: {maxSayi}");
            Console.WriteLine($"Girilen en küçük değer: {minSayi}");

            Console.ReadLine();
        }
    }
}
