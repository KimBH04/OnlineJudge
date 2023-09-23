using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int nums = 99;
            char[] hansu = num.ToString().ToCharArray();

            if (hansu.Length < 3)
                Console.WriteLine(num);
            else if ( hansu.Length >= 3)
            {
                for (int i = 111; i <= num; i++)
                {
                    hansu = i.ToString().ToCharArray();

                    if (hansu[0] - hansu[1] == hansu[1] - hansu[2])
                            nums++;
                }

                Console.WriteLine(nums);
            }
        }
    }
}
