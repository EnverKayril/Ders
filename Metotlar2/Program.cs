using System.Threading.Channels;

namespace Metotlar2
{
    internal class Program
    {
        //Programı çalıştırmak start noktası
        static void Main(string[] args)
        {
            MesajYaz();
        }


        /// <summary>
        /// Maaş Hesaplama Bilgileri İsteyen Metot.
        /// </summary>
        private static void MesajYaz()
        {
            double cUcret = 0;
            double cSaat = 0;
            double maas = 0;

            Console.WriteLine("Persone Adı: ");
            string adi = Console.ReadLine();

            Console.WriteLine("Personel Tipi [isci - memur - yonetici]");
            string pTip = Console.ReadLine();

            if (pTip == "isci")
            {
                Console.WriteLine("Maaşınız " + MaasHesapla());
            }
            else if (pTip == "memur")
            {
                Console.WriteLine("Saatlik Ücret: ");
                cUcret = double.Parse(Console.ReadLine());

                Console.WriteLine("Çalışma Saati: ");
                cSaat = double.Parse(Console.ReadLine());

                maas = MaasHesapla(cUcret, cSaat);
                Console.WriteLine($"Merhaba {adi} Net Maaşınız: {maas} Brut Maaşınız: {SigortaEkle(maas)}");
            }
            else if(pTip == "yonetici")
            {
                Console.WriteLine("Saatlik Ücret: ");
                cUcret = double.Parse(Console.ReadLine());

                Console.WriteLine("Çalışma Saati: ");
                cSaat = double.Parse(Console.ReadLine());

                Console.WriteLine("Bonus: ");
                double bonus = double.Parse(Console.ReadLine());

                double yMaas = MaasHesapla(cUcret, cSaat, bonus);
                Console.WriteLine($"Merhaba {adi} Net Maaşınız: {maas + bonus} Brut Maaşınız: {SigortaEkle(maas)}");
            }

            double SigortaEkle(double maas)
            {
                return maas = maas * 1.30;
            }

        }
        /// <summary>
        /// Personelin Maaşını Hesaplayıp Double Cinsinden Geri Döndürür.
        /// </summary>
        /// <param name="saatlikücret">Double Saatlik Ücret Oranı</param>
        /// <param name="saat">Double Personel Çalışma Saati</param>
        /// <returns>Toplam Maaş</returns>
        private static double MaasHesapla(double saatlikücret, double saat)
        {
            double personelMaas;
            personelMaas = saatlikücret * saat;
            if (saat > 0) 
            {
            return personelMaas;
            }
            else
            {
                return 0;
            }

        }

        //Metot Overloadin - Metot Aşırı Yükleme
        private static double MaasHesapla(double saatlikücret, double saat, double bonus)
        {
            double personelMaas;
            personelMaas = (saatlikücret*saat)+bonus;
            if (saat > 0)
            {
                return personelMaas;
            }
            else
            {
                return 0;
            }
        }

        private static double MaasHesapla()
        {
            return 15000;
        }


        #region GenelBilgilendirme

        //Metot Oluşturma
        //ErisimBelirleyicisi VarsaNitelitici DonusTipi MetotAdi(VarsaParametre)
        //{
        //Metot çağrıldığında çalışacak kodlar.
        //}

        /*
        Erişim Belirleyici: Bir metot yada bir sınıfın nasıl bir erişim seviyesi olduğunu planlamak. -Private -Public

        Niteliyici: static, abstract, sealed, virtual. Static: direkt erişilebilir metot yapma.

        DonusTipi: void, int, string, list vb metot çağırıp kullandığımızda kullanana ne göndereceği.
        */


        #endregion


    }
}
