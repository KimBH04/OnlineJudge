using System;

namespace Prob10872
{
    class Program
    {
        static void Main(string[] args)
        {
            int pac = 1;
            int num = int.Parse(Console.ReadLine());

            if (num != 0)
                for (int i = 1; i <= num; i++)
                    pac *= i;

            Console.Write(pac);
        }
    }
}
