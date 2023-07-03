int n = int.Parse(Console.ReadLine()!), a = 1, b = 1;
for (int i = 0; i < n; i++)
{
    int t = b;
    b = (a * 2 + b) % 10007;
    a = t;
}

Console.WriteLine(a);
