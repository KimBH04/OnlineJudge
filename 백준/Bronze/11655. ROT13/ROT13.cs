string a = "NOPQRSTUVWXYZABCDEFGHIJKLM";
string b = "nopqrstuvwxyzabcdefghijklm";

string input = Console.ReadLine()!;

foreach (char c in input)
{
    if (c - 64 > 0 && c - 65 < 27)
    {
        Console.Write(a[c - 65]);
    }
    else if (c - 96 > 0 && c - 97 < 27)
    {
        Console.Write(b[c - 97]);
    }
    else
    {
        Console.Write(c);
    }
}
