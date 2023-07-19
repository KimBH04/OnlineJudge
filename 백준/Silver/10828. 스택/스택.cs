using System;
using System.IO;
using System.Collections.Generic;

namespace Prob10828
{
    class Program
    {
        static List<int> stack = new List<int>();

        static void Main(string[] args)
        {
            using var sr = new StreamReader(Console.OpenStandardInput());
            using var sw = new StreamWriter(Console.OpenStandardOutput());
            var times = int.Parse(sr.ReadLine());
            
            for (int i = 0; i < times; i++)
            {
                var command = sr.ReadLine().Split();

                switch (command[0])
                {
                    case "push":
                        Push(int.Parse(command[1]));
                        break;

                    case "pop":
                        Pop(sw);
                        break;

                    case "size":
                        Size(sw);
                        break;

                    case "empty":
                        Empty(sw);
                        break;

                    case "top":
                        Top(sw);
                        break;

                    default:
                        break;
                }
            }
        }

        static void Push(int x)
        {
            stack.Add(x);
        }

        static void Pop(StreamWriter sw)
        {
            if (stack.Count > 0)
            {
                sw.WriteLine(stack[^1]);
                stack.RemoveAt(stack.Count - 1);
            }
            else sw.WriteLine(-1);
        }

        static void Size(StreamWriter sw)
        {
            sw.WriteLine(stack.Count);
        }

        static void Empty(StreamWriter sw)
        {
            if (stack.Count == 0) sw.WriteLine(1);
            else sw.WriteLine(0);
        }

        static void Top(StreamWriter sw)
        {
            if (stack.Count > 0) sw.WriteLine(stack[^1]);
            else sw.WriteLine(-1);
        }
    }
}