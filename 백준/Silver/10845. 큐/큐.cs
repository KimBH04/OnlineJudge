using System;
using System.Text;
using System.Collections.Generic;

namespace Prob10845
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            List<string> L = new List<string>();
            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "push")
                    L.Add(input[1]);
                else if (input[0] == "pop")
                {
                    if (L.Count != 0)
                    {
                        sb.AppendLine(L[0]);
                        L.Remove(L[0]);
                    }
                    else
                        sb.AppendLine("-1");
                }
                else if (input[0] == "size")
                    sb.AppendLine(L.Count.ToString());
                else if (input[0] == "empty")
                    if (L.Count == 0)
                        sb.AppendLine("1");
                    else
                        sb.AppendLine("0");
                else if (input[0] == "front")
                    if (L.Count != 0)
                        sb.AppendLine(L[0]);
                    else
                        sb.AppendLine("-1");
                else if (input[0] == "back")
                    if (L.Count != 0)
                        sb.AppendLine(L[L.Count - 1]);
                    else
                        sb.AppendLine("-1");
            }

            Console.Write(sb);
        }
    }
}
