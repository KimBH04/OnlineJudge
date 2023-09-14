string[] input = Console.ReadLine()!.Split(':', ' ');
int sh = int.Parse(input[0]), sm = int.Parse(input[1]),
    eh = int.Parse(input[2]), em = int.Parse(input[3]);

TimeOnly start = new(sh, sm);
TimeOnly now = new(sh, sm);
TimeOnly end = new(eh, em);

input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]) + 1, t = int.Parse(input[1]);

int d = 0;
while (n > 0)
{
    while (now.AddMinutes(t) < end)
    {
        now = now.AddMinutes(t);
        n--;

        if (n < 1)
        {
            break;
        }
    }
    if (n < 1)
    {
        break;
    }
    d++;
    now = start;
}

Console.WriteLine(d);
Console.WriteLine($"{now.Hour:00}:{now.Minute:00}");