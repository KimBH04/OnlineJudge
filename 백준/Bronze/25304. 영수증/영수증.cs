using System;

namespace prob25304
{
    class Program
    {
        static void Main(string[] args)
        {
            int receipt = int.Parse(Console.ReadLine());
            int things = int.Parse(Console.ReadLine());
            for (int i = 0; i < things; i++)
            {
                string[] input = Console.ReadLine().Split();
                receipt -= int.Parse(input[0]) * int.Parse(input[1]); 
            }
            if (receipt == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
