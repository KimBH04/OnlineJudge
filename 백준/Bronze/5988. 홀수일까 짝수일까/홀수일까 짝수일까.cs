using System.Numerics;

var n = int.Parse(Console.ReadLine()!);

while (n-- > 0)
{
    var k = BigInteger.Parse(Console.ReadLine()!);
    if (k % 2 == 0)
    {
        Console.WriteLine("even");
    }
    else
    {
        Console.WriteLine("odd");
    }
}
