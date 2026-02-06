int n = int.Parse(Console.ReadLine()!.Split()[0]);

int[] elementCnts = new int[char.MaxValue];
while (n-- > 0)
{
    string line = Console.ReadLine()!;
    foreach (var c in line)
    {
        elementCnts[c]++;
    }
}

if (elementCnts['S'] != 1 || elementCnts['E'] != 1)
{
    Console.WriteLine(-1);
}
else if (elementCnts['A'] > 0)
{
    Console.WriteLine(4);
}
else if (elementCnts['V'] > 0)
{
    Console.WriteLine(3);
}
else if (elementCnts['U'] + elementCnts['D'] + elementCnts['L'] + elementCnts['R'] > 1 || elementCnts['#'] > 1)
{
    Console.WriteLine(2);
}
else
{
    Console.WriteLine(1);
}