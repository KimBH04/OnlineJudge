using System;
using System.Text;

namespace Prob11365
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                char[] input = Console.ReadLine().ToCharArray();
                if (input[0] == 'E' && input[1] == 'N' && input[2] == 'D')
                    break;
                Array.Reverse(input);
                foreach (char a in input)
                    sb.Append(a);
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}
