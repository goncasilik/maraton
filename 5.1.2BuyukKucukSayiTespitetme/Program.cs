using System;

namespace _2_conditional
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

        private static void ArrayOlustur(int[] sayilar)
        {
            for (int i = 0; i < 3; i++)
            {
                EkranaYaz("Sayı : ");
                int sayi = Oku();
                sayilar[i] = sayi;
            }
        }

        private static int[] MinMax(int[] sayilar)
        {
            int min = sayilar[0];
            int max = sayilar[0];

            foreach (int sayi in sayilar)
            {
                if (sayi < min)
                {
                    min = sayi;
                }

                if (sayi > max)
                {
                    max = sayi;
                }
            }

            int[] minMax = new int[2];

            minMax[0] = min;
            minMax[1] = max;

            return minMax;
        }

        static void Main(string[] args)
        {
            int[] sayilar = new int[3];
            ArrayOlustur(sayilar);

            //int min = MinMax(sayilar)[0];
            //int max = MinMax(sayilar)[1];

            EkranaYaz($"En küçük sayı: {MinMax(sayilar)[0]}");
            EkranaYaz($"En büyüksayı: {MinMax(sayilar)[1]}");
            Console.ReadLine();
        }
    }
}
