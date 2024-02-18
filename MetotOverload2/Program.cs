namespace MetotOverload2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //r verirsem dairenin alanı, leng ve width dikdörtgen alanı, side1,side2,side3 verirsem üçgen alanını yaz


            Console.WriteLine( Alan(15));
            Console.WriteLine( Alan(15,20));
            Console.WriteLine( Alan(15,20,25));


        }
        /// <summary>
        /// Alan Hesaplama
        /// </summary>
        /// <param name="side1">r</param>
        /// <returns>Dairenin Alanı</returns>
        private static double Alan(double side1)
        {
            return side1 * side1 * 3.14;
        }
        /// <summary>
        /// Alan Hesaplama
        /// </summary>
        /// <param name="side1">Dikdörtgen kenar1</param>
        /// <param name="side2">Dikdörtgen kenar2</param>
        /// <returns>Dikdörtgen Alanı</returns>
        private static double Alan(double side1, double side2)
        {
            return side1*side2;
        }
        /// <summary>
        /// Alan Hesaplama
        /// </summary>
        /// <param name="side1">Üçgen Kenar1</param>
        /// <param name="side2">Üçgen Kenar2</param>
        /// <param name="side3">Üçgen Kenar3</param>
        /// <returns></returns>
        private static double Alan(double side1, double side2, double side3)
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s* (s-side1) * (s-side2) * (s-side3));
        }


    }
}
