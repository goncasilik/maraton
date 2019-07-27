using System;

namespace _8._5._3BesHaneliSayiyiDondurenMetot
{
    class Program
    {
        static void EkranaYaz(string yaz)
        {
            Console.WriteLine(yaz);
        }

        static int BesHaneliSayiDondur()
        {
            int sayi = 0;
            string giris = Console.ReadLine();

            if (int.TryParse(giris, out sayi))
            {
                if (giris.Length == 5 || giris.Length > 5)
                {
                    sayi = Convert.ToInt32(giris.Substring(0, 5));

                    return sayi;
                }
            }

            return sayi;
        }

        static void Main(string[] args)
        {
            EkranaYaz($"Beş Haneli Sayı: {BesHaneliSayiDondur()}");
        }

    }
}
