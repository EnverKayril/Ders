namespace WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Döngülerin genel amacı belirli bir kod bloğunu tekrarlı bir şekilde çalıştırmaktır.
            C#'da 4 farklı döngü çeşidi bulunmaktadır.

            -While Döngüsü
            -Do While Döngüsü
            -For Döngüsü
            -Foreach Döngüsü
            
            While Döngüsü : Mantıksal bir ifade gerçekleştiği sürece belli bir kod bloğunu tekrarlatılması istenildiği zaman tercih edilir.

             */

            //int a = 1;

            //while (a <= 10)
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //    a++;

            //0-100 arasındaki çift ve tek sayıların toplamlarını bulunuz.

            //int sayac = 0;
            //int ciftlerinToplami = 0;
            //int teklerinToplami = 0;

            //while (sayac <= 100)
            //{
            //    if (sayac % 2 == 0 ) 
            //    {
            //        ciftlerinToplami += sayac;
            //    }
            //    else
            //    {
            //        teklerinToplami += sayac;
            //    }

            //    sayac++;
            //}
            //Console.WriteLine($"Çiftlerin Toplami : {ciftlerinToplami} Teklerin Toplamı : {teklerinToplami}");

            #region Ornek2

            string durum = "yes";

            while (durum != "no")
            {
                Console.WriteLine("Döngünün içindesin");
                Console.WriteLine("Devam mi ? [yes] [no]");
                durum = Console.ReadLine();
            }

            Console.WriteLine("Döngünün dışındasın");


            #endregion


        }

    }
    }

