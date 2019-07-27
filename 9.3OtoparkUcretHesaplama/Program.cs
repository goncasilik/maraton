using System;

namespace _9._3OtoparkUcretHesaplama
{
    class Program
    {
        public static void SecimleriYazdir()
        {
            Console.WriteLine("Otomobil icin 1'e basin");
            Console.WriteLine("Motosiklet icin 2'ye basin");
            Console.WriteLine("Minibus icin 3'e basin");
            Console.WriteLine("Kamyon (ve diger ticari araclar) icin 4'e basin");
        }

        public static bool SecimDogruMu(string secim)
        {
            return secim == "1" || secim == "2" || secim == "3" || secim == "4";
        }

        public static int OtomobilOtoparkUcretHesapla(double saat)
        {
            if (saat > 0 && saat <= 2)
            {
                return 5;
            }
            else if (saat > 2 && saat <= 6)
            {
                return 10;
            }
            else if (saat > 6 && saat <= 12)
            {
                return 20;
            }
            else if (saat > 12 && saat <= 24)
            {
                return 35;
            }
            else if (saat > 24)
            {
                return 35 + Convert.ToInt32(saat / 24) * 20;
            }

            return 0;
        }

        public static int MotosikletOtoparkUcretHesapla(double saat)
        {
            if (saat > 0 && saat <= 2)
            {
                return 0;
            }
            else if (saat > 2 && saat <= 6)
            {
                return 3;
            }
            else if (saat > 6 && saat <= 12)
            {
                return 12;
            }
            else if (saat > 12 && saat <= 24)
            {
                return 20;
            }
            else if (saat > 24)
            {
                return 10 + Convert.ToInt32(saat / 24) * 20;
            }

            return 0;
        }

        public static int MinibüsOtoparkUcretHesapla(double saat)
        {
            if (saat > 0 && saat <= 2)
            {
                return 8;
            }
            else if (saat > 2 && saat <= 6)
            {
                return 16;
            }
            else if (saat > 6 && saat <= 12)
            {
                return 32;
            }
            else if (saat > 12 && saat <= 24)
            {
                return 45;
            }
            else if (saat > 24)
            {
                return 45 + Convert.ToInt32(saat / 24) * 25;
            }

            return 0;
        }

        public static int KamyonDigerAraçlarOtoparkUcretHesapla(double saat)
        {
            if (saat > 0 && saat <= 2)
            {
                return 15;
            }
            else if (saat > 2 && saat <= 6)
            {
                return 30;
            }
            else if (saat > 6 && saat <= 12)
            {
                return 60;
            }
            else if (saat > 12 && saat <= 24)
            {
                return 100;
            }
            else if (saat > 24)
            {
                return 100 + Convert.ToInt32(saat / 24) * 55;
            }

            return 0;
        }

        public static int UcretHesapla(string secim, double saat, out bool anahtar)
        {
            int ucret = 0;

            switch (secim)
            {
                case "1":
                    ucret = OtomobilOtoparkUcretHesapla(saat);
                    anahtar = false;
                    break;

                case "2":
                    ucret = MotosikletOtoparkUcretHesapla(saat);
                    anahtar = false;
                    break;

                case "3":
                    ucret = MinibüsOtoparkUcretHesapla(saat);
                    anahtar = false;
                    break;

                case "4":
                    ucret = KamyonDigerAraçlarOtoparkUcretHesapla(saat);
                    anahtar = false;
                    break;

                default:
                    anahtar = false;
                    break;
            }

            return ucret;
        }

        static void Main(string[] args)
        {
            SecimleriYazdir();

            bool anahtar = true;

            while (anahtar)
            {
                string secim = Console.ReadLine();

                if (SecimDogruMu(secim))
                {
                    double ucret = 0;
                    bool anahtar2 = true;
                    while (anahtar2)
                    {
                        Console.WriteLine("Araç kaç saat boyunca park alanında kaldı? ");
                        string giris = Console.ReadLine();

                        if (double.TryParse(giris, out double saat))
                        {
                            if (saat > 0)
                            {
                                ucret = UcretHesapla(secim, saat, out anahtar2);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir saat girdiniz");
                        }
                    }

                    Console.WriteLine($"Ödenmesi gereken tutar: {ucret}");
                }
            }
        }
    }
}
