using System.Diagnostics.SymbolStore;
using System.Threading.Channels;

namespace HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Exception Handling - Hata Yakalama
            
            -Derleme Zamano (Syntax Error/ Compile Exception) : Tamamen yazılımcı kaynaklı hatadır. Kod 
            yazımından kaynaklı hatalar meydana geldiğinde devreye girer. En kolay çözülen hata tipidir.

            -Mantıksal Hatalar (Logical Error) : Tamamen programcı kaynaklı hatalardır.Uygulamanın
            algoritmasında meydana gelir.

            - Çalışma Hatası (Runtime Error) : 

             */


            //try
            //{
            //    // Bu alana hata riski olan kodlar yazılır.
            //    Console.WriteLine("Telefon Numarası Giriniz. ");
            //    int telno = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Telefon numarası doğru ");

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Hatalı telefon numarası");

            //}

            #region TryCatchFinally



            //try
            //{
            //    Console.WriteLine( "Telefon Numarası : ");
            //    int tel = Convert.ToInt32( Console.ReadLine() );
            //    Console.WriteLine("Tebrikler.");
            //}
            //catch (Exception hata) // Go to defination
            //{
            //    Console.WriteLine(hata.Message);
            //}
            //finally {
            //    // Hata olsa da, olmasa da çalışmasını istediğimiz bir kod varsa buraya yazılır.

            //    Console.WriteLine("Hata olsa da olmasa da çalıştı.");

            #endregion


            try
            {
                Console.WriteLine("Telefon Numarası");
                int tel = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex) // Format hata tipi
            {
                Console.WriteLine("Doğru Formatta Giriş Yapmadınız.");
            }
            catch (OverflowException ex) //Boyutla ilgili hatalar.
            {
                Console.WriteLine("Veri tipinin boyutunu aştınız.");
            }
            catch (Exception ex) //Genel hata tipi
            {
                Console.WriteLine("Hata Gerçekleşti.");
            }




        }
    }
}

