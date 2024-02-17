namespace TernaryIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ternary Operatoru
            // Tek satırda ufak bir karar mekanizması ile yolunuza devam etmek istiyorsanız, soru işareti operatörü size bu pratikliği sağlar.

            // KontrolEdilecekDeğer (KarşılaştırmaOperatörü) ? Durumun olumlu olma durumu : Durumun olumsuz olma durumu

            //string girilendeger = "Bilge Adam";

            //Console.WriteLine(girilendeger == "Bilge Adam" ? "Doğru Değer" : "Hatalı Değer" );

            string sonuc = 10 < 0 ? "Küçüktür" : "Büyüktür";
            Console.WriteLine(sonuc);



        }
    }
}
