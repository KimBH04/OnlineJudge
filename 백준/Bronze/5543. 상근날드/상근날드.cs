using System;

namespace Prob5543
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] burgers = new int[3], drinks = new int[2];
            for (int i = 0; i < 3; i++)
                burgers[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < 2; i++)
                drinks[i] = int.Parse(Console.ReadLine());
            Array.Sort(burgers); Array.Sort(drinks);
            Console.WriteLine(burgers[0] + drinks[0] - 50);
        }
    }
}
