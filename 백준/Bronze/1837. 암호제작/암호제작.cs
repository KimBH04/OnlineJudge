using System.Numerics;

string[] ipnuts = Console.ReadLine()!.Split();
BigInteger p = BigInteger.Parse(ipnuts[0]), k = BigInteger.Parse(ipnuts[1]);
for (BigInteger i = 2; i < k; i++)
{
    if (p % i == 0)
    {
        Console.WriteLine($"BAD {i}");
        return;
    }
}
Console.WriteLine("GOOD");