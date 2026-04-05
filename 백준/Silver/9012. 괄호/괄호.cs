using System;

namespace _9012
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                var ls = new System.Collections.Generic.List<int>();
                var input = Console.ReadLine().ToCharArray();
                var output = "YES";

                foreach (var item in input)
                {
                    try
                    {
                        if (item == '(')
                            ls.Add(item);
                        else if (ls[^1] != '(')
                            throw new ArgumentOutOfRangeException();
                        else
                            ls.RemoveAt(ls.Count - 1);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        output = "NO";
                        break;
                    }
                }

                if (ls.Count > 0)
                    output = "NO";

                Console.WriteLine(output);
            }
        }
    }
}
