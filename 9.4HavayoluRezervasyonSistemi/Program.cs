using System;
using System.Linq;

namespace ConsoleApp15
{
    class Program
    {
        public static string[] rezervasyonYapanlar = new string[20];
        public static string[] businessRezervasyonListesi = rezervasyonYapanlar
            .Skip(0)
            .Take(2)
            .ToArray();
        public static string[] economyRezervasyonListesi = rezervasyonYapanlar
            .Skip(0)
            .Take(2)
            .ToArray();

        public static string[] koltuklar = new string[]
            {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"
            };

        public static string[] businessKoltuklar = koltuklar
            .Skip(0)
            .Take(2)
            .ToArray();
        public static string[] economyKoltuklar = koltuklar
            .Skip(2)
            .Take(2)
            .ToArray();

        public static string secim = "";

        // yardimci metotlar
        public static string Oku()
        {
            return Console.ReadLine();
        }

        public static void EkranaYaz(string deger)
        {
            Console.WriteLine(deger);
        }

        public static int IndexBul(
            string[] dizi,
            string eleman
            )
        {
            return Array.IndexOf(dizi, eleman);
        }

        public static void VerilenIndexeElemanEkle(
            ref string[] array,
            int index,
            string eleman
        )
        {
            array[index] = eleman;
        }

        public static bool BosElemanVarMi(string[] dizi)
        {
            return Array.Exists(dizi, element => element == null);
        }

        // ana metotlar
        public static void SiniflariYazdir()
        {
            if (secim.Equals(""))
            {
                Console.WriteLine("Business yolculari girin (1)");
                Console.WriteLine("Economy yolculari girin (2)");
                secim = Console.ReadLine();
            }
        }

        public static void BosKoltuklariYazdir(
            string[] liste,
            string tipi,
            string[] koltukListesi
        )
        {
            Console.WriteLine($"{tipi} Class bölümünde boş kalan koltuklar:");

            for (int i = 0; i < koltukListesi.Length; i++)
            {
                if (liste[i] == null)
                {
                    Console.WriteLine($"- {koltukListesi[i]}");
                }
            }
        }

        public static void RezervasyonYapmayiDene(
            string secimNo,
            string[] rezervasyonListesi,
            string[] koltukListesi
        )
        {
            while (BosElemanVarMi(rezervasyonListesi))
            {
                RezervasyonYap(rezervasyonListesi, koltukListesi);
                if (!BosElemanVarMi(rezervasyonListesi))
                {
                    if (secimNo.Equals("1"))
                    {
                        string alternatifSinif = "Economy";
                        string alternatifNo = "2";

                        RezervasyonYapilamiyor(alternatifSinif, alternatifNo);
                    }

                    else if (secimNo.Equals("2"))
                    {
                        string alternatifSinif = "Business";
                        string alternatifNo = "1";

                        RezervasyonYapilamiyor(alternatifSinif, alternatifNo);
                    }
                }
            }
        }

        public static void RezervasyonYap(string[] rezervasyonListesi, string[] koltuklar)
        {
            BosKoltuklariYazdir(rezervasyonListesi, "Business", koltuklar);

            string koltukNumarasi = Oku();
            EkranaYaz($"Seçilen Koltuk Numarası : {koltukNumarasi}");

            int index = IndexBul(koltuklar, koltukNumarasi);

            if (rezervasyonListesi[index] == null)
            {
                EkranaYaz("Lütfen Yolcunun Adını ve Soyadını Yazın: ");
                string adSoyad = Oku();

                VerilenIndexeElemanEkle(ref rezervasyonListesi, index, adSoyad);

                EkranaYaz(
                    $"Class bölümünde {koltukNumarasi} " +
                    $"numaralı koltuğu {adSoyad} isimli yolcuya rezerve etiniz." +
                    $"\nDevam etmek için bir tuşa basın..."
                    );
            }

            else if (rezervasyonListesi[index] != null)
            {
                EkranaYaz($"{koltukNumarasi} Numalari koltugu daha once" +
                    $" {rezervasyonListesi[index]} isimli yolcuya rezerve ettiniz!" +
                    $"\n Lutfen bos koltuklardan birini seciniz."
                );
            }
        }

        public static void RezervasyonYapilamiyor(string tip, string opsiyon)
        {
            Console.WriteLine(tip + " sinifina bakmak ister misiniz? E/H");
            string confirm = Console.ReadLine();
            if (confirm.Equals("E"))
            {
                secim = opsiyon;
            }
            else if (confirm.Equals("H"))
            {
                Console.WriteLine("Bir sonraki ucus 4 saat sonradir");
                secim = "";
            }
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                SiniflariYazdir();

                switch (secim)
                {
                    case "1":
                        RezervasyonYapmayiDene("1", businessRezervasyonListesi, businessKoltuklar);
                        break;

                    case "2":
                        RezervasyonYapmayiDene("2", economyRezervasyonListesi, economyKoltuklar);
                        break;
                }
            }
        }
    }
}
