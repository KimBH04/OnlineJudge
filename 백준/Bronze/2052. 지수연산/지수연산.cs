using System.Numerics;

int n = int.Parse(Console.ReadLine()!);
BigInteger b = 1;
for (int i = 0; i < n; i++)
{
    b *= 2;
}

BigInteger a = 1;
Console.Write(a / b);

if (a % b != 0)
{
    Console.Write('.');
    a %= b;

    while (a % b != 0)
    {
        a *= 10;
        Console.Write(a / b);
        a %= b;
    }
}
