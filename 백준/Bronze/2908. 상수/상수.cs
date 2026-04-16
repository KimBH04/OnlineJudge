using System;

namespace Prob2908
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] twosu = Console.ReadLine().Split();
            char[] susep1 = twosu[0].ToCharArray();
            char[] susep2 = twosu[1].ToCharArray();

            Array.Reverse(susep1);
            Array.Reverse(susep2);

            int comp1 = int.Parse(string.Concat(susep1));
            int comp2 = int.Parse(string.Concat(susep2));

            if (comp2 < comp1)
                Console.WriteLine(comp1);
            else
                Console.WriteLine(comp2);
        }
    }
}
