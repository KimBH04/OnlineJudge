using static System.Console;

int n = int.Parse(ReadLine()!);
string[] names = new string[n];
while (n-- > 0)
{
    names[n] = ReadLine()!;
}

foreach (string name in names)
{
    WriteLine("? " + name);
    string answer = ReadLine()!;
    WriteLine("? " + name);
    if (ReadLine()! != answer)
    {
        WriteLine("! " + name);
        break;
    }
}
