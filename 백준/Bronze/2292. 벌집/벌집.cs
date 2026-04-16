using System;

namespace _2292
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = int.Parse(Console.ReadLine());
            var multiSix = 1;
            var result = 1;

            for (int i = 1; ; i++)
            {
                if (i == value)
                {
                    Console.WriteLine(result);
                    break;
                }
                if (i == multiSix)
                {
                    multiSix += result++ * 6;
                }
            }
        }
    }
}
