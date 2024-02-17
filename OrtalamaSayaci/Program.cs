namespace OrtalamaSayaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ortalama Hesaplama Programı");

            double toplam = 0;
            double sayac = 0;
            
            bool devam = true;
            while (devam)
            {
                Console.Write("Bir sayı giriniz: ");
                try
                {
                double sayi = Convert.ToDouble(Console.ReadLine());

                    toplam += sayi;
                    sayac++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı değer girdiniz.");
                }

                Console.Write("Başka bir sayı girmek istiyor musunuz? (E/H) ");
                devam = Console.ReadLine().ToUpper() == "E";
            }
                double ortalama = toplam / sayac;
            Console.Write($"Girdiğiniz sayıların ortalaması : {ortalama}");
        }
    }
}
