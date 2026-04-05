var n = int.Parse(Console.ReadLine()!);

var voted = Console.ReadLine()!.Split();
int chan = 0, ban = 0, gi = 0;

foreach (var v in voted)
{
    switch (v)
    {
        case "1":
            chan++;
            break;

        case "-1":
            ban++;
            break;

        case "0":
            gi++;
            break;

        default:
            break;
    }
}

if (gi > (n - 1) / 2)
{
    Console.WriteLine("INVALID");
}
else if (chan > ban)
{
    Console.WriteLine("APPROVED");
}
else
{
    Console.WriteLine("REJECTED");
}