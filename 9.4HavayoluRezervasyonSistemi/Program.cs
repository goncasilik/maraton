using System;
using System.Linq;

namespace ConsoleApp15
{
    class Program
    {
        public static string[] rezervasyonYapanlar = new string[20];
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

        public static string Oku()
        {
            return Console.ReadLine();
        }

        public static void EkranaYaz(string deger)
        {
            Console.WriteLine(deger);
        }

        public static void BosKoltuklariYazdir(
            string tipi, 
            string[] koltukListesi
        )
        {
            Console.WriteLine($"{tipi} Class bölümünde boş kalan koltuklar:");

            for (int i = 0; i < koltukListesi.Length; i++)
            {
                if (rezervasyonYapanlar[i] == null)
                {
                    Console.WriteLine($"- {koltukListesi[i]}");
                }
            }
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

        public static void RezervasyonYap()
        {

        }

        static void Main(string[] args)
        {
            bool anahtar = true;
            
            while (anahtar)
            {
                EkranaYaz("1. Business Class bölümü için 1 tuşuna basın" +
                    "\n2. Economy Class bölümü için 2 tuşuna basın");
                string secim = Oku();

                if (secim == "1")
                {
                    // string[] businessKoltuklar = koltuklar.Skip(0).Take(8).ToArray();
                    string[] businessKoltuklar = koltuklar.Skip(0).Take(3).ToArray();

                    string[] businessRezervasyonListesi = rezervasyonYapanlar.Skip(0).Take(3).ToArray();

                    bool anahtar2 = true;

                    while (anahtar2)
                    {
                        if (BosElemanVarMi(businessRezervasyonListesi))
                        {
                            BosKoltuklariYazdir("Business", businessKoltuklar);

                            string koltukNumarasi = Oku();
                            EkranaYaz($"Seçilen Koltuk Numarası : {koltukNumarasi}");

                            int index = IndexBul(businessKoltuklar, koltukNumarasi);

                            if (rezervasyonYapanlar[index] == null)
                            {
                                EkranaYaz("Lütfen Yolcunun Adını ve Soyadını Yazın: ");
                                string adSoyad = Oku();
                                VerilenIndexeElemanEkle(ref rezervasyonYapanlar, index, adSoyad);
                                EkranaYaz(
                                    $"Class bölümünde {koltukNumarasi} " +
                                    $"numaralı koltuğu {adSoyad} isimli yolcuya rezerve etiniz." +
                                    $"\nDevam etmek için bir tuşa basın..."
                                    );

                                anahtar2 = false;
                            }

                            else if (rezervasyonYapanlar[index] != null)
                            {
                                EkranaYaz($"{koltukNumarasi} Numalari koltugu daha once" +
                                    $" {rezervasyonYapanlar[index]} isimli yolcuya rezerve ettiniz!" +
                                    $"\n Lutfen bos koltuklardan birini seciniz."
                                );
                            }
                        }

                        else
                        {
                            EkranaYaz("Sectiginiz business class bolumunde bos koltuk kalmamistir.\n" +
                                "Economy class bolumundeki bos koltuklari gormek ister misiniz? E/H"
                            );
                            string cevap = Oku();
                            if (cevap.Equals("E"))
                            {
                                anahtar2 = false;
                            } 
                            else if (cevap.Equals("H"))
                            {
                                EkranaYaz("Bir sonraki ucus kayitlari 4 saat sonradir");
                                anahtar2 = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
