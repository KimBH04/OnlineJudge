int n = int.Parse(Console.ReadLine()!);
string[] input = Console.ReadLine()!.Split();
int x = int.Parse(input[0]), y = int.Parse(input[1]), r = int.Parse(input[2]);

int left = x - r, right = x + r;
int a, b;
a = b = 0;
while (n-- > 0)
{
    int t = int.Parse(Console.ReadLine()!);
    if (t > left && t < right)
    {
        a++;
    }
    else if (t == left || t == right)
    {
        b++;
    }
}

Console.WriteLine($"{a} {b}");