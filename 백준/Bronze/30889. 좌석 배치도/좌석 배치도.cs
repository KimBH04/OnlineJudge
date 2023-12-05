char[,] sits = new char[10, 20];
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 20; j++)
    {
        sits[i, j] = '.';
    }
}

int n = int.Parse(Console.ReadLine()!);
while (n-- > 0)
{
    string sit = Console.ReadLine()!;
    int r = sit[0] - 65;
    int c = int.Parse(sit[1..]) - 1;
    sits[r, c] = 'o';
}

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 20; j++)
    {
        Console.Write(sits[i, j]);
    }
    Console.WriteLine();
}