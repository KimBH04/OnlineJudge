using System;

namespace _26004
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new int[5];
            var times = int.Parse(Console.ReadLine());

            var input = Console.ReadLine().ToCharArray();
            var len = input.Length;

            var index = 0;
            foreach (var item in "HIARC")
            {
                var gaesu = 0;
                for (int i = 0; i < len; i++)
                {
                    if (input[i] == item)
                    {
                        gaesu++;
                    }
                }
                result[index++] = gaesu;
            }

            var min = int.MaxValue;
            foreach (var item in result)
            {
                if (min > item)
                    min = item;
            }

            Console.WriteLine(min);
        }
    }
}
