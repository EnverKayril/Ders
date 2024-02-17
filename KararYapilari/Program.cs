using System.ComponentModel.Design;

namespace KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /* 
             Uygulamanin çalismasi esnasinda farkli senaryolara gore farkli yonlendirmeler yapacagimiz
            durumlarda kullanilir.

            KARSILASTIRMA Operatörleri
            1) == (Karsilikli iki degerin esit olmasi durumu)
            2) != (Karsilikli iki degerin esit olmamasi durumu)
            3) <
            4) >
            5) <=
            6) >=
            */

            #region Ornek1


            //Console.WriteLine("User Name: ");
            //string userName = Console.ReadLine();
            //if (userName != "admin") 
            //{
            //    Console.WriteLine("Hoşgeldin Sahip");
            //}
            //else
            //{
            //    Console.WriteLine("Üzgünüm tanıyamadım.");
            //}
            #endregion

            #region Ornek2
            //Eger girilen not 0'dan küçükse "0'dan küçük bir not girişi yapamazsınız." 100'den büyükse
            // "100'den büyük bir not girişi yapamazsınız.

            //Console.WriteLine("Not: ");
            //int not = Convert.ToInt32(Console.ReadLine());

            //if (not < 0 )
            //{
            //    Console.WriteLine("0'dan küçük bir not girişi yapamazsınız.");
            //}
            //else if (not > 100)
            //{
            //    Console.WriteLine("100'den büyük bir not girişi yapamazsınız.");
            //}
            //else {
            //    Console.WriteLine("Notunuz geçerli.");
            //       }


            #endregion

            #region Ornek3

            // Kullanıcıdan alınan sayının tek mi çift mi olduğunu ekrana yazan program.

            //Console.WriteLine("Bir sayi giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi % 2 == 0)
            //    Console.WriteLine("Girdiğiniz Sayı Çift.");
            //else
            //    Console.WriteLine("Girdiğiniz Sayı Tek");

            #endregion

            /*
             Mantıksal operatörler : Birden fazla durumun aynı anda kontrol edilmesi senaryosunda
            kullanılır.
            && (VE)
            || (VEYA)
             */

            #region Ornek4

            //Console.Write("Kullanici adi: ");
            //string kullaniciadi = Console.ReadLine();
            //Console.Write("Sifre: ");
            //int sifre = Convert.ToInt32(Console.ReadLine());

            //if (kullaniciadi == "admin" && sifre == 1234)
            //    Console.WriteLine("Giris Basarili!");
            //else Console.WriteLine("Giris Basarisiz.");

            #endregion

            #region Ornek5

            /* Girilen not 0-30 aralığında ise FF
             *             30-50 aralığında ise DD
             *             50-70 aralığında ise BB
             *             70-100 aralığında ise AA
            */

            //Console.Write("Notunuzu Giriniz: ");
            //int not = Convert.ToInt32(Console.ReadLine());

            //if (not >= 70 && not <= 100)
            //    Console.WriteLine("AA");
            //else if (not >= 50 && not < 70)
            //    Console.WriteLine("BB");
            //else if (not >= 30 && not < 50)
            //    Console.WriteLine("DD");
            //else if (not < 30 && not >= 0)
            //    Console.WriteLine("FF");
            //else Console.WriteLine("Geçersiz Değer Girdiniz");

            #endregion

            #region Ornek6
            /*
             Dışarıdan ürün adı girilecek, kasiyer bize ürünün hangi bölümde olduğunu söyleyecek.
            /Domates, biber, patlıcan > sebze
            diş macunu deororant parfüm şampuan > kozmetik
            cep telefonu bilgisayar konsol > teknolojik aletler
            başka ürün girilirse > stokda yok
             */

            //Console.Write("Ürün adı giriniz: ");
            //string urun = Console.ReadLine();


            //if (urun == "domates" || urun == "biber" || urun == "patlıcan")
            //    Console.WriteLine(urun + " Sebze reyonundadır.");

            //else if (urun == "dişmacunu" || urun == "deodorant" || urun == "parfüm" || urun == "şampuan")
            //    Console.WriteLine(urun + " Kozmetik reyonundadır.");

            //else if (urun == "ceptelefonu" || urun == "bilgisayar" || urun == "tablet" || urun == "konsol")
            //    Console.WriteLine(urun + " Teknolojik aletler reyonundadır.");

            //else Console.WriteLine(urun + " Stokta yok.");



            #endregion

            #region Ödev

            /*
             Dışarıdan sipariş alınacak olan kitap miktarı girilsin. Sipariş sayısı 20'den az ise toplam 
            ücretten %5 düşülsün, 20-50 aralığında ise %10, 50-100 aralığında ise %15, 100'den fazla ise %25
            indirim yapılsın. Kitabın birim fiyatı 20TL.
             */

            //double birimFiyat = 20;
            //Console.WriteLine("Kitap Sayısı: ");
            //double alinanSiparisMiktari = Convert.ToDouble(Console.ReadLine());
            //double toplamOdenecekTutar = 0;

            //if (alinanSiparisMiktari > 0 && alinanSiparisMiktari <= 20)
            //{ 
            //    toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.95;
            //}
            //else if (alinanSiparisMiktari >= 21 && alinanSiparisMiktari <= 50)
            //{
            //    toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.90; 
            //}
            //else if (alinanSiparisMiktari >= 51 && alinanSiparisMiktari < 100)
            //{
            //    toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.85;
            //}
            //else
            //{
            //    toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.75;
            //}

            //Console.WriteLine("Ödemeniz gereken toplam tutar: " + toplamOdenecekTutar + " TL");



            #endregion





        }
    }
}
