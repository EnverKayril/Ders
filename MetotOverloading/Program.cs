namespace MetotOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MailGiris();
        }

        /* Mail oluşturma metodu 
        Kullanıcı adı ve domain ismi verip oluşturma -> fatihalkan, bilgeadam > fatihalkan@bilgeadam.com
        Kullanıcı adı verince -> fatihalkan > fatihalkan@bilgeadam.com

        */

        public static void MailGiris()
        {
            string mail;

            Console.Write("Kullanici Adi Giriniz: ");
            string kullaniciadi = Console.ReadLine();

            Console.Write("Domain: ");
            string domain = Console.ReadLine();

            if (domain == "bilgeadam")
            {
                Console.WriteLine("Mailiniz : " + );
            }
            else
            {
                Console.WriteLine("Mailiniz : " + kullaniciadi);
            }
        }



        private static string MailOlusturma(string kullaniciadi, string domain)
        {
            return kullaniciadi + "@" + domain + ".com";
        }

        private static string MailOlusturma(string kullaniciadi)
        {
            return kullaniciadi + "@bilgeadam.com";

        }
    }
}
