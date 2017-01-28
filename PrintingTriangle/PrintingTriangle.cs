namespace BlankReceipt
{
    using System;

    public class Methods
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            PrintTriangleTop(n);
            PrintTriangleBottom(n);
        }
        public static void PrintTriangleTop(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleBottom(int n)
        {
            for (int row = n - 1; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();

            }
        }
    }
}
