int n = int.Parse(Console.ReadLine()!);
while (n-- > 0)
{
    string s = Console.ReadLine()!;
    if (s != "Never gonna give you up" &&
        s != "Never gonna let you down" &&
        s != "Never gonna run around and desert you" &&
        s != "Never gonna make you cry" &&
        s != "Never gonna say goodbye" &&
        s != "Never gonna tell a lie and hurt you" &&
        s != "Never gonna stop")
    {
        Console.WriteLine("Yes");
        return;
    }
}
Console.WriteLine("No");