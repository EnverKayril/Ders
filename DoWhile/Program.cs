namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While gibi çalışır. Tek fark ilk kod bloğu çalıştıktan sonra koşula bakılır.

            #region Ornek1

            //string durum = "yes";

            //do
            //{
            //    Console.WriteLine("Döngünün içindesin");
            //    Console.WriteLine("Devam mi ? [yes] [no]");
            //    durum = Console.ReadLine();

            //} while (durum != "no");
            //Console.WriteLine("Döngünün Dışındasın");

            #endregion

            //string kullaniciadi = "";
            //string kullanicisifre = "";

            //do
            //{
            //    Console.Write("Kullanici adi giriniz: ");
            //    kullaniciadi = Console.ReadLine();

            //    Console.Write("Kullanici sifre giriniz: ");
            //    kullanicisifre= Console.ReadLine();

            //} while ((kullaniciadi != "admin") || (kullanicisifre != "1234"));

            // Faktoriyel hesabı


            int factoriyel = 1;
            int sayi = 1;

            Console.WriteLine("Sayi giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi > 1)
            {
                factoriyel *= sayi;
                sayi--;
            }
            Console.WriteLine("Sonuç = " + factoriyel);


        }
    }
}
