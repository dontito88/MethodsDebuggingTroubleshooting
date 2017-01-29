namespace MultiplyEvenByOdds
{
    using System;

    public class MultiplyEvenByOdds
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultiplyOfEvenByOdds(input));
        }

        public static int GetMultiplyOfEvenByOdds(int number)
        {
            return Math.Abs(GetSumOfEvenDigits(number) * GetSumOfOddDigits(number));
        }


        private static int GetSumOfOddDigits(int number)
        {
            return GetSumOfDigits(number, 1);
        }


        private static int GetSumOfEvenDigits(int number)
        {
            return GetSumOfDigits(number, 0);
        }

        private static int GetSumOfDigits(int number, int remainder)
        {
            var result = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == remainder)
                {
                    result += digit;
                }
            }
            return result;
        }
    }
}
