using System;
using System.Linq;

namespace _1620
{
    class Program
    {
        static void Main(string[] args)
        {
            using var sw = new System.IO.StringWriter();
            var pokemons1 = new System.Collections.Generic.Dictionary<int, string>();
            var pokemons2 = new System.Collections.Generic.Dictionary<string, int>();

            var input = Console.ReadLine().Split();
            var times = int.Parse(input[0]);
            var munje = int.Parse(input[1]);

            for (int i = 1; i <= times; i++)
            {
                var pokemon = Console.ReadLine();
                pokemons1.Add(i, pokemon);
                pokemons2.Add(pokemon, i);
            }

            for (int i = 0; i < munje; i++)
            {
                var question = Console.ReadLine();
                try { sw.WriteLine(pokemons1[int.Parse(question)]); }
                catch (FormatException) { sw.WriteLine(pokemons2[question]); }
            }

            Console.Write(sw);
        }
    }
}
