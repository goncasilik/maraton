using System;

namespace _6._2._1
{
    class Program
    {
        static void EkranaYaz(string deger)
        {
            Console.WriteLine(deger);
        }

        static int Oku()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int kare = 1;
            int kup = 1;
            int sayi1 = 1;

            EkranaYaz("Sayi 1: ");
            sayi1 = Oku();

            EkranaYaz("Sayi 2: ");
            int sayi2 = Oku();
            
            for (int i = sayi1; i <= sayi2; i++)
            {
                kare = i * i;
                kup = i * i * i;

                EkranaYaz($"{i} {kare,5} {kup,5}");
            }
            Console.ReadLine();
        }
    }
}
