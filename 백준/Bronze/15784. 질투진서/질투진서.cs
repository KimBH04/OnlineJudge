string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]),
    a = int.Parse(input[1]) - 1,
    b = int.Parse(input[2]) - 1;

int[,] x = new int[n, n];
for (int i = 0; i < n; i++)
{
    input = Console.ReadLine()!.Split();
    for (int j = 0; j < n; j++)
    {
        x[i, j] = int.Parse(input[j]);
    }
}

for (int m = 0; m < n; m++)
{
    if (x[a, m] > x[a, b] || x[m, b] > x[a, b])
    {
        Console.WriteLine("ANGRY");
        return;
    }
}

Console.WriteLine("HAPPY");