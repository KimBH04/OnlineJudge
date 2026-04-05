using System;

namespace Prob5585
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 1000 - int.Parse(Console.ReadLine());
            int total = 0;
            total += money / 500;
            money %= 500;
            total += money / 100;
            money %= 100;
            total += money / 50;
            money %= 50;
            total += money / 10;
            money %= 10;
            total += money / 5;
            money %= 5;
            total += money / 1;
            Console.WriteLine(total);
        }
    }
}
