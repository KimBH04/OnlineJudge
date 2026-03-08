using System;
using System.Collections.Generic;

namespace Prob1158
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            string[] input = Console.ReadLine().Split();
            int times = int.Parse(input[0]), nth = int.Parse(input[1]), n = 0;
            int[] arr = new int[times];

            for (int i = 1; i <= times; i++)
                list.Add(i);

            for (int i = 0; i < times; i++)
            {
                for (int j = 0; j < nth; j++)
                {
                    n++;
                    if (n > list.Count)
                        n = 1;
                }

                arr[i] = list[n - 1];
                list.Remove(list[n - 1]);
                n--;
            }

            Console.Write("<");
            for (int i = 0; i < arr.Length - 1; i++)
                Console.Write(arr[i] + ", ");
            Console.Write(arr[arr.Length - 1] + ">");
        }
    }
}
