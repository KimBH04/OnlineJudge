using System;

namespace Prob1076
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 0;
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "brown":
                        if (i == 0) a += 10;
                        else if (i == 1) a += 1;
                        else a *= 10;
                        break;
                    case "red":
                        if (i == 0) a += 20;
                        else if (i == 1) a += 2;
                        else a *= 100;
                        break;
                    case "orange":
                        if (i == 0) a += 30;
                        else if (i == 1) a += 3;
                        else a *= 1000;
                        break;
                    case "yellow":
                        if (i == 0) a += 40;
                        else if (i == 1) a += 4;
                        else a *= 10000;
                        break;
                    case "green":
                        if (i == 0) a += 50;
                        else if (i == 1) a += 5;
                        else a *= 100000;
                        break;
                    case "blue":
                        if (i == 0) a += 60;
                        else if (i == 1) a += 6;
                        else a *= 1000000;
                        break;
                    case "violet":
                        if (i == 0) a += 70;
                        else if (i == 1) a += 7;
                        else a *= 10000000;
                        break;
                    case "grey":
                        if (i == 0) a += 80;
                        else if (i == 1) a += 8;
                        else a *= 100000000;
                        break;
                    case "white":
                        if (i == 0) a += 90;
                        else if (i == 1) a += 9;
                        else a *= 1000000000;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(a);
        }
    }
}
