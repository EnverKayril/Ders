namespace CarpimTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 1;

            for (int i = 1; i <= 10; i++)
            {
                for ( j = 1 ; j <= 10; j++) 

                Console.WriteLine( i + "x"+ j +"="+ (i * j) );

            }
        }
    }
}
