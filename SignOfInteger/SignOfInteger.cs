namespace SignOfInteger
{
    using System;

    public class Methods
    {
        public static void SignOfNumber(int number)
        {
            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
        }
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            SignOfNumber(number);
        }

    }
}
