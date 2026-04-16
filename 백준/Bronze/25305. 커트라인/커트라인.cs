using System;

namespace Prob25305
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int people = int.Parse(input[0]);
            int cutLinScoresRank = int.Parse(input[1]);
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(scores);
            Array.Reverse(scores);
            Console.WriteLine(scores[cutLinScoresRank - 1]);
        }
    }
}
