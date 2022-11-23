using System;

namespace AlgoMethodB
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2, 3));

        }

        public static double Substract(double a, double b)
        {
            return a - b;
        }
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static bool even(string even, string odd, string num)
        {
            while (true)
            {
                if (int.Parse(num) % 2 == 0)
                {
                    return even == "Even";
                }
                else
                {
                    return odd == "Odd";
                }
            }
        }
    }
}

