using System;

namespace _1_conditional
{
    class Program
    {
        static void EkranaYaz(string yaz)
        {
            Console.WriteLine(yaz);
        }

        static string Oku()
        {
            return Console.ReadLine();
        }

        static void Karar(string a, string b)
        {
            string ad = "gonca";
            String parola = "1234";

            if (a == ad && b == parola)
            {
                Console.WriteLine("Eşleştirme Başarılı... ");
            }
            else
            {
                Console.WriteLine("Eşleştirme Başarısız!!!");
            }
        }
        static void Main(string[] args)
        {
            EkranaYaz("Adınızı Giriniz: ");
            string GirilenAd = Oku();

            EkranaYaz("Parolanızı Giriniz: ");
            string GirilenParola = Oku();

            Karar(GirilenAd, GirilenParola);
        }
    }
}
