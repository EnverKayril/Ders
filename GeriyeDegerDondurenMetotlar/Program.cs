namespace GeriyeDegerDondurenMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ornek1

            //string EkranaYaziYaz()
            //{
            //    return "Enver Kayril";
            //}
            //Console.WriteLine(EkranaYaziYaz());

            #endregion

            #region Ornek2

            //void Topla(int sayi1,int sayi2)
            //{
            //    Console.WriteLine(sayi1 + "+" + sayi2 + "=" + (sayi1 + sayi2));
            //}

            //Topla(5, 9);

            //int Topla(int sayi1,int sayi2)
            //{
            //    int toplam;
            //    toplam = sayi1+ sayi2;
            //    return toplam;
            //}

            //int deneme = Topla(15,20) + 10;
            //Console.WriteLine(deneme);

            #endregion

            #region Ornek3

            //double sayi1, sayi2;
            //string islem;

            //Console.WriteLine("Hesap Makinesi Programı [+ , - , * , /]");

            //Console.Write("sayi1: ");
            //sayi1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("sayi2: ");
            //sayi2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("İşlem [+ , - , * , /] : ");
            //islem = Console.ReadLine();

            //if (islem == "+")
            //{
            //    Console.WriteLine(Topla(sayi1, sayi2));
            //}
            //else if (islem == "-")
            //{
            //    Console.WriteLine(Fark(sayi1, sayi2));
            //}
            //else if (islem == "*")
            //{
            //    Console.WriteLine(Carpim(sayi1, sayi2));
            //}
            //else if (islem == "/")
            //{
            //    Console.WriteLine(Bolum(sayi1, sayi2));
            //}

            //HesapMakinesi();

            //bool devamMi = true;
            //while (devamMi)
            //{
            //    HesapMakinesi();
            //    Console.WriteLine("Devam Etmek İstiyor Musun? [E - H]");
            //    devamMi = Console.ReadLine().ToUpper() == "E" ? true : false;
            //}


            #endregion

            #region Ornek4


            Double kdvHesaplama(double urunFiyat, double kdvOran)
            {
                double kdvliFiyat = urunFiyat + (kdvOran / 100 * urunFiyat);
                return kdvliFiyat;
            }

            Console.Write("Ürün fiyatı giriniz: ");
            double urunFiyat = Convert.ToDouble(Console.ReadLine());
            Console.Write("KDV oranı giriniz: ");
            double kdvOran = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("KDVli Fiyat" + kdvHesaplama(urunFiyat,kdvOran));


            #endregion


        }
    }
}
