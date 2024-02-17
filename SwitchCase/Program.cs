namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             SWITCH - CASE
            If-Else mantığıyla çalışan bir kontrol mekanizması. Aradaki fark, if-else büyüklük küçüklük gibi durumları kontrol edebiliyorken, SWITCH-CASE YALNIZCA EŞİTLİK durumlarını kontrol edebilen yapılardır. Kendisine ait bir index mekanizması ile koşulları algılar, sıraya koyar ve otomatik olarak yüzlerce koşulunuz olsa bile her birine bakmadan doğru koşulu bulur. Bu da performansı direkt etkiler.
             */

            #region Ornek1


            //Console.WriteLine("Mevsim: ");
            //string  mevsim = Console.ReadLine();

            //switch (mevsim) 
            //{
            //    case "Kış":
            //        Console.WriteLine("Aralık - Ocak - Şubat");
            //        break;
            //    case "İlkbahar":
            //        Console.WriteLine("Mart - Nisan - Mayıs");
            //        break;
            //    case "Yaz":
            //        Console.WriteLine("Haziran - Temmuz - Ağustos");
            //        break;
            //    case "Sonbahar":
            //        Console.WriteLine("Eylül - Ekim - Kasım");
            //        break;
            //    default:
            //        Console.WriteLine("Böyle bir mevsim yok");
            //        break;
            //}
            #endregion

            #region Ornek2
            //Eğer kullanıcı "admin","Moderatör","yonetici","CEO", "Baskan" değerleri girilirse "Yönetim paneline yönlendiriliyorsunuz.
            // Uye girilirse "Anasayfaya Yonlendiriliyorsunuz"
            //Harici bi durumda ise "Bu sayfaya girme yetkiniz yok."

            //Console.WriteLine("Rol : ");
            //string rol = Console.ReadLine();

            //switch (rol)
            //{
            //    case "admin":
            //    case "moderator":
            //    case "yonetici":
            //    case "ceo":
            //    case "baskan":
            //        Console.WriteLine("Yönetim sayfasına hoşgeldiniz...");
            //        break;

            //    case "uye":
            //        Console.WriteLine("Anasayfaya hoşgeldiniz...");
            //        break; 
            //    default:
            //        Console.WriteLine("Bu siteye girme yetkiniz yok.");
            //        break;
            //}

            #endregion

            #region Ornek3
            //İç içe switch koyarak kullanıcı adını ve şifresini kontrol edeniz.  Eğer kullanıcı adı ve şifre doğru ise "Tebrikler hem kullanıcı adı hem de şifre doğru."
            //Kullanıcı adı doğru şifre yanlış ise

            //string userName = "bilgeadam";
            //string pass = "1234";
            string userName, pass;

            Console.Write("Kullanıcı Adı Giriniz : ");
            userName = Console.ReadLine();
            Console.Write("Şifrenizi Giriniz : ");
            pass = Console.ReadLine();

            switch (userName)
            {
                case "bilgeadam":

                    switch (pass)
                    {
                        case "1234":
                            Console.WriteLine("Tebrikler giriş yaptınız");
                            break;
                        default:
                            Console.WriteLine("Kullanici adi doğru şifre yanlış");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Kullanıcı adınız yanlış");
                    break;

            }



            #endregion
        }
    }
}
