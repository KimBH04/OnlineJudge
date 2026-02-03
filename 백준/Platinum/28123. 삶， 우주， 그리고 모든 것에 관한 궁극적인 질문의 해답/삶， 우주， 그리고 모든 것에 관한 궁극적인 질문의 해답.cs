string[] input = Console.ReadLine()!.Split();
long n = long.Parse(input[0]), k = long.Parse(input[1]), x = long.Parse(input[2]);
long r = 0;

while (x > 1)
{
    if (x == 4)
        r++;
    x >>= 1;
    n--;
}

r += n - 3 * (k - 1);
Console.WriteLine(r);