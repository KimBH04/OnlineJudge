string[] input = Console.ReadLine()!.Split();
int a = int.Parse(input[0]), b = int.Parse(input[1]);

input = Console.ReadLine()!.Split();
int k = int.Parse(input[0]), x = int.Parse(input[1]);

int min = Math.Max(k - x, a), max = Math.Min(k + x, b);
if (min > b || max < a)
{
    Console.WriteLine("IMPOSSIBLE");
}
else
{
    Console.WriteLine(max - min + 1);
}
