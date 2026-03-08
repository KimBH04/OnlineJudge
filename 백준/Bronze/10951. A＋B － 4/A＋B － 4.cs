using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {   
            for (int i = 0; ; i++)
            {
                string b = Console.ReadLine();

                if (b == null)
                    break;

                string[] c = b.Split();
                int A = int.Parse(c[0]);
                int B = int.Parse(c[1]);

                Console.WriteLine(A + B);   
            }
        }
    }
}
