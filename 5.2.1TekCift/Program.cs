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
            EkranaYaz("Sayı Giriniz: ");
            int sayi = Oku();

            if (sayi % 2 == 0)
            {
                EkranaYaz("Girdiğiniz sayı çifttir.");
            }
            else
            {
                EkranaYaz("Girdiğiniz sayı tektir.");

            }
            Console.ReadLine();
        }
    }
}
