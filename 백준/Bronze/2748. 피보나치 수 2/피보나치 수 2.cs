using System;

class Program
{
    static void Main(string[] args)
    {
        var _0 = 0L;
        var _1 = 1L;

        var nth = decimal.Parse(Console.ReadLine());

        for (int i = 0; i < nth; i++)
        {
            var temp = _0;
            _0 = _1;
            _1 = _0 + temp;
        }

        Console.WriteLine(_0);
    }
}
