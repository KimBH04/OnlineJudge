using System;

namespace Prob25238
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            float difper = float.Parse(num[0]);
            float difnot = float.Parse(num[1]);

            if (difper / 100 * (100 - difnot) >= 100)
                Console.WriteLine(0);
            else
                Console.WriteLine(1);
        }
    }
}
