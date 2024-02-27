string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), x = int.Parse(inputs[1]), k = int.Parse(inputs[2]);

bool[] cups = new bool[n];
cups[x - 1] = true;
while (k-- > 0)
{
    string[] inputs2 = Console.ReadLine()!.Split();
    int a = int.Parse(inputs2[0]), b = int.Parse(inputs2[1]);
    (cups[a - 1], cups[b - 1]) = (cups[b - 1], cups[a - 1]);
}

for (int i = 0; i < n; i++)
{
    if (cups[i])
    {
        Console.WriteLine(i + 1);
        break;
    }
}
