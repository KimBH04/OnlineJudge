using System;

namespace week2007
{
    class Program
    {
        static void Main(string[] args)
        {
            var week = new string[7] 
            { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
            var lastDay = new int[12] 
            { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            //1   2   3   4   5   6   7   8   9   10  11  12
            var result = 1;
            
            var date = Console.ReadLine().Split();

            var month = int.Parse(date[0]);
            var day = int.Parse(date[1]);

            for (int mon = 1; mon <= month; mon++)
            {
                for (int d = 1; d <= lastDay[mon - 1]; d++, result++)
                {
                    if (mon == month && d == day)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(week[result % 7]);
        }
    }
}
