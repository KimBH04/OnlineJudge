string[] input = Console.ReadLine()!.Split();
int a = int.Parse(input[0]),
    b = int.Parse(input[1]),
    n = int.Parse(input[2]);

while (n-- > 0)
{
    a %= b;
    a *= 10;
}

Console.WriteLine(a / b);