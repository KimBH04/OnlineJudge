using System;

namespace _5086
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                if (input[0] == input[1])
                    return;

                if (input[1] % input[0] == 0)
                    Console.WriteLine("factor");
                else if (input[0] % input[1] == 0)
                    Console.WriteLine("multiple");
                else
                    Console.WriteLine("neither");
            }
        }
    }
}
