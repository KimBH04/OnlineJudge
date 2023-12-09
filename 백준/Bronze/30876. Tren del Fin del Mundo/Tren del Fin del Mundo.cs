int n = int.Parse(Console.ReadLine()!);
int mx = int.MaxValue, my = int.MaxValue;
while (n-- > 0)
{
    string[] inputs = Console.ReadLine()!.Split();
    int x = int.Parse(inputs[0]), y = int.Parse(inputs[1]);
    if (my > y)
    {
        mx = x;
        my = y;
    }
}
Console.WriteLine($"{mx} {my}");