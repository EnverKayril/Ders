using System.ComponentModel;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<> içerisine(<T>) verilen tipe bürünerek, o tipte bir koleksiyon oluşturmamıza olanak sağlayan dizi çeşididir. Diziler gibi boyut arttırma işlemine gerek duymadan eleman ekleyip çıkarabiliriz.
            // Array sınıfını kullanmamıza gerek kalmadan üzerinde işlem yapabildiğimiz gelişmiş bir sınıftır.

            List<string> sehirler = new List<string>() { "İstanbul", "Ankara", "İzmir" };
            sehirler.Add("Rize");
            sehirler.Add("Konya");
            sehirler.Add("Eskişehir");
            sehirler.Add("Bursa");

            Console.WriteLine("**************" + sehirler[3]);

            foreach (string sehir in sehirler) {
                Console.WriteLine(sehir);
            }

            Console.WriteLine("*********");
            sehirler.Sort();
            
            sehirler.ForEach(x => Console.WriteLine(x));

            Console.WriteLine(sehirler.Contains("İzmir") ? "Listede var" : "Listede yok");

            sehirler.Remove("İzmir");

            for (int i = 0; i < sehirler.Count; i++)
            {
                Console.WriteLine(sehirler[i]);
            }




            #region MyRegion

            //List<int> sayilar = new List<int>();



            #endregion

        }
    }
}
