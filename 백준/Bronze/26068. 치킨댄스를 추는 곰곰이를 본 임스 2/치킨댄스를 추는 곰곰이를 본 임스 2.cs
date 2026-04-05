using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        var result = 0;
        var times = int.Parse(Console.ReadLine());

        for (var i = 0; i < times; i++)
        {
            var restDay = int.Parse(Console.ReadLine().Split('-')[1]);
            if (restDay <= 90)
                result++;
        }

        Console.WriteLine(result);
    }
}
