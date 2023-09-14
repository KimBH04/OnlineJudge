string[] input = Console.ReadLine()!.Split('-');
int y = int.Parse(input[0]), m = int.Parse(input[1]), d = int.Parse(input[2]);

int n = int.Parse(Console.ReadLine()!);
d += n;

while (d > 30)
{
    d -= 30;
    m++;
}

while (m > 12)
{
    m -= 12;
    y++;
}

Console.WriteLine($"{y:0000}-{m:00}-{d:00}");