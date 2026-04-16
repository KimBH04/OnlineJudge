using System;
using System.IO;

namespace prob
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            StringWriter Num = new StringWriter();

            for (int i = a; i > 0; i--)
            {
                Num.WriteLine(i);
            }
            Console.Write(Num.ToString());
        }
    }
}