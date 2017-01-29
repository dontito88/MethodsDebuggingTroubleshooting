namespace GreaterOfTwto
{
    using System;

    public class GreaterOfTwto
    {
        public static void Main()
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }
        }

        private static int GetMax(int first, int second)
        {
            var bigger = Math.Max(first, second);
            return bigger;
        }

        private static char GetMax(char first, char second)
        {
            return (char)GetMax((int)first, (int)second);
        }

        private static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) < 0)
            {
                return second;
            }
            else
            {
                return first;
            }
        }
    }
}
