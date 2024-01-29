int v = 0, y = v;
foreach (var i in Console.ReadLine()!)
{
    if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
    {
        v++;
    }
    else if (i == 'y')
    {
        y++;
    }
}
Console.WriteLine($"{v} {y + v}");