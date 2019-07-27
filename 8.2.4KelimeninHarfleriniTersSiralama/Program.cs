using System;

namespace _8._2._4
{
    class Program
    {
        static void EkranaYaz(string yaz)
        {
            Console.WriteLine(yaz);
        }
        static string TersYazma(string kelime)
        {
            string tersi = "";

            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                tersi += kelime[i];
            }

            return tersi;
        }
        static void Main(string[] args)
        {
            EkranaYaz(TersYazma("Ali"));
        }
    }
}
