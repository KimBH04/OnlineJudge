using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        var _0 = (BigInteger)0; var _1 = (BigInteger)1;
        var N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            var temp = _0;
            _0 = _1;
            _1 = _0 + temp;
        }

        Console.WriteLine(_0);
    }
}
