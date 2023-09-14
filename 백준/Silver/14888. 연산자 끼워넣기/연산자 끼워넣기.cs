int n = int.Parse(Console.ReadLine()!);

string[] input = Console.ReadLine()!.Split();
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(input[i]);
}

input = Console.ReadLine()!.Split();
int[] oper = new int[4];
for (int i = 0; i < 4; i++)
{
    oper[i] = int.Parse(input[i]);
}

int min = int.MaxValue, max = int.MinValue;
BackTracking(a[0], 1, n);
Console.WriteLine(max);
Console.WriteLine(min);

void BackTracking(int n, int m, int deep)
{
    if (m == deep)
    {
        min = n < min ? n : min;
        max = n > max ? n : max;
        return;
    }

    for (int i = 0; i < 4; i++)
    {
        if (oper[i] != 0)
        {
            oper[i]--;
            BackTracking(Calculator(n, a[m], i), m + 1, deep);
            oper[i]++;
        }
    }
}

int Calculator(int a, int b, int o)
{
    return o switch
    {
        0 => a + b,
        1 => a - b,
        2 => a * b,
        3 => a / b,
        _ => -1,
    };
}
