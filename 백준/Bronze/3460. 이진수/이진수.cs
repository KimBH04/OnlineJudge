using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1292
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                int input = int.Parse(Console.ReadLine());
                char[] binary = Convert.ToString(input, 2).ToCharArray();
                Array.Reverse(binary);
                for (int j = 0; j < binary.Length; j++)
                    if (binary[j] == '1')
                        sb.Append(j + " ");
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}
