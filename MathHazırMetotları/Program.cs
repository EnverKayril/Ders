namespace MathHazırMetotları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math Class

            //Hazır olarak onlarca matematiksel fonksiyonlar bize sunar.

            //Mutlak Değer
            Console.WriteLine("Mutlak Değer " + Math.Abs(-45));

            //Floor - Bir alt değere tamamlar.
            Console.WriteLine("Floor " + Math.Floor(12.98));

            //Ceiling - Bir üst değere tamamlar.
            Console.WriteLine("Ceiling " + Math.Ceiling(19.20));

            //Round - Yasının yarısından fazlasını bir üste, yarısından azını bir alta yuvarlar.
            //Ama .50 ise her zaman çift sayıya yuvarlar.
            Console.WriteLine("Round " + Math.Round(12.50));

            //Truncate - sayının ondalığına bakmaz tam sayının kendisini size teslim eder.
            Console.WriteLine("Truncate " + Math.Truncate(12.99));

            //Max
            Console.WriteLine("Max " + Math.Max(45,65));

            //Min
            Console.WriteLine("Min" + Math.Min(45,25));

            //Pow - Kuvvet alma
            Console.WriteLine("Kuvvet alma " + (3,4));

            //Sign - Bir sayının negatif, pozitif, nötr olma durumunu döner.
            Console.WriteLine("Sign " + (-25));

            //Dışarıdan girilen 3 sayının en küçüğünü getiren programı yazınız. if ve for kullanmadan.

            Console.WriteLine("3 sayı giriniz : ");
            
            int sayi1 = int.Parse(Console.ReadLine());
            int sayi2 = int.Parse(Console.ReadLine());
            int sayi3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Min(sayi1,Math.Min(sayi2,sayi3)));

        }
    }
}
