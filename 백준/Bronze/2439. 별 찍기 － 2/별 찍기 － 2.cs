using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string d;

        for (int a = 1; a <= N; a++)
        {
            d = "";
            for (int b = N; b > a; b--)
            {
                d += " ";
            }
            for (int c = 1; c <= a; c++)
            {
                d += "*";
            }
            Console.WriteLine(d);
        }

    }
}