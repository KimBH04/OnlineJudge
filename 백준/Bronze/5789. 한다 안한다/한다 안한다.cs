using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        var times = int.Parse(Console.ReadLine());

        for (int i = 0; i < times; i++)
        {
            var hanabira = Console.ReadLine().ToCharArray();
            if (hanabira[hanabira.Length / 2] == hanabira[hanabira.Length / 2 - 1])
            {
                Console.WriteLine("Do-it");
            }
            else
            {
                Console.WriteLine("Do-it-Not");
            }
        }
    }
}
