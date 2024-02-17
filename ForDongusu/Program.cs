namespace ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForDongusu

            //           //While döngüsü ile benzer çalışır. Yalnız başlangıç, bitiş değerleri ve artım miktarı döngünün içerisine tanımlanır.


            //           for (int i = 0; i < 10; i++)
            //           {
            //               i = 0;
            //               Console.WriteLine(i);
            //}

            //           /*
            //            For Döngüsü Yapısı:
            //           1 - Baştaki i değişkeni sadece döngünün başında bir defa oluşturulur.
            //           2 - Eğer ortadaki mantıksal ifade doğru ise döngü bloğu çalışır.
            //           3 - Sondaki artım-azaltım fonksiyonu çalışır başlangıç değişkeni güncellenir.
            //           4 - Tekrardan koşula bakılır.
            //           5 - Ortada koşul false olana kadar 3 ve 4 deki işlemler tekrarlanır.
            //            */

            #endregion

            #region Ornek1

            //for (int i = 100; i > 0 ; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 2; i <= 100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 100; i > 1 ; i--)
            //{
            //    Console.WriteLine("Enver");
            //}

            #endregion

            #region Ornek2

            // 1-100 arasındaki çift sayıların toplamı ile tek sayıların toplamını bulunuz.

            //int teksayitoplam = 0;
            //int ciftsayitoplam = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if ( i % 2 == 0)
            //    {
            //        ciftsayitoplam += i;
            //    }
            //    else
            //        teksayitoplam += i;
            //}

            //Console.WriteLine( "Çift Sayıların Toplamı : " + ciftsayitoplam);
            //Console.WriteLine(  "Tek Sayıların Toplamı :" + teksayitoplam);

            #endregion

            #region Ornek3

            // 1945 ile günümüz yılları arasında dön ve ekrana yazdır. Yalnızca 1990 ve 1992 ekrana yazdırma.

            //for (int i = 1945; i < DateTime.Now.Year; i++)
            //{
            //    if (i != 1990 && i!=1992)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

        }
    }
}
