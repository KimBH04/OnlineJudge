int r = 0;
string input = Console.ReadLine()!;
if (input.Contains('7'))
{
    r += 2;
}
if (int.Parse(input) % 7 == 0)
{
    r++;
}
Console.WriteLine(r);