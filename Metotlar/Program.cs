namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metotlar, belirli bir işlevi yerine getirmek için hazırlanmış belirli bir kod bloğunu bir isim altında toplayıp kodu çalıştırmak istediğimizde vermiş olduğumuz isimle çağırıp kodun yeniden kullanılmasına izin veren programlama yapılarıdır.

            //Metot Oluşturma - Geriye Değer Döndürmeye Metot(void)

            #region Ornek1

            void EkranaYaziYaz()
            {
                Console.WriteLine("Merhaba Enver");
            }

            //EkranaYaziYaz();

            #endregion

            #region Ornek2

            //int son;

            //son = Convert.ToInt32(Console.ReadLine());

            //void Say()
            //{
            //    for (int i = 0; i <= son; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Say();

            #endregion

            #region Ornek3

            
            int ciftSayiToplami = 0;
            int tekSayiToplami = 0;

            void TekCift()
            {
                Console.WriteLine("Sayı giriniz;");
                int sayi = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= sayi; i++)
                {
                    if (i %2 == 0)
                    {
                        ciftSayiToplami += i;
                    }

                    else
                    {
                        tekSayiToplami += i;
                    }
                }
                Console.WriteLine("Çiftleri Toplamı: " + ciftSayiToplami + " Teklerin Toplamı: " + tekSayiToplami);
            }

            TekCift();




            #endregion

        }
    }
}
