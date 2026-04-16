using System;

namespace prob2902
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lastNames = Console.ReadLine().ToCharArray();
            Console.Write(lastNames[0]);
            for (int i = 1; i < lastNames.Length; i++)
                if (lastNames[i - 1] == '-')
                    Console.Write(lastNames[i]);
        }
    }
}
