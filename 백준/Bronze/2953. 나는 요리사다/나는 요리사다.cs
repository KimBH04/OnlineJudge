using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2953
{
    class Program
    {
        static void Main(string[] args)
        {
            int senshuNum = 0, highScore = int.MinValue;
            int[] scores = new int[5] { 0, 0, 0, 0, 0 };
            for (int i = 0; i < 5; i++)
            {
                string[] input = Console.ReadLine().Split();
                foreach (string item in input)
                    scores[i] += int.Parse(item);
                if (scores[i] > highScore)
                { 
                    highScore = scores[i];
                    senshuNum = i + 1;
                }
            }
            Console.WriteLine("{0} {1}", senshuNum, highScore);
        }
    }
}
