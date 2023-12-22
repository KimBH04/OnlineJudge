int t = int.Parse(Console.ReadLine()!);
while (t-- > 0)
{
    string[] inputs = Console.ReadLine()!.Split();
    int r = int.Parse(inputs[0]), c = int.Parse(inputs[1]);

    if (r < 12 || c < 4)
    {
        Console.WriteLine(-1);
    }
    else
    {
        Console.WriteLine(c * 11 + 4);
    }
}
