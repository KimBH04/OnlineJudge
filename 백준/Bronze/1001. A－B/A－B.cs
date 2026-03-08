using System;

namespace Prob1000
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrInput = input.Split();

            int A = int.Parse(arrInput[0]);

            int B = int.Parse(arrInput[1]);

            Console.WriteLine(A - B);
        }
    }
}
