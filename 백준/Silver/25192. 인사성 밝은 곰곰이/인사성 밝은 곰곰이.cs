using System;

namespace _25191
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            var users = new System.Collections.Generic.Dictionary<string, bool>();
            var enter = "ENTER";

            var times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                var name = Console.ReadLine();

                if (name == enter)
                {
                    users.Clear();
                }
                else if (!users.ContainsKey(name))
                {
                    users.Add(name, true);
                    result++;
                }
                else if (!users[name])
                {
                    users[name] = true;
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
