using System;

namespace _8._5KonsolGirişDondurenMetotlar
{
    class Program
    {
        static void EkranaYaz(string yaz)
        {
            Console.WriteLine(yaz);
        }

        // 8.5.1
        static int OkuInt()
        {
            int.TryParse(Console.ReadLine(), out int sayi);

            return sayi;
        }
        
        // 8.5.2
        static float OkuFloat()
        {
            float.TryParse(Console.ReadLine(), out float sayi);

            return sayi;
        }
        static void Main(string[] args)
        {
            
            EkranaYaz("Sayı giriniz: ");
            EkranaYaz($"{OkuInt()}");
            EkranaYaz($"{OkuFloat()}");
        }
    }
}
