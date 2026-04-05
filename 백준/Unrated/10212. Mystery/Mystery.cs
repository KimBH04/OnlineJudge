using System;

namespace Prob10212
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Random().Next(0, 2) % 2 == 0 ? "Korea" : "Yonsei" );
        }
    }
}