using System;

namespace Prob10988
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = "";
            string c = "";
            char[] input = Console.ReadLine().ToCharArray();
            foreach (char a in input)
                b += a;
            Array.Reverse(input);
            foreach (char a in input)
                c += a;
            if (b != c)
                Console.WriteLine(0);
            else
                Console.WriteLine(1);
        }
    }
}
