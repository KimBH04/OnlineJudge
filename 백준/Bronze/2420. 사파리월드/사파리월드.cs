using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        Console.WriteLine(Math.Abs(input[0] - input[1]));
    }
}
