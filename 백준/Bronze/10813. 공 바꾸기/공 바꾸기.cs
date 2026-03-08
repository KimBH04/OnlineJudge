using System;

namespace Prob10813
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] box = new int[int.Parse(input[0])];
            int times = int.Parse(input[1]);

            for (int i = 0; i < box.Length; i++)
                box[i] = i + 1;

            for (int i = 0; i < times; i++)
            {
                input = Console.ReadLine().Split();
                int exch1 = int.Parse(input[0]) - 1;
                int exch2 = int.Parse(input[1]) - 1;

                int temp = box[exch1];
                box[exch1] = box[exch2];
                box[exch2] = temp;
            }

            for (int i = 0; i < box.Length; i++)
                Console.Write(box[i] + " ");
        }
    }
}
