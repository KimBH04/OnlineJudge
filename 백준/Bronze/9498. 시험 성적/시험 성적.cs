using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string[] B = A.Split();

            double a = double.Parse(B[0]);

            if(a > 89)
            {
                Console.WriteLine("A");
            }
            else if (a > 79)
            {
                Console.WriteLine("B");
            }
            else if (a > 69)
            {
                Console.WriteLine("C");
            }
            else if (a > 59)
            {
                Console.WriteLine("D");
            }
            else if (a <= 59)
            {
                Console.WriteLine("F");
            }
        }
    }
}
