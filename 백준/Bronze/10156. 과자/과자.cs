using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            string Num = Console.ReadLine();
            string[] Num1 = Num.Split();

            int prz = int.Parse(Num1[0]);

            int tN = int.Parse(Num1[1]);

            int mn = int.Parse(Num1[2]);

            int nMn = prz * tN - mn;

            if(nMn < 0)
            {
                nMn = 0;
            }

            Console.WriteLine(nMn);
        }
    }
}
