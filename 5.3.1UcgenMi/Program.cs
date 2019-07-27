using System;

namespace _5._3._1UcgenMi
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

        static void UcgenMi(int a, int b, int c)
        {
            if (((a + b) > c) && ((a + c) > b) && ((b + c) > a))
            {
                Console.WriteLine("Bu bir üçgendir.");
            }
            else
            {
                Console.WriteLine("Bu bir üçgen değildir.");

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Kenar: ");
            int kenar1 = Oku();

            Console.WriteLine("2.Kenar: ");
            int kenar2 = Oku();

            Console.WriteLine("3.Kenar: ");
            int kenar3 = Oku();

            UcgenMi(kenar1, kenar2, kenar3);
        }
    }
}
