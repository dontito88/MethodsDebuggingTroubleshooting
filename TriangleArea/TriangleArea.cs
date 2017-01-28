namespace TriangleArea
{
    using System;

    public class TriangleArea
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            double area = AreaCalc(a, b);
            Console.WriteLine(area);

        }
        private static double AreaCalc(double a, double b)
        {
            return a * b / 2;
        }
    }
}
