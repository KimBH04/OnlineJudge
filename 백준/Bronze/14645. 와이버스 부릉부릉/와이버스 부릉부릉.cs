string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]),
    m = int.Parse(input[1]);

while (n-- > 0)
{
    input = Console.ReadLine()!.Split();
    m += int.Parse(input[0]);
    m -= int.Parse(input[1]);
}

Console.WriteLine("비와이");