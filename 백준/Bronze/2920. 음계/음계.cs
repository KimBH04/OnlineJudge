using System;

namespace _2920
{
    class Program
    {
        static void Main(string[] args)
        {
            var musicalScales = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 0; i < 7; i++)
            {
                if (Math.Abs(musicalScales[i] - musicalScales[i + 1]) != 1)
                {
                    Console.WriteLine("mixed");
                    return;
                }
            }

            if (musicalScales[0] == 1)
            {
                Console.WriteLine("ascending");
            }
            else
            {
                Console.WriteLine("descending");
            }
        }
    }
}
