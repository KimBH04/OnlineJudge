using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);

            int c = 0;

            for(int i = 0; i < b; i++)
            {
                c += b - i;
            }

            Console.WriteLine(c);
        }
    }
}
