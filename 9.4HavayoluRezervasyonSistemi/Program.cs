using System;
using System.Linq;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool anahtar = true;
            string[] rezervasyonYapanlar = { };

            while (anahtar)
            {
                Console.WriteLine("1. Business Class bölümü için 1 tuşuna basın");
                Console.WriteLine("2. Economy Class bölümü için 2 tuşuna basın");
                string secim = Console.ReadLine();
                string[] koltuklar = new string[]
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


                if (secim == "1")
                {
                    string[] businessKoltuklar = koltuklar.Skip(0).Take(8).ToArray();

                    Console.WriteLine("Business Class bölümünde boş kalan koltuklar:");

                    for (int i = 0; i < businessKoltuklar.Length; i++)
                    {
                        if (rezervasyonYapanlar[i] == null)
                        {
                            Console.WriteLine($"- {businessKoltuklar[i]}");
                        }
                    }

                    Console.WriteLine("Business Bos yok");
                    Console.WriteLine("Economy'de bakmak ister misiniz? E/H");
                    string secimEh = Console.ReadLine();
                    if (secimEh.Equals("E"))
                    {
                        Console.WriteLine("cozulecek");
                    }
                    else if (secimEh.Equals("H"))
                    {
                        Console.WriteLine("Bir sonraki ucus kayitlari 4 saat sonradir");
                    }

                    string koltukNumarasi = Console.ReadLine();
                    Console.WriteLine($"Seçilen Koltuk Numarası : {koltukNumarasi}");

                    int index = Array.IndexOf(businessKoltuklar, koltukNumarasi);
                    if (rezervasyonYapanlar[index] != null)
                    {
                        Console.WriteLine($"{koltukNumarasi} numaralı koltuğu {rezervasyonYapanlar[index]} isimli yolcuya rezerve edilmiştir..\nLütfen boş koltuklardan birini seçiniz.");
                    }

                    Console.Write("Lütfen Yolcunun Adını ve Soyadını Yazın: ");
                    string adSoyad = Console.ReadLine();


                    if (rezervasyonYapanlar[index] == null)
                    {

                        rezervasyonYapanlar[index] = adSoyad;
                        Console.WriteLine(rezervasyonYapanlar[index]);
                        Console.WriteLine($"Business Class bölümünde {koltukNumarasi} numaralı koltuğu {adSoyad} isimli yolcuya rezerve etiniz.\nDevam etmek için bir tuşa basın...");
                    }

                }
                else if (secim == "2")
                {

                    string[] economyKoltuklar = koltuklar.Skip(8).Take(20).ToArray();

                    Console.WriteLine("Business Class bölümünde boş kalan koltuklar:");

                    for (int i = 0; i < economyKoltuklar.Length; i++)
                    {
                        if (rezervasyonYapanlar[i] == null)
                        {
                            Console.WriteLine($"- {economyKoltuklar[i]}");
                        }
                    }
                    string koltukNumarasi = Console.ReadLine();
                    Console.WriteLine($"Seçilen Koltuk Numarası : {koltukNumarasi}");

                    int index = Array.IndexOf(economyKoltuklar, koltukNumarasi);
                    if (rezervasyonYapanlar[index] != null)
                    {
                        Console.WriteLine($"{koltukNumarasi} numaralı koltuğu {rezervasyonYapanlar[index]} isimli yolcuya rezerve edilmiştir..\nLütfen boş koltuklardan birini seçiniz.");
                    }

                    Console.Write("Lütfen Yolcunun Adını ve Soyadını Yazın: ");
                    string adSoyad = Console.ReadLine();


                    if (rezervasyonYapanlar[index] == null)
                    {

                        rezervasyonYapanlar[index] = adSoyad;
                        Console.WriteLine(rezervasyonYapanlar[index]);
                        Console.WriteLine($"Business Class bölümünde {koltukNumarasi} numaralı koltuğu {adSoyad} isimli yolcuya rezerve etiniz.\nDevam etmek için bir tuşa basın...");
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış seçim yaptınız.");

                }
            }
        }
    }
}
