using System;
using System.Collections.Generic;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            List<int> so = new List<int>();

            for (int i = 0; i < A; i++)
            { 
                string num = Console.ReadLine();
                string[] add = num.Split();

                if (int.Parse(add[0]) == 0 && int.Parse(add[1]) == 0)
                {

                    for (i = 0; i < so.Count; i++)
                    {
                        Console.WriteLine(so[i]);
                    }

                    A--;
                }

                so.Add(int.Parse(add[0]) + int.Parse(add[1]));

                A++;
            }
        }
    }
}
