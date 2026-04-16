using System;
using System.Text;

namespace Prob1259
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string a = "", b = "";
                char[] nums = Console.ReadLine().ToCharArray();
                if (nums[0] == '0')
                    break;
                foreach (char item in nums)
                    a += item;
                Array.Reverse(nums);
                foreach (char item in nums)
                    b += item;
                if (a == b)
                    sb.AppendLine("yes");
                else
                    sb.AppendLine("no");
            }
            Console.Write(sb);
        }
    }
}
