using System.Linq.Expressions;
using System.Threading.Channels;
using System.Xml;

namespace StringHazırMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             String ifadeler üzerinde işlemler gerçekleştirebileceğimiz metotlardır. Kelimeleri parçalamak, büyük harf yapmak, yerlerini değiştirmek v.b. gibi
            */

            string ornekMetin;

            #region CompareTo
            //CompareTo => Metodu kullandığımız string değerler metoda verdiğimiz parametredeki string değeri sözlük mantığıyla karşılaştırır. Eğer sözlükte aynı lokasyondaysa 0, önceyse -1 sonra ise 1 döndürür.

            //ornekMetin = Console.ReadLine();
            //int sonuc = ornekMetin.CompareTo("bilgeadam");

            //switch (sonuc)
            //{
            //    case -1:
            //        Console.WriteLine("Kelime diğer kelime ile eşleşmemektedir. Eksik karakter var");
            //        break;
            //    case 0:
            //        Console.WriteLine("Kelime eşleşmektedir.");
            //        break;
            //    case 1:
            //        Console.WriteLine("Kelime diğer kelime ile eşleşmemektedir. Fazla karakter var");
            //        break;
            //        default:
            //        break;
            //}


            #endregion

            #region Contains

            //ornekMetin = Console.ReadLine();

            //bool varMi = ornekMetin.Contains("adam");

            //Console.WriteLine("Aradığınız değer: " + (varMi ? "Bulunmaktadır." : "Bulunmamaktadır."));

            #endregion

            #region StartsWith

            //Kelimenizin parametrede gönderdiğiniz değerle başlayıp başlamadığını size bool olarak döndürür.

            //ornekMetin = Console.ReadLine();
            //ornekMetin.StartsWith("b");
            //Console.WriteLine(ornekMetin.StartsWith("b") ? "Kelime B ile Başlıyor." : "Kelime B ile Başlamıyor");

            #endregion

            #region EndsWith

            //Kelimenizin parametrede gönderdiğiniz değerle bitip bitmediğini size "bool" olarak döndürür.

            //ornekMetin = Console.ReadLine();
            //Console.WriteLine(ornekMetin.EndsWith("dam") ? "Kelime \"dam\" ile bitmektedir" : "Kelime \"dam\" ile bitmemektedir") ;

            #endregion

            #region IndexOf

            //ornekMetin = Console.ReadLine() ;
            //int index = ornekMetin.IndexOf('g');
            //Console.WriteLine(index.ToString());

            #endregion

            #region LastIndexOf

            //ornekMetin = Console.ReadLine();
            //int index = ornekMetin.LastIndexOf('a');
            //Console.WriteLine(index.ToString());

            #endregion

            #region Remove
            //Karakter Silme

            //1. Kullanım : Verdiğiniz index numarası dahil, o indexteki ve sonraki tüm karakterleri ortadan kaldırır.
            //2. Kullanım : Virdiğiniz index numarası dahil, o indexi sonraki indexe kadar kaldırır

            //ornekMetin = Console.ReadLine();
            //String ornek = ornekMetin.Remove(5);

            //ornekMetin = ornekMetin.Remove(3, 2);
            //Console.WriteLine(ornekMetin);

            #endregion

            #region Replace
            //Metniniz içerisindeki bir karakteri ya da bir bölümü yeni bir karakter veya bölüm ile değiştirmenize olanak sağlar.

            //ornekMetin = "BilgeAdam";
            //ornekMetin = ornekMetin.Replace("Adam", "Kadın");
            //Console.WriteLine(ornekMetin);

            #endregion

            #region Split

            //Metninizi özel bir karakterden birden fazla parçaya ayırrmanıza olanak sağlayan metotdur. Aynı anda birden fazla özel karakter verebilirsiniz.

            //string mailAdresleri = Console.ReadLine();
            //string[] adresler = mailAdresleri.Split(';', ',');

            //foreach (string adres in adresler)
            //{
            //    Console.WriteLine(adres);
            //}

            #endregion

            #region Insert

            //Insert => Bir metinsel değerin herhangi bir pozisyonuna (index) yeni bir değeri eklemek istediğiniz zaman kullanabilirsiniz.

            //ornekMetin = Console.ReadLine();
            //ornekMetin = ornekMetin.Insert(5, "cik");
            //Console.WriteLine(ornekMetin);

            #endregion

            #region ToLowerToUpper

            //ornekMetin = Console.ReadLine();
            //Console.WriteLine(ornekMetin.ToUpper());
            //Console.WriteLine(ornekMetin.ToLower());

            #endregion

            #region SubString

            //1. Kullanım: Metninizden parametrede gönderdiğiniz indexten başlayarak geri kalan kısmı çekip almanıza olanak sağlar.

            //ornekMetin = Console.ReadLine();
            //string ornek = ornekMetin.Substring(5);
            //Console.WriteLine(ornek);

            ////2. Kullanım: Metninizden ilk parametrede verdiğiniz indexten başlayıp ikinci parametrede verdiğiniz değer kadarlık kısmı çekip almanızı sağlar.

            //string Metin = ornekMetin.Substring(3, 2);
            //Console.WriteLine(Metin);

            #endregion

            #region ToCharArray

            //Stringinizi charlarına ayırarak size char[] olarak teslim eder.

            //ornekMetin = Console.ReadLine().ToUpper();
            //char[] karakterler = ornekMetin.ToCharArray();

            //for (int i = 0; i < karakterler.Length; i++)
            //{
            //    Console.WriteLine(karakterler[i]);
            //}

            #endregion

            #region Trim

            //Metninizin sağındaki ve solundaki boşlukları temizler.

            //ornekMetin = Console.ReadLine();
            //string deger = ornekMetin.Trim();
            //Console.WriteLine(ornekMetin);

            #endregion

            #region Ornek1

            ////Kullanıcıdan alınan bir cümle içindeki kelime sayısını ve cümlede geçen en uzun kelimenin uzunluğunu bulunuz.

            //Console.WriteLine("Bir cümle giriniz: ");
            //ornekMetin = Console.ReadLine().Trim();

            //string[] kelimeler = ornekMetin.Split(' ');

            #endregion





        }
    }
}
