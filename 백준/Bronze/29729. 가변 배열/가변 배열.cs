string[] input = Console.ReadLine()!.Split();
int s = int.Parse(input[0]), n = int.Parse(input[1]) + int.Parse(input[2]);
int u = 0;

while (n-- > 0)
{
    if (Console.ReadLine()! == "1")
    {
        u++;
        if (u > s)
        {
            s *= 2;
        }
    }
    else
    {
        u--;
    }
}

Console.WriteLine(s);