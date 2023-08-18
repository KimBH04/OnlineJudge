using System.Numerics;

var fac = new BigInteger[31];
fac[0] = 1;
for (int i = 1; i < 31; i++)
{
    fac[i] = fac[i - 1] * i;
}

var t = int.Parse(Console.ReadLine()!);

while (t-- > 0)
{
    var input = Console.ReadLine()!.Split();
    int n = int.Parse(input[0]), m = int.Parse(input[1]);

    Console.WriteLine(fac[m] / (fac[n] * fac[m - n]));
}
