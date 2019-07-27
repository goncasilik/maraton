using System;

namespace YanYanaDiziOlusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 789, 12, 100, 5 };

            string karakter = "";

            for (int i = 0; i < sayilar.Length; i++)
            {
                karakter += sayilar[i].ToString();
                if (i != sayilar.Length - 1)
                {
                    karakter += "-";
                }
            }

            Console.WriteLine($"{karakter}");
            Console.WriteLine("Ikinci yontem");
            Console.WriteLine(string.Join("-", sayilar));

            Console.ReadLine();
        }
    }
}
