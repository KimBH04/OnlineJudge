using System;

namespace Prob2480
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string[] B = A.Split();

            int fst = int.Parse(B[0]);
            int snd = int.Parse(B[1]);
            int trd = int.Parse(B[2]);

            int pm = 0;

            if (fst == snd && snd == trd)
            {
                pm = fst * 1000 + 10000;
            }


            else if (fst == snd)
            {
                pm = fst * 100 + 1000;
            }
            else if (snd == trd)
            {
                pm = snd * 100 + 1000;
            }
            else if (trd == fst)
            {
                pm = trd * 100 + 1000;
            }


            else if (fst > snd && fst > trd)
            {
                pm = fst * 100;
            }
            else if (snd > fst && snd > trd)
            {
                pm = snd * 100;
            }
            else if (trd > fst && trd > snd)
            {
                pm = trd * 100;
            }

            Console.WriteLine(pm);
        }
    }
}
