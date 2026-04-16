using System;
using System.Collections.Generic;

namespace Prob1362
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ls = new List<string>();
            while (true)
            {
                bool live = true;
                string[] input = Console.ReadLine().Split();
                if (input[0] == "0" && input[1] == "0")
                    break;
                double properly = double.Parse(input[0]), current = double.Parse(input[1]);
                while (true)
                {
                    input = Console.ReadLine().Split();
                    switch (input[0])
                    {
                        case "F":
                            current += double.Parse(input[1]);
                            break;
                        case "E":
                            current -= double.Parse(input[1]);
                            break;
                        case "#":
                            goto here;
                    }
                    if (current <= 0)
                        live = false;
                }
            here: 
                if (live == false)
                    ls.Add("RIP");
                else if (current < properly * 2 && current > properly / 2)
                    ls.Add(":-)");
                else
                    ls.Add(":-(");
            }
            for (int i = 1; i <= ls.Count; i++)
                Console.WriteLine("{0} {1}", i, ls[i - 1]);
        }
    }
}
