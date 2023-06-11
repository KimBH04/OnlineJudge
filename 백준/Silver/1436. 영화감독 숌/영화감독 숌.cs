using System;

namespace _1436
{
    class Program
    {
        static void Main(string[] args)
        {
            using var sr = new System.IO.StreamReader(Console.OpenStandardInput());
            using var sw = new System.IO.StreamWriter(Console.OpenStandardOutput());

            var N = int.Parse(sr.ReadLine());

            var ts = 666;
            var i = 1;
            while (N != i)
            {
                ts++;
                if (ts.ToString().Split("666").Length > 1)
                {
                    i++;
                }
            }
            sw.WriteLine(ts);
        }
    }
}
