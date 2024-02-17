namespace ArraySinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ornekdizi = { "İstanbul", "Ankara", "İzmir", "Bursa", "Eskişehir", "Konya", "Trabzon", "Sivas", "Eskişehir" };

            #region Clear

            //Array.Clear() => Diziden eleman silmek için kullanılır.
            //Array.Clear(ornekdizi, 2, 3);

            #endregion

            #region Copy

            ////Bir diziden başka bir diziye eleman kopyalamak için kullanılır.
            //string[] yeniSehirler = new string[4];

            ////Array.Copy(ornekdizi, yeniSehirler, 4);

            //Array.Copy(ornekdizi, 3, yeniSehirler, 1, 1);

            //for (int i = 0; i < yeniSehirler.Length; i++) ;
            //{
            //    Console.WriteLine(yeniSehirler[i]);
            //}

            #endregion

            #region IndexOf

            //Dizide aradığımız kelimenin index'ini verir. Aramaya baştan başlar. Eğer eleman dizide birden fazla yerde geçiyorsa size ilk değeri döndürür. Eğer dizide bulamazsa -1 döndürür.

            //Console.WriteLine("Şehir Gir: ");
            //string gelenDeger = Console.ReadLine();

            //int index = Array.IndexOf(ornekdizi, gelenDeger);
            //Console.WriteLine(index<0 ? "YOK": "VAR");

            //int index2 = Array.IndexOf(ornekdizi, gelenDeger, 2, 3);
            //Console.WriteLine(index2);

            #endregion

            #region LastIndexOf

            //int index = Array.LastIndexOf(ornekdizi, "Eskişehir");
            //Console.WriteLine(index);

            #endregion

            #region Resize

            //Dizinin boyutunu artırmak veya azaltmak için kullanılır.

            //Array.Resize<string>(ref ornekdizi, 23);

            #endregion

            #region Sort

            //Array.Sort(ornekdizi);

            //foreach (string item in ornekdizi)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Reverse

            //Diziyi tersine çevirme.

            //Array.Reverse(ornekdizi);
            //foreach (var item in ornekdizi)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

        }
    }
}
