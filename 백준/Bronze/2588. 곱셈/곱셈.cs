using System;

namespace Prob2588
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int a = int.Parse(num);

            num = Console.ReadLine();

            int Z = int.Parse(num);

            int x = Z % 10;
            int y = (Z % 100 - x) / 10;
            int z = (Z - x - y) / 100;

            Console.Write(
                a * x + "\n" + a * y + "\n" + a * z + "\n" + a * Z);
        }
    }
}
