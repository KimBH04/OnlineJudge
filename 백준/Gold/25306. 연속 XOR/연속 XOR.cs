var input = Console.ReadLine().Split();
long a = long.Parse(input[0]), b = long.Parse(input[1]);

Console.WriteLine(XOR(a - 1) ^ XOR(b));

static long XOR(long n)
{
    switch (n % 4)
    {
        case 0: return n;
        case 1: return 1;
        case 2: return n + 1;
        case 3: return 0;
        default: return -1;
    }
}