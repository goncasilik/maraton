using System;

namespace _9Maraton
{
    class Program
    {
        static void Main(string[] args)
        {
            ////9.1 Sayı Çözümleme
            //bool deger = true;
            //while (deger == true)
            //{
            //    Console.Write("Lütfen bir sayı giriniz: ");
            //    if (int.TryParse(Console.ReadLine(), out int value))
            //    {
            //        var array = new int[1];
            //        int counter = 0;
            //        while (value > 0)
            //        {
            //            //Console.WriteLine(value % 10);
            //            array[counter] = value % 10;
            //            counter++;
            //            Array.Resize(ref array, array.Length + 1);
            //            value = value / 10;
            //        }
            //        Array.Resize(ref array, array.Length - 1);
            //        var basamaklar = new int[] { 1, 10, 100, 1000, 10000, 100000, 1000000 };
            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            Console.Write($"{array[i]} x {basamaklar[i]} = {array[i] * basamaklar[i]}");
            //            Console.WriteLine();
            //        }
            //        Console.WriteLine("Çıkış için 'exit' komutunu çalıştırabilirsiniz. Devam etmek için herhangi bir tuşa basın.");
            //        if (Console.ReadLine() == "exit")
            //        {
            //            deger = false;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Girdiğiniz değer bir ondalık sayı değil.");
            //    }
            //}
            //9.2 Palindrome
            //bool deger1 = true;
            //while (deger1 == true)
            //{
            //    Console.Write("Bir tamsayı giriniz: ");
            //    if (int.TryParse(Console.ReadLine(), out int value1))
            //    {
            //        var array1 = new int[1];
            //        int counter1 = 0;
            //        while (value1 > 0)
            //        {
            //            //Console.WriteLine(value % 10);
            //            array1[counter1] = value1 % 10;
            //            counter1++;
            //            Array.Resize(ref array1, array1.Length + 1);
            //            value1 = value1 / 10;
            //        }
            //        Array.Resize(ref array1, array1.Length - 1);
            //        for (int i = 0; i < array1.Length / 2; i++)
            //        {
            //            if (array1[i] == array1[array1.Length])
            //            {

            //            }
            //        }
            //        Console.WriteLine("Çıkış için 'exit' komutunu çalıştırabilirsiniz. Devam etmek için herhangi bir tuşa basın.");
            //        if (Console.ReadLine() == "exit")
            //        {
            //            deger1 = false;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Girdiğiniz değer bir tam sayı değildir.");
            //    }
            //}
            //9.3
            //OtoparkSecenekler();
            //bool kontrol = true;
            //while (kontrol == true)
            //{
            //    Console.Write("Aracınızı seçiniz: ");
            //    if (int.TryParse(Console.ReadLine(), out int value3))
            //    {
            //        double saat;
            //        int sonuc;
            //        switch (value3)
            //        {
            //            case 1:
            //                saat = SaatSor();
            //                sonuc = UcretBul(value3, saat);
            //                Console.WriteLine($"Ödenmesi gereken tutar: {sonuc}TL");
            //                kontrol = false;
            //                break;
            //            case 2:
            //                saat = SaatSor();
            //                sonuc = UcretBul(value3, saat);
            //                Console.WriteLine($"Ödenmesi gereken tutar: {sonuc}TL");
            //                kontrol = false;
            //                break;
            //            case 3:
            //                saat = SaatSor();
            //                sonuc = UcretBul(value3, saat);
            //                Console.WriteLine($"Ödenmesi gereken tutar: {sonuc}TL");
            //                kontrol = false;
            //                break;
            //            case 4:
            //                saat = SaatSor();
            //                sonuc = UcretBul(value3, saat);
            //                Console.WriteLine($"Ödenmesi gereken tutar: {sonuc}TL");
            //                kontrol = false;
            //                break;
            //            default:
            //                Console.WriteLine("Seçeneklerden birini girmediniz. Tekrar deneyiniz.");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Doğru formatta giriş yapmadınız. Tekrar deneyiniz");
            //    }
            //}
            //9.4
            Console.WriteLine("1. Bussiness Class bölümü için 1 tuşuna basın");
            Console.WriteLine("2. Economy Class bölümü için 2 tuşuna basın");
            bool durum = true, koltukDurum;
            var business = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var economy = new int[] { 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int koltukNo;
            var ad = new string[20];
            var soyad = new string[20];
            while (durum == true)
            {
                if (int.TryParse(Console.ReadLine(), out int secim))
                {
                    switch (secim)
                    {
                        case 1:
                            KoltuklariGoster(business, economy);
                            BosKoltuklar(business, "Business Class");
                            Console.Write("Lütfen almak istediğiniz koltuk numarasını giriniz: ");
                            koltukNo = KoltukNoAl(1, business);
                            koltukDurum = KoltukKontrol(ad, soyad, koltukNo);
                            if (koltukDurum == false)
                            {
                                Console.Write("Kayıt için adınızı giriniz: ");
                                ad[koltukNo - 1] = Console.ReadLine();
                                Console.Write("Kayıt için soyadınızı giriniz: ");
                                soyad[koltukNo - 1] = Console.ReadLine();
                                Console.WriteLine($"Bussiness Class bölümündeki {koltukNo} numaralı koltuğu {ad[koltukNo - 1]} {soyad[koltukNo - 1]} isimli kişiye rezerv edilmiştir.");
                                Array.Clear(business, koltukNo - 1, 1);
                                Console.WriteLine("Bilet seçmek için 1- Business Class || 2- Economy Class");
                            }
                            else
                            {
                                Console.WriteLine($"{koltukNo} numaralı koltuk daha önce {ad[koltukNo - 1]} {soyad[koltukNo - 1]} isimli yolcuya rezerv edilmiştir.");
                                BosKoltuklar(business, "Business Class");
                            }
                            int count = 0;
                            for (int i = 0; i < 8; i++)
                            {
                                //Console.WriteLine(ad[i]);
                                if (ad[i] != null)
                                {
                                    count++;
                                }
                            }
                            if (count == 8)
                            {
                                Console.WriteLine("Seçtiğiniz Business Class bölümünde boş koltuk kalmamıştır.");
                                Console.WriteLine("Economy Class bölümündeki boş koltukları görmek ister misiniz? evet || hayır");
                                if (Console.ReadLine() == "evet")
                                {
                                    durum = true;
                                }
                                else
                                {
                                    Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır..");
                                }
                                durum = false;
                            }
                            //durum = false;
                            break;
                        case 2:
                            KoltuklariGoster(business, economy);
                            BosKoltuklar(economy, "Economy Class");
                            Console.Write("Lütfen almak istediğiniz koltuk numarasını giriniz: ");
                            koltukNo = KoltukNoAl(2, economy);
                            koltukDurum = KoltukKontrol(ad, soyad, koltukNo);
                            if (koltukDurum == false)
                            {
                                Console.Write("Kayıt için adınızı giriniz: ");
                                ad[koltukNo - 1] = Console.ReadLine();
                                Console.Write("Kayıt için soyadınızı giriniz: ");
                                soyad[koltukNo - 1] = Console.ReadLine();
                                Console.WriteLine($"Economy Class bölümündeki {koltukNo} numaralı koltuğu {ad[koltukNo - 1]} {soyad[koltukNo - 1]} isimli kişiye rezerv edilmiştir.");
                                Array.Clear(economy, koltukNo - 9, 1);
                                Console.WriteLine("Bilet seçmek için 1- Business Class || 2- Economy Class");
                            }
                            else
                            {
                                Console.WriteLine($"{koltukNo} numaralı koltuk daha önce {ad[koltukNo - 1]} {soyad[koltukNo - 1]} isimli yolcuya rezerv edilmiştir.");
                                BosKoltuklar(economy, "Economy Class");
                            }
                            int count1 = 0;
                            for (int i = 8; i < 20; i++)
                            {
                                //Console.WriteLine(ad[i]);
                                if (ad[i] != null)
                                {
                                    count1++;
                                }
                            }
                            if (count1 == 8)
                            {
                                Console.WriteLine("Seçtiğiniz Economy Class bölümünde boş koltuk kalmamıştır.");
                                Console.WriteLine("Business Class bölümündeki boş koltukları görmek ister misiniz? evet || hayır");
                                if (Console.ReadLine() == "evet")
                                {
                                    durum = true;
                                }
                                else
                                {
                                    Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır..");
                                }
                                durum = false;
                            }
                            //durum = false;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen giriş değeri olarak sayı bir değer giriniz");
                }
            }
            //    //9.5
            //    string kadi = "gorselprogramlama.com", sifre = "1234";
            //    string girilenkadi;
            //    string pass = "";


            //    Console.Write("Kullanıcı Adı ... ");
            //    girilenkadi = Console.ReadLine();
            //    Console.Write("Şifreyi Giriniz ... ");
            //    ConsoleKeyInfo key;
            //    do
            //    {
            //        key = Console.ReadKey(true);
            //        if (key.Key != ConsoleKey.Backspace)
            //        {
            //            pass += key.KeyChar;
            //            Console.Write("*");
            //        }
            //        else
            //        { Console.Write("\b"); }
            //    }
            //    while (key.Key != ConsoleKey.Enter);
            //    if (girilenkadi != kadi && sifre != pass)
            //    {
            //        Console.WriteLine("\nKullanıcı Adı veya Şifre Hatalı");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nTebrikler");
            //    }

            //    Console.ReadKey();
            //}
            //static bool KoltukKontrol(string[] name, string[] surname, int seat)
            //{
            //    bool value;
            //    if (name[seat - 1] != null && surname[seat - 1] != null)
            //    {
            //        value = true;
            //    }
            //    else
            //    {
            //        value = false;
            //    }
            //    return value;
            //}
            //static int KoltukNoAl(int sinif, int[] dizi)
            //{
            //    bool devam = true;
            //    int deger = 0;
            //    while (devam == true)
            //    {
            //        switch (sinif)
            //        {
            //            case 1:
            //                if (int.TryParse(Console.ReadLine(), out deger))
            //                {
            //                    if (0 < deger && deger < 9)
            //                    {
            //                        Console.WriteLine($"Seçtiğiniz koltuk numarası: {deger}");
            //                        devam = false;
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Belirlenen aralıkta bir koltuk numarası seçmediniz.");
            //                    }  
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Lütfen koltuk numaralarından birini seçiniz");
            //                }
            //                break;
            //            case 2:
            //                if (int.TryParse(Console.ReadLine(), out deger))
            //                {
            //                    if (8 < deger && deger < 21)
            //                    {
            //                        Console.WriteLine($"Seçtiğiniz koltuk numarası: {deger}");
            //                        devam = false;
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Belirlenen aralıkta bir koltuk numarası seçmediniz.");
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Lütfen koltuk numaralarından birini seçiniz");
            //                }
            //                break;
            //        }
            //    }
            //    return deger;
            //}
            //static void BosKoltuklar(int[] dizi, string deger)
            //{
            //    Console.WriteLine($"{deger} bölümünde boş olan koltuklar");
            //    for (int i = 0; i < dizi.Length; i++)
            //    {
            //        Console.WriteLine("-" + dizi[i]);
            //    }
            //}
            //static void KoltuklariGoster(int[] dizi1, int[] dizi2)
            //{
            //    Console.Write("Business: ");
            //    for (int i = 0; i < dizi1.Length; i++)
            //    {
            //        Console.Write(dizi1[i]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //    Console.Write("Economy: ");
            //    for (int i = 0; i < dizi2.Length; i++)
            //    {
            //        Console.Write(dizi2[i]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //static void OtoparkSecenekler()
            //{
            //    Console.WriteLine("1. Otomobil için 1'e basın");
            //    Console.WriteLine("2. Motosiklet için 2'ye basın");
            //    Console.WriteLine("3. Minibüs için 3'e basın");
            //    Console.WriteLine("4. Kamyon ve diğer araçlar için 4'e basın");
            //}
            //static int SaatSor()
            //{
            //    int saat = 0;
            //    bool durum = true;
            //    while (durum == true)
            //    {
            //        Console.Write("Araç kaç sayat boyunca park alanında kaldı? ");
            //        if (int.TryParse(Console.ReadLine(), out saat))
            //        {
            //            durum = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
            //        }
            //    }
            //    return saat;
            //}
            //static int UcretBul(int arac, double saat)
            //{
            //    int ucret = 0;
            //    switch (arac)
            //    {
            //        case 1:
            //            if (2 >= saat)
            //            {
            //                ucret = 5;
            //            }
            //            else if (6 >= saat)
            //            {
            //                ucret = 10;
            //            }
            //            else if (12 >= saat)
            //            {
            //                ucret = 20;
            //            }
            //            else if (24 >= saat)
            //            {
            //                ucret = 35;
            //            }
            //            else
            //            {
            //                double gun = saat / 24;
            //                int gunInt = Convert.ToInt32(gun);
            //                ucret = 35 + (20 * gunInt);
            //            }
            //            break;
            //        case 2:
            //            if (2 >= saat)
            //            {
            //                ucret = 0;
            //            }
            //            else if (6 >= saat)
            //            {
            //                ucret = 3;
            //            }
            //            else if (12 >= saat)
            //            {
            //                ucret = 6;
            //            }
            //            else if (24 >= saat)
            //            {
            //                ucret = 12;
            //            }
            //            else
            //            {
            //                double gun = saat / 24;
            //                int gunInt = Convert.ToInt32(gun);
            //                ucret = 12 + (10 * gunInt);
            //            }
            //            break;
            //        case 3:
            //            if (2 >= saat)
            //            {
            //                ucret = 8;
            //            }
            //            else if (6 >= saat)
            //            {
            //                ucret = 16;
            //            }
            //            else if (12 >= saat)
            //            {
            //                ucret = 32;
            //            }
            //            else if (24 >= saat)
            //            {
            //                ucret = 45;
            //            }
            //            else
            //            {
            //                double gun = saat / 24;
            //                int gunInt = Convert.ToInt32(gun);
            //                ucret = 45 + (25 * gunInt);
            //            }
            //            break;
            //        case 4:
            //            if (2 >= saat)
            //            {
            //                ucret = 15;
            //            }
            //            else if (6 >= saat)
            //            {
            //                ucret = 30;
            //            }
            //            else if (12 >= saat)
            //            {
            //                ucret = 60;
            //            }
            //            else if (24 >= saat)
            //            {
            //                ucret = 100;
            //            }
            //            else
            //            {
            //                double gun = saat / 24;
            //                int gunInt = Convert.ToInt32(gun);
            //                ucret = 100 + (55 * gunInt);
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Uygun bir saat formatı girmediniz");
            //            ucret = 0;
            //            break;
            //    }
            //    return ucret;
        }
    }
}
