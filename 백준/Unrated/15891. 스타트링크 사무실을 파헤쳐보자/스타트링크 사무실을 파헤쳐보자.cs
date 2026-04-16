Func<int>[] actions =
{
    () => 65,
    () => 17,
    () => 4,
    () => 4,
    () => 64
};

int n = int.Parse(Console.ReadLine()!) - 1;
Console.WriteLine(actions[n]());