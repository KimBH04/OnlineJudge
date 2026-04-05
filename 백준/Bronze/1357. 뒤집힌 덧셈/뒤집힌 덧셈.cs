using System;

namespace Prob1357
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = "";
            int[] a = new int[2];
            string[] input = Console.ReadLine().Split();
            for(int i = 0; i < 2; i++)
            {
                string tempf = "";
                char[] nums = input[i].ToCharArray();
                Array.Reverse(nums);
                foreach (var item2 in nums)
                    tempf += item2;
                a[i] = int.Parse(tempf);
            }
            char[] acc = (a[0] + a[1]).ToString().ToCharArray();
            Array.Reverse(acc);
            foreach (var item in acc)
                temp += item;
            int output = int.Parse(temp);
            Console.WriteLine(output);
        }
    }
}
