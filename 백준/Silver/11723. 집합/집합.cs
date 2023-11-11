using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

int m = int.Parse(sr.ReadLine()!);
bool[] s = Enumerable.Repeat(false, 21).ToArray();
while (m-- > 0)
{
    string[] command = sr.ReadLine()!.Split();
    int x = 0;
    if (command.Length > 1)
    {
        x = int.Parse(command[1]);
    }

    switch (command[0])
    {
        case "add":
            s[x] = true;
            break;

        case "remove":
            s[x] = false;
            break;

        case "check":
            sw.WriteLine(s[x] ? 1 : 0);
            break;

        case "toggle":
            s[x] = !s[x];
            break;

        case "all":
            s = Enumerable.Repeat(true, 21).ToArray();
            break;

        case "empty":
            s = Enumerable.Repeat(false, 21).ToArray();
            break;

        default:
            break;
    }
}
