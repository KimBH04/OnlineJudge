using System;

namespace Prob10886
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            int b = 0;

            for(int i = 0; i < a; i++)
            {
                b += int.Parse(Console.ReadLine());
            }

            if (b > a / 2)
                Console.WriteLine("Junhee is cute!");
            else
                Console.WriteLine("Junhee is not cute!");
        }
    }
}
