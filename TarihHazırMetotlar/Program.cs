namespace TarihHazırMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datetime => Zamanla ilgili yapabileceğimiz tüm işlemleri ve tüm verileri size teslim eden nesnemizdir.

            //DateTime bugun = DateTime.Now;

            Console.WriteLine(DateTime.Now);

            //Günün tarihini alma
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongDateString());

            //Şu anki zamanı alma
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());

            //Tarih formatlama
            Console.WriteLine(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);

            Console.WriteLine(DateTime.Now.TimeOfDay.ToString());

            //Artık yılı kontrolü
            bool artikYil = DateTime.IsLeapYear(2016);
            Console.WriteLine(artikYil == true ? "Şubat 29 çeker" : "Şubat 28 çeker");

            //İki zaman arasındaki farkı alıp bizlere teslim eder.
            DateTime yeniZaman = new DateTime(1992, 09, 10, 10, 09, 30);
            DateTime bugun = DateTime.Now;

            TimeSpan zamanFarki = bugun - yeniZaman;
            double toplamGun = zamanFarki.TotalDays;
            Console.WriteLine($"{toplamGun} kadar gündür hayattasın.");

        }
    }
}
