using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2460
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximum = int.MinValue, now = 0;
            for (int i = 0; i < 10; i++)
            {
                string[] people = Console.ReadLine().Split();
                now += int.Parse(people[1]) - int.Parse(people[0]);
                if (maximum < now)
                    maximum = now;
            }
            Console.WriteLine(maximum);
        }
    }
}
