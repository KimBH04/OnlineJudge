using System;
using System.Collections.Generic;

namespace Prob2960
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int end = int.Parse(input[0]);
            int nth = int.Parse(input[1]);
            int[] array = new int[end - 1];
            int space;
            List<int> removedNums = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 2;
                //Console.WriteLine(array[i]);
            }

            for(int i = 0; i < nth; i++)
            {
                space = array[i];
                if (space == int.MaxValue)
                    continue;

                for (int j = 0; j < array.Length; j++)
                    if (array[j] % space == 0)
                    {
                        removedNums.Add(array[j]);
                        array[j] = int.MaxValue;
                    }
            }

            Console.WriteLine(removedNums[nth - 1]);
        }
    }
}
