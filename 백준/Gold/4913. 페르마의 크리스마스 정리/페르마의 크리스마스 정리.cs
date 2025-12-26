const int MAX = 1000000;
int[] sum1 = new int[MAX];
int[] sum2 = new int[MAX];
sum2[2] = 1;
for (int i = 2; i < MAX; i++)
{
    if (sum1[i] == 0)
    {
        if ((i - 1) % 4 == 0)
        {
            sum2[i] = 1;
        }

        for (int j = i + i; j < MAX; j += i)
        {
            sum1[j] = -1;
        }
    }
    sum1[i] += sum1[i - 1] + 1;
    sum2[i] += sum2[i - 1];
}

while (true)
{
    string[] inputs = Console.ReadLine()!.Split();
    int l = int.Parse(inputs[0]),
        u = int.Parse(inputs[1]);

    if (l == -1 && u == -1)
    {
        break;
    }

    Console.Write($"{l} {u} ");

    if (u < 2)
    {
        Console.WriteLine("0 0");
        continue;
    }
    if (l < 1)
    {
        l = 1;
    }

    Console.WriteLine($"{sum1[u] - sum1[l - 1]} {sum2[u] - sum2[l - 1]}");
}
