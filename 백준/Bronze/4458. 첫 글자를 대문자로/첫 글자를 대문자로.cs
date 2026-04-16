using System;

namespace _4458
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var _char = Console.ReadLine().ToCharArray();
                var _string = Array.ConvertAll(_char, a => a.ToString());
                _string[0] = _string[0].ToUpper();

                foreach (var item in _string)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }
    }
}
