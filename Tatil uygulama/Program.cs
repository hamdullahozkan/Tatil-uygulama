using System;

class Program
{
    static void Main(string[] args)
    {
        bool devamEtmekIstiyorMu = true;

        while (devamEtmekIstiyorMu)
        {
            Console.Clear();
            Console.WriteLine("3 Günlük Tatil Planlama Uygulamasına Hoş Geldiniz!");

            // 1. Lokasyon seçimi
            string lokasyon = "";
            bool lokasyonGecerli = false;

            while (!lokasyonGecerli)
            {
                Console.WriteLine("\nLütfen gitmek istediğiniz lokasyonu seçiniz: (Bodrum, Marmaris, Çeşme)");
                lokasyon = Console.ReadLine().Trim().ToLower();

                if (lokasyon == "bodrum" || lokasyon == "marmaris" || lokasyon == "çeşme")
                {
                    lokasyonGecerli = true;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Lütfen 'Bodrum', 'Marmaris' veya 'Çeşme' seçeneklerinden birini giriniz.");
                }
            }

            // 2. Kişi sayısı
            int kisiSayisi = 0;
            bool kisiSayisiGecerli = false;

            while (!kisiSayisiGecerli)
            {
                Console.WriteLine("\nKaç kişi için tatil planlamak istiyorsunuz?");
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out kisiSayisi) && kisiSayisi > 0)
                {
                    kisiSayisiGecerli = true;
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir kişi sayısı giriniz.");
                }
            }

            // 3. Lokasyon bilgileri ve ulaşım seçimi
            int paketFiyati = 0;

            switch (lokasyon)
            {
                case "bodrum":
                    paketFiyati = 4000;
                    Console.WriteLine("\nBodrum, muhteşem plajları ve gece hayatıyla ünlüdür!");
                    break;

                case "marmaris":
                    paketFiyati = 3000;
                    Console.WriteLine("\nMarmaris, doğal güzellikleri ve huzurlu atmosferiyle bilinir!");
                    break;

                case "çeşme":
                    paketFiyati = 5000;
                    Console.WriteLine("\nÇeşme, rüzgar sörfü ve eşsiz plajlarıyla meşhurdur!");
                    break;
            }

            // Ulaşım seçimi
            int ulasimFiyati = 0;
            bool ulasimGecerli = false;

            while (!ulasimGecerli)
            {
                Console.WriteLine("\nTatilinize ne şekilde gitmek istersiniz?");
                Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım gidiş-dönüş 1500 TL)");
                Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım gidiş-dönüş 4000 TL)");

                string ulasimSecimi = Console.ReadLine();

                if (ulasimSecimi == "1")
                {
                    ulasimFiyati = 1500;
                    ulasimGecerli = true;
                }
                else if (ulasimSecimi == "2")
                {
                    ulasimFiyati = 4000;
                    ulasimGecerli = true;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Lütfen '1' ya da '2' seçeneğini giriniz.");
                }
            }

            // 4. Toplam fiyat hesaplama
            int toplamFiyat = (paketFiyati * kisiSayisi) + (ulasimFiyati * kisiSayisi);

            Console.WriteLine($"\nTatil Planınız:");
            Console.WriteLine($"Lokasyon: {lokasyon.ToUpper()}");
            Console.WriteLine($"Kişi Sayısı: {kisiSayisi}");
            Console.WriteLine($"Ulaşım Türü: {(ulasimFiyati == 1500 ? "Kara yolu" : "Hava yolu")}");
            Console.WriteLine($"Toplam Fiyat: {toplamFiyat} TL");

            // 5. Başka bir tatil planlamak isteyip istemediğini sorma
            Console.WriteLine("\nBaşka bir tatil planlamak ister misiniz? (Evet/Hayır)");
            string devamCevap = Console.ReadLine().Trim().ToLower();

            if (devamCevap != "evet")
            {
                devamEtmekIstiyorMu = false;
                Console.WriteLine("\nİyi günler dileriz!");
            }
        }
    }
}

