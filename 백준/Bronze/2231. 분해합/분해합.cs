using System;

namespace Cpppp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bunhaehap = int.Parse(Console.ReadLine());

            for (int i = 1; ; i++)
            {
                var sengseongja = i.ToString().ToCharArray();
                var sum = 0;

                foreach (var item in sengseongja)
                {
                    sum += int.Parse(item.ToString());
                }
                sum += i;

                if (sum == bunhaehap)
                {
                    Console.WriteLine(i);
                    break;
                }
                else if (i > bunhaehap)
                {
                    Console.WriteLine("0");
                    break;
                }
            }
        }
    }
}
