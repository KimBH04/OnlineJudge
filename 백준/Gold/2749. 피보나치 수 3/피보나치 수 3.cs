using System;

class Program
{
    static void Main(string[] args)
    {
        var _0 = 0L; var _1 = 1L;
        const long M = 1_000_000L;
        const long P = 1_500_000L;
        var N = long.Parse(Console.ReadLine());

        for (long i = 0; i < N % P; i++)
        {
            var temp = _0 % M;
            _0 = _1 % M;
            _1 = _0 + temp;
        }

        Console.WriteLine(_0);
    }
}
