using System.ComponentModel.Design;
using System.Threading.Channels;
using System.Transactions;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SORTING ALGORITHMS

            #region Diziler1

            //string[] names = { "Enver", "Fatih", "Yasin" };
            //Console.WriteLine(names[0]);

            //int[] sayilar1 = { 1, 2, 3, 4, 5};


            //int[] sayilar2 = new int[5];
            //sayilar2[0] = 56;
            //sayilar2[1] = 34;
            //sayilar2[2] = 16;
            //sayilar2[3] = 76;
            //sayilar2[4] = 22;


            //int t = 5;

            //int[] sayilar3 = new int[t];

            //Console.WriteLine(sayilar3.Length);

            //reference type - value type - stack - heap


            #endregion

            #region Diziler2

            //string[] sehirler = new string[5] { "İstanbul", "Ankara", "İzmir", "Adana", "Eskişehir" };
            ////Console.WriteLine(sehirler[1]);
            //sehirler[1] = "Samsun";
            ////Console.WriteLine(sehirler[1]);

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    //Console.WriteLine(sehirler[1]);
            //}

            //foreach (var sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}

            #endregion

            #region Diziler3

            //Sınav Not Programı

            string[] students = {"Fatih", "Yasin", "Enver", "Harun", "Murat", "Gamze" };
            double[] exam1 = new double[students.Length];
            double[] exam2 = new double[students.Length];

            Console.WriteLine("Sınav Not Giriş Sistemi");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Ogrenci Adı {students[i]} ");
                Console.Write("\tVize Notu : ");
                exam1[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("\tFinal Notu : ");
                exam2[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Sisteme Not Giriş İşlemi Tamamlandı. Yazdırmak ister misin? [E][H]");
            if (Console.ReadLine().ToUpper() == "E")
            {
                
                for (int i = 0; i < students.Length; i++)
                {
                    double sonuc = (exam1[i] * 0.3) + (exam2[i] * 0.7);
                    if (sonuc >= 70)
                    {
                       Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine(
                        $"Öğrenci Adı: {students[i]} " +
                        $"Vize Notu: {exam1[i]} " +
                        $"Final Notu: {exam2[i]} " +
                        $"Sonuç: {sonuc}") ;
                }
            }
            else
            {
                Console.WriteLine("Program bitti.");
            }


            #endregion







        }
    }
}