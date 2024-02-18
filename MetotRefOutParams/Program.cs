using System.Security.Cryptography.X509Certificates;

namespace MetotRefOutParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Params
            //Console.WriteLine("Toplam + " + Toplam(5,15,15));

            //Out
            //int i, j;
            //Toplama(out i, out j);

            //Console.WriteLine(i);
            //Console.WriteLine(j);


            //int kare;
            //int top = ToplamveKaresi(out kare, 10, 5);
            //Console.WriteLine("Toplamı: "+top);
            //Console.WriteLine("Karesi: "+kare);


            //double pMaas, Psigorta;
            //MaasHesapla(out pMaas, out Psigorta, 500, 180);
            //Console.WriteLine($"Maaş : {pMaas} Sigorta : {Psigorta} ");

            //Ref

            #region Ref
            ////Değişken a ve b
            //int a = 10; int b=12;

            ////Değişkenleri işlem öncesi yazdır
            //Console.WriteLine("İşlem öncesi a değişkeni: {0}",a);
            //Console.WriteLine("işlem öncesi b değişkeni: {0}",b);

            //Console.WriteLine("****");

            //toplamDeger(a);

            //Console.WriteLine("İşlem sonrası a değişkeni: {0}",a);

            //farkDeger(ref b);

            //Console.WriteLine("İşlem sonrası b değişkeni: {0}", b);

            ////ToplamDeger Tanımla value rype parametreli
            //int toplamDeger(int a)
            //{
            //    return a += 10;
            //}

            //int farkDeger(ref int b) 
            //{
            //    return b -= 5;
            //}



            #endregion

            #region RecursiveMethod
            //Bir fonksiyonun içinde yine kendisinden bir parça bulunuyorsa bu fonsksiyonlara öz yinelemeli (recursive) fonksiyon denir. Metot içinde kendisini tejrardan çağırma işlemi.

            int fakto(int sayi)
            {
                int fak = 1;
                for (int i = 1; i <= sayi; i++)
                {
                    fak = fak * i;
                }
                return fak;
            }
            Console.WriteLine(fakto(5));

            int faktoriyelRecursive(int sayi)
            {
                if(sayi == 0)
                {
                    return 1;
                }
                else
                {
                    return sayi * faktoriyelRecursive(sayi - 1);
                }
            }
            Console.WriteLine(faktoriyelRecursive(6));

            #endregion
        }

        #region Params
        //n sayıda parametre alabilen bir metot oluşturmak için kullanılır.
        //Kullanılacak parametre sayısı hakkında bilginiz olmadığı durumda tercih edilebilir.

        public static int Toplam(params int[] sayilar)
        {
            int toplam = 0;

            foreach (int i in sayilar)
            {
                toplam += i;
            }
            return toplam;
        }


        #endregion

        #region Out

        public static void Toplama(out int p, out int q)
        {
            p = 30;
            q = 40;
            p += p;
            q += q;

            int toplam = 0;
        }

        public static int ToplamveKaresi(out int karesi, int a, int b)
        {
            int toplam = a + b;
            karesi = toplam * toplam;
            return toplam;
        }

        public static void MaasHesapla(out double maas, out double sigorta, double saatlikUcret, double saat)
        {
            maas = saatlikUcret * saat;
            sigorta = maas * 1.20;
        }

        #endregion

        

    }
}
