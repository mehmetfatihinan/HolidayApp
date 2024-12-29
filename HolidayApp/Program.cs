using System;
using System.Collections.Generic;

namespace HolidayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueBooking = true;

            while (continueBooking)
            {
                Console.WriteLine("Tatil Paketi Uygulamasina Hosgeldiniz ! ");
                Console.WriteLine("Lutfen Tatil Paketinizin Turunu Seciniz : ");

                bool validChoice = false;
                string choice = string.Empty;
                int cost = 0;

                while (!validChoice)
                {
                    Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)\n2 - Marmaris (Paket başlangıç fiyatı 3000 TL) \n3 - Çeşme (Paket başlangıç fiyatı 5000 TL)\n");
                    Console.Write("Seciminizi yapiniz (Bodrum - Marmaris - Cesme) : ");
                    choice = Console.ReadLine().ToLower();

                    switch (choice)
                    {
                        case "bodrum":
                            Console.WriteLine($"Secilen Tatil Paketi: Bodrum, Fiyat: 4000 TL");
                            validChoice = true; cost = 4000;
                            break;
                        case "marmaris":
                            Console.WriteLine($"Secilen Tatil Paketi: Marmaris, Fiyat: 3000 TL");
                            validChoice = true; cost = 3000;
                            break;
                        case "cesme":
                            Console.WriteLine($"Secilen Tatil Paketi: Cesme, Fiyat: 5000 TL");
                            validChoice = true; cost = 5000;
                            break;
                        default:
                            Console.WriteLine("Gecersiz secim, lutfen tekrar deneyiniz.");
                            break;
                    }
                }

                Console.Write("Kac kisi icin rezervasyon yapmak istiyorsunuz? ");
                int personCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{personCount} kisi icin rezervasyon kaydedilmistir.");

                // Konum açıklamaları
                switch (choice)
                {
                    case "bodrum":
                        Console.WriteLine("Bodrum'da tarihi Bodrum Kalesi'ni ziyaret edebilir, muhteşem plajlarında yüzebilir ve en iyi restorantların tadını çıkarabilirsiniz.");
                        break;
                    case "marmaris":
                        Console.WriteLine("Marmaris'te eşsiz koylarda tekne turlarına katılabilir, tarihi Marmaris Kalesi'ni gezebilir ve su sporlarında arkadaslarınızda keyifli dakikalar yasayabilirsiniz.");
                        break;
                    case "cesme":
                        Console.WriteLine("Çeşme'de Alaçatı'nın taş sokaklarında gezebilir, rüzgar sörfü yapabilir ve termal suları deneyimleyebilirsiniz.");
                        break;
                }

                bool validTransportChoice = false;
                int transportCost = 0;

                while (!validTransportChoice)
                {
                    Console.Write("Hangi ulaşım türünü tercih ediyorsunuz? \n" +
                        "1 - Havayolu : 4000 TL\n" +
                        "2 - Karayolu : 1500 TL\n");
                    string transportChoice = Console.ReadLine();

                    switch (transportChoice)
                    {
                        case "1":
                            transportCost = 4000;
                            validTransportChoice = true;
                            break;
                        case "2":
                            transportCost = 1500;
                            validTransportChoice = true;
                            break;
                        default:
                            Console.WriteLine("Gecersiz secim, lutfen tekrar deneyiniz.");
                            break;
                    }
                }

                decimal totalCost = (cost + transportCost) * personCount;

                // Konumun baş harfini büyük yapma
                string formattedChoice = char.ToUpper(choice[0]) + choice.Substring(1);

                Console.WriteLine($"\nRezervasyon Ozeti:");
                Console.WriteLine($"Konum: {formattedChoice}");
                Console.WriteLine($"Toplam Kisi Sayisi: {personCount}");
                Console.WriteLine($"Ulaşım Türü: {(transportCost == 4000 ? "Havayolu" : "Karayolu")}");
                Console.WriteLine($"Toplam Maliyet: {totalCost} TL");

                Console.Write("Başka bir tatil paketi rezervasyonu yapmak ister misiniz? (Evet/Hayir): ");
                string continueResponse = Console.ReadLine().ToLower();

                if (continueResponse != "evet")
                {
                    continueBooking = false;
                }
            }

            Console.WriteLine("Çıkış yapılıyor. İyi günler dileriz!");
        }
    }

    class HolidayPackage
    {
        public string Location { get; set; }
        public decimal Price { get; set; }
    }
}
