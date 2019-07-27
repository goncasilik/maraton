using System;

namespace _5._3._2UcgenMiAci
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
            if(a + b + c == 180)
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
            Console.WriteLine("1.Açı: ");
            int aci1 = Oku();

            Console.WriteLine("2.Açı: ");
            int aci2 = Oku();

            Console.WriteLine("3.Açı: ");
            int aci3 = Oku();

            UcgenMi(aci1, aci2, aci3);
        }
    }
}
