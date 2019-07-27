using System;
using System.Collections.Generic;

namespace _9._2Palindrome
{
    class Program
    {
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

            System.Array.Reverse(dizi); // {1, 2, 3}

            return dizi;
        }

        static int[] DiziyiTersSirala(int[] sayidizisi)
        {
            int[] tersSayiDizisi = new int[sayidizisi.Length];

            for (int i = 0; i <= sayidizisi.Length - 1; i++)
            {
                tersSayiDizisi[i] = sayidizisi[(sayidizisi.Length - 1) - i];
            }

            return tersSayiDizisi;
        }

        static bool PalindromMu(int[] sayiDizisi, int[] sayiDizisiTersi)
        {
            bool palindrome = true;

            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if (sayiDizisi[i] != DiziyiTersSirala(sayiDizisi)[i])
                {
                    palindrome = false;
                    break;
                }
            }

            return palindrome;
        }

        static void Main(string[] args)
        {
            bool anahtar = true;

            while (anahtar)
            {
                Console.WriteLine("Sayı Giriniz: ");
                string giris = Console.ReadLine();

                if (giris.Equals("exit"))
                {
                    anahtar = false;
                }

                else if (int.TryParse(giris, out int sayi))
                {
                    int[] sayiDizisi = IntDiziOlustur(sayi); // {1, 2, 3}

                    if (PalindromMu(sayiDizisi, DiziyiTersSirala(sayiDizisi))) {
                        Console.WriteLine("Palindromdur");
                    }
                    else
                    {
                        Console.WriteLine("Palindrom degil");
                    }
                }
            }
        }
    }
}
