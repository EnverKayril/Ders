namespace ParametreliMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Parametreli Metot: Dışarıdan gelecek olan değerlere göre işlem yönünü değiştirecek olan metotlardır.

            #region Ornek1

            //void EkranaYaziYaz(string ad)
            //{
            //    Console.WriteLine("Merhaba " + ad);
            //}

            //EkranaYaziYaz("Enver");

            //string ogrenciAdi = "Harun";

            //EkranaYaziYaz(ogrenciAdi);

            #endregion

            #region Ornek2

            //int sayi;
            

            //void Saydirici(int kacaKadarSayim)
            //{
            //    int ciftsayitoplam=0;
            //    int teksayitoplam=0;

            //    for (int i = 0; i <= kacaKadarSayim; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            ciftsayitoplam += i;
            //        }
            //        else
            //        {
            //            teksayitoplam += i;
            //        }
            //    }
            //    Console.WriteLine("Çift Sayıların Toplamı: " + ciftsayitoplam + " Tek Sayıların Toplamı: " + teksayitoplam);

            //}

            //Console.Write("Bir Sayı Giriniz: ");

            //Saydirici(Convert.ToInt32(Console.ReadLine()));


            #endregion

            #region Ornek3

            //void MailGonderme(string mailler)
            //{
            //    foreach (string kisiler in mailler.Split(";"))
            //    {
            //        Console.WriteLine($"Mail Gönderildi {kisiler}");
            //    }
            //}
            //Console.WriteLine("Mail Giriniz:");
            //String Mailler = Console.ReadLine();

            //MailGonderme(Mailler);

            #endregion



        }
    }
}
