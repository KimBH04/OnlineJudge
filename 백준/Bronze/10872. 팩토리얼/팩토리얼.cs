using System;

namespace Prob10872
{
    class Program
    {

        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(input));
        }
        
        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            
            return n * Factorial(n - 1);
        }
    }
}
