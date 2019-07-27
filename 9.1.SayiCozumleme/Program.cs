using System;
using System.Collections.Generic;

namespace _9._1.SayiCozumleme
{
    class Program
    {
        static void EkranaYaz(string yaz)
        {
            Console.WriteLine(yaz);
        }

        static int[] IntDiziOlustur(int sayi) // 123
        {
            if (sayi == 0)
            {
                return new int[1] { 0 };
            }

            List<int> rakamlar = new List<int>();

            for (; sayi != 0; sayi /= 10)
            {
                rakamlar.Add(sayi % 10);
            }

            int[] dizi = rakamlar.ToArray(); // {3, 2, 1}

            return dizi;
        }

        static void TabanCarpimiYazdir(int[] sayiDizisi)
        {
            int taban = 1;

            for (int i = 0; i <= sayiDizisi.Length - 1; i++)
            {
                Console.WriteLine($"{sayiDizisi[i]} x {taban} = {sayiDizisi[i] * taban}");
                taban *= 10;
            }
        }

        static void Main(string[] args)
        {
            bool anahtar = true;

            while(anahtar)
            {
                EkranaYaz("Sayı Giriniz: ");
                string giris = Console.ReadLine();
                bool sayiMi = int.TryParse(giris, out int sayi);

                if (giris.Equals("exit"))
                {
                    anahtar = false;
                }

                else if (sayiMi)
                {
                    TabanCarpimiYazdir(IntDiziOlustur(sayi));
                }
                else
                {
                    Console.WriteLine("Dogru formatta bir sayi girmediniz!");
                }
            }
        }
    }
}
