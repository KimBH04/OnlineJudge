using System;

class Program
{
    static void Main(string[] args)
    {
        var result = 0;
        var dance = new System.Collections.Generic.Dictionary<string, bool>();
        var times = int.Parse(Console.ReadLine());

        for (int i = 0; i < times; i++)
        {
            var input = Console.ReadLine().Split();

            if (!dance.ContainsKey(input[0])) 
            {
                dance.Add(input[0], false); 
            }
            if (!dance.ContainsKey(input[1]))
            {
                dance.Add(input[1], false);
            }

            if (input[0] == "ChongChong" || input[1] == "ChongChong")
            {
                dance["ChongChong"] = true;
            }

            if (dance[input[0]])
                dance[input[1]] = dance[input[0]];
            else if (dance[input[1]])
                dance[input[0]] = dance[input[1]];
        }

        foreach (var item in dance)
        {
            if (item.Value)
            {
                result++;
            }
        }

        Console.WriteLine(result);
    }
}
