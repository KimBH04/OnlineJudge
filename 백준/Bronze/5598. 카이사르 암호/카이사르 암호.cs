using System;

namespace _5598
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = "XYZABCDEFGHIJKLMNOPQRSTUVW".ToCharArray();
            var a = Console.ReadLine().ToCharArray();
            foreach (var i in a) Console.Write(d[i - 65]);
        }
    }
}
