using System;

class Program
{
    static void Main(string[] args)
    {
        var multi = 0;
        var n = int.Parse(Console.ReadLine());
        if (n < 0) { Console.WriteLine("32"); return; }

        for (; Math.Pow(2, multi) <= n; multi++) { }

        if (multi == 0) multi = 1;
        Console.WriteLine(multi);
    }
}
