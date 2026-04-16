using System;

namespace _25191
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            var chickeHouse = int.Parse(Console.ReadLine());
            var nomimono = Console.ReadLine().Split();
            var cola = int.Parse(nomimono[0]);
            var beer = int.Parse(nomimono[1]);

            for (var i = 0; i < chickeHouse; i++)
            {
                if (cola >= 2)
                {
                    cola -= 2;
                }
                else if (beer >= 1)
                {
                    beer--;
                }
                else
                {
                    continue;
                }

                result++;
            }

            Console.WriteLine(result);
        }
    }
}
