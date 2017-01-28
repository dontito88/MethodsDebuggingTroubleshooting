namespace FilledSquare
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            PrintTopAndBotton(n);
            PrintMiddle(n);
            PrintTopAndBotton(n);
        }
        public static void PrintTopAndBotton(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
        public static void PrintMiddle(int n)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write('-');
                for (int j = 1; j <= n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}
