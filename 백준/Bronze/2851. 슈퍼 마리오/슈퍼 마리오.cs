using System;
using System.Linq;

namespace _2851
{
    class Program
    {
        static void Main(string[] args)
        {
            var mushrooms = new int[10];
            var result = 0;

            for (int i = 0; i < 10; i++)
            {
                mushrooms[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                //mushroom의 0부터 i까지의 값
                var temp = mushrooms[..(i + 1)].Sum();

                if (Math.Abs(100 - temp) <= Math.Abs(100 - result))
                {
                    result = temp;
                }
            }

            Console.WriteLine(result);
        }
    }
}
