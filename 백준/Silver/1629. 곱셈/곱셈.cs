var input = Console.ReadLine()!.Split();
long a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]);

long result = 1;
while (b > 0)
{
    if (b % 2 == 1)
    {
        result = (result * a) % c;
    }
    a = (a * a) % c;
    b /= 2;
}

Console.WriteLine(result);