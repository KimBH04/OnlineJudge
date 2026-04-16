int n = int.Parse(Console.ReadLine()!), r = 6;

for (int i = 11; i <= n; i++)
{
    r *= i;
}

Console.WriteLine(r);