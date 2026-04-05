int n = int.Parse(Console.ReadLine()!);
int m = 0;
while (n-- > 0)
{
    m += int.Parse(Console.ReadLine()!.Split()[0]) switch
    {
        136 => 1000,
        142 => 5000,
        148 => 10000,
        154 => 50000,
        _ => throw new Exception()
    };
}

Console.WriteLine(m);