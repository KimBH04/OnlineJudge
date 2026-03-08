using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] so = new string[input];

            for(int i = 0; i < input; i++)
            {
                string rec = Console.ReadLine();
                string[] rec1 = rec.Split();

                int r = int.Parse(rec1[0]);
                int e = int.Parse(rec1[1]);
                int c = int.Parse(rec1[2]);

                if (r < e - c)
                    so[i] = "advertise";

                else if (r > e - c)
                    so[i] = "do not advertise";

                else
                    so[i] = "does not matter";
            }
            for(int i = 0; i < input; i++)
            {
                Console.WriteLine(so[i]);
            }
        }
    }
}
