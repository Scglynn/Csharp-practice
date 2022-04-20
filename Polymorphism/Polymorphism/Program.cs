using System;

namespace poly
{
    class Helper
    {
        //use of overloading
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }
    }

    class mc
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Helper.Multiply(2, 4));
            Console.WriteLine(Helper.Multiply(5.5, 6.3));

        }
    }
}