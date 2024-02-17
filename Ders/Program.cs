using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AtamaOperatorleri

           
            // Atama Operatörleri
            short a = 23;
            short b = 24;
            int c = (a+b);
            Console.WriteLine(a);

            #endregion


            #region AritmatikOperatörler
            // Toplama Operatörü
            int a1 = 10;
            int b1 = 5;
            int c1 = a1 + b1;
            Console.WriteLine(c1);

            // Toplama Operatörü
            string ad1 = "Enver";
            string ad2 = "Kayrıl";
            
            string ad3 = ad1 + ad2; //Birleştirme

            int yas = 31;

            Console.WriteLine(ad3 + yas);

            //Çıkarma Operatörü

            int fark = a1 - b1;
            Console.WriteLine("Fark: " + fark);

            //Çarpma Operatörleri
            int carp = a1 * b1;
            Console.WriteLine( "Carpim: {0} ",carp);

            //Bölme Operatörleri
            int Bol = a1 / b1;
            Console.WriteLine($"Bölüm : {Bol} ");

            //Mod Alma
            Console.WriteLine($"Modu: {a1%b1}");

            #endregion

            #region Metinselİfadeler


            //PlacaHolder (Yer Tutucu)
            string name = "Enver Kayrıl";
            Console.WriteLine("Adınız : {0} Yas ; {1} Cinsiyet Erkek", name, 31);

            //
            Console.WriteLine($"Adınız: {name} Yaşınız: {yas} Cinsiyet: Erkek Maaş: {25000*1.18}");

            string yazi = "Adınız : {0} Yas ; {1} Cinsiyet Erkek";

            Console.WriteLine( yazi,name,31 );

            #endregion

            Console.WriteLine("\n***************************************\n");

            #region ArtırmaAzaltma
            //Artırma

            int sayi1 = 20;
            sayi1 = sayi1 + 5;
            Console.WriteLine("Sayi1 : "+ sayi1);

            sayi1 += 5;
            Console.WriteLine("Sayi1 : " + sayi1 );

            sayi1++;
            Console.WriteLine("Sayi1 : {0}", sayi1);

            //Azaltma
            sayi1--;
            Console.WriteLine("Sayi1 :" + sayi1);

            sayi1 -= 5;
            Console.WriteLine($"Sayi1 : {sayi1}");

            sayi1 = sayi1 - 5;
            Console.WriteLine("Sayi :" + sayi1);

            #endregion

            #region OrnekArtırmaAzaltma

            int sayi2 = 10;
            Console.WriteLine(++sayi2);

            int sayi3 = 10;
            Console.WriteLine(sayi3++);
            Console.WriteLine(sayi3);

            #endregion

            #region İlişkiselOperatörler

            /*
            < Küçük
            > Büyük
            <= Küçük Eşit
            >= Büyük Eşit
            == Eşittir
            != Eşit Değildir.
             */

            int sayi7 = 5;
            int sayi8 = 10;

            bool buyukMu = sayi7 > sayi8;

            Console.WriteLine($"{sayi7}>{sayi8} Büyük Mü : {buyukMu}");

            #endregion

            #region KoşulOperatörü

            //VE - &&
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && false);

            //VEYA - ||
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);

            #endregion

            //Dışarıdan alınan iki sayının toplamıyla farkının birbirine bölümünden kalan kaçtır?

            //Console.WriteLine("Lütfen Sayi1 Giriniz : ");
            //int sayi11 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen Sayi2 Giriniz : ");
            //int sayi12 = Convert.ToInt32(Console.ReadLine());

            //int toplam = sayi11 + sayi12;
            //int cikan = sayi11 - sayi12;

            //int bolumdenkalan = toplam % cikan;
            //Console.WriteLine(bolumdenkalan);


            //Dışardıdan girilen iki sayının karelerinin toplamı 

            //Console.WriteLine("Lütfen Sayi1 Giriniz : ");
            //int Sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen Sayi2 Giriniz : ");
            //int Sayi2 = Convert.ToInt32(Console.ReadLine());

            //int sayi1k = Sayi1 * Sayi1;
            //int sayi2k = Sayi2 * Sayi2;
            //Console.WriteLine("Sonuç : " + (sayi1k + sayi2k));

            //Sayi1 *= Sayi1;
            //Sayi2 *= Sayi2;
            //Console.WriteLine(Sayi1+Sayi2);

            // HesapMakinesi dışardan alınan iki sayının toplamını, farkını, çarpımını, bölümünü

            //Console.WriteLine("Lütfen Bir Sayı Giriniz : ");
            //double sayi21 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen Bir Sayı Giriniz : ");
            //double sayi22 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Sayiların Toplamı : {sayi21+ sayi22}");
            //Console.WriteLine($"Sayiların Farkı : {sayi21 - sayi22}");
            //Console.WriteLine($"Sayiların Çarpımı : {sayi21 * sayi22}");
            //Console.WriteLine($"Sayiların Bölümü : {sayi21 / sayi22}");


            //Dışarıdan kullanıcının adını ve soyadını ayrı ayrı olarak alınız ve ad.soyad @hotmail.com
            //şeklinde oluştur

            //Console.WriteLine("İsminizi Giriniz : ");
            //string isim = Console.ReadLine();

            //Console.WriteLine("Soyisminizi Giriniz : ");
            //string soyisim = Console.ReadLine();

            //Console.WriteLine("Mail Adresiniz : " + isim + "." + soyisim + "@hotmail.com");


            //Vize %30'u finalin %70 i alıp ortalamasını bul

            Console.WriteLine("Vize Notunuzu Giriniz : ");
            double vize = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Final Notunuzu Giriniz : ");
            double final = Convert.ToDouble(Console.ReadLine());

            vize = vize * 0.30;
            final = final * 0.70;

            Console.WriteLine("Notunuz : " + (vize + final));


        }
    }
}
