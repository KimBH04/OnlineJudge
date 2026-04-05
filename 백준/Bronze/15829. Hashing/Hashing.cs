using System;
using System.Numerics;

class Program
{
    const int M = 1234567891;

    static void Main(string[] args)
    {
        var times = int.Parse(Console.ReadLine());
        var chrArr = Console.ReadLine().ToCharArray();
        var len = chrArr.Length;
        var result = (BigInteger)0;

        for (int i = 0; i < len; i++)
        {
            result += (chrArr[i] - 96) * Pow(i);
        }

        Console.WriteLine(result % M);
    }

    static BigInteger Pow(int i)
    {
        BigInteger value = 1;
        for (int j = 0; j < i; j++)
        {
            value *= 31;
        }

        return value;
    }
}
