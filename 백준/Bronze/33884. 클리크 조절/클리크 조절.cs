int n = int.Parse(Console.ReadLine()!);
(int, int)[][] tang = new (int, int)[2][];
for (int i = 0; i < 2; i++)
{
    tang[i] = new (int, int)[n];
    for (int j = 0; j < n; j++)
    {
        string[] input = Console.ReadLine()!.Split();
        tang[i][j] = (int.Parse(input[0]), int.Parse(input[1]));
    }
    Array.Sort(tang[i]);
}

Console.WriteLine($"{tang[1][0].Item1 - tang[0][0].Item1} {tang[1][0].Item2 - tang[0][0].Item2}");