int n = int.Parse(Console.ReadLine()!);
while (n-- > 0)
{
    string[] input = Console.ReadLine()!.Split();
    int a = int.Parse(input[0]), b = int.Parse(input[1]), x = int.Parse(input[2]);
    Console.WriteLine(a * (x - 1) + b);
}
