using System;

namespace Prob10998
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string[] B = A.Split();

            double a = double.Parse(B[0]);
            double b = double.Parse(B[1]);
            double c = a / b;

            Console.WriteLine("{0:0.000000000}", c);
        }
    }
}
