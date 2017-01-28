namespace MathPower
{
   using System;

   public class MathPower
    {
        public static void Main()
        {
            var baseNumber = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(baseNumber, power));
        }
        private static double RaiseToPower(double baseNumber, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= baseNumber;
            }
            return result;
        }
    }
}
