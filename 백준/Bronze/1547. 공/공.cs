var m = int.Parse(Console.ReadLine()!);
var cup = new bool[4];
cup[1] = true;
cup[2] = cup[3] = false;

while (m-- > 0)
{
    var input = Console.ReadLine()!.Split();
    int x = int.Parse(input[0]), y = int.Parse(input[1]);

    (cup[y], cup[x]) = (cup[x], cup[y]);
}

for (int i = 1; i < 4; i++)
{
    if (cup[i])
    {
        Console.WriteLine(i);
        break;
    }
}
