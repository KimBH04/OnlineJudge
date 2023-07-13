const int MOD = 15746;
int n = int.Parse(Console.ReadLine()!), a = 1, b = 2;
for (int i = 1; i < n; i++)
{
    int c = a;
    a = b;
    b = (b + c) % MOD;
}
Console.WriteLine(a % MOD);