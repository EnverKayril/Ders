using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region TipDonusum

            //Tip Dönüşümleri
            //Bilinçsiz Dönüşüm (Implict Conversion)

            short degisken1 = 31245;
            int degisken2 = degisken1;

            Console.WriteLine("Short Degiskeni {0}, Int Degiskeni {}", degisken1, degisken2);

            //Bilinçli Dönüşüm (Explicit Conversion)

            int degisken3 = 32154;
            short degisken4 = (short)degisken3;

            Console.WriteLine($"Int Degiskeni {degisken3}, Short Degiskeni {degisken4}");

            #endregion

            #region ConvertSınıfı
            //Bir veri tipindeki değişkeni, diğer bir veri tipine çevirmek için ihtiyacımız olan yardımcı bir sınıftır.


            string deger = "123";

            int cevri1 = Convert.ToInt32(deger); //String --> Int
            byte cevri2 = Convert.ToByte(deger); //String --> Byte
            short cevri3 = Convert.ToInt16(deger); // String --> Short
            long cevri4 = Convert.ToInt64(deger); // String --> Long

            float cevri5 = Convert.ToSingle(deger); // String --> Float

            double deger2 = 20.5;
            float cevri6 = Convert.ToSingle(deger2);

            bool sonuc = true;
            Console.WriteLine( sonuc);
            Console.WriteLine( Convert.ToInt32(sonuc));

            char deger4 = 'a';
            int sonuc2 = Convert.ToInt32(deger4);
            Console.WriteLine();
            Console.WriteLine( sonuc2);

            #endregion

            #region ToString()

            int sayi1 = 10;
            int sayi2 = 5;
            int toplam = 10 + 5;

            double ondalik1 = 10.5;
            ondalik1.ToString();

            Console.WriteLine(toplam.ToString());


            #endregion

            #region ParseMetodu

            string yas1 = "36";

            int yas = int.Parse(yas1);
            double yas2 = double.Parse(yas1);

            Console.ReadLine();

            #endregion



        }
    }
}
