using System;

namespace Prob2309
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dwarfsTalls = new int[9];
            int tallsSum = 0;

            for (int i = 0; i < 9; i++)
            {
                dwarfsTalls[i] = int.Parse(Console.ReadLine());
                tallsSum += dwarfsTalls[i];
            }
            for (int i = 0; i < 8; i++)
                for (int j = i + 1; j < 9; j++)
                    if (dwarfsTalls[i] + dwarfsTalls[j] == tallsSum - 100)
                    {
                        dwarfsTalls[i] = 0; dwarfsTalls[j] = 0;
                        goto here;
                    }
                here:
            Array.Sort(dwarfsTalls);
            foreach (int a in dwarfsTalls)
                if (a != 0)
                    Console.WriteLine(a);
        }
    }
}
