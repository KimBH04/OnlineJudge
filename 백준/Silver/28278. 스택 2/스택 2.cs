using StreamWriter sw = new(Console.OpenStandardOutput());

int n = int.Parse(Console.ReadLine()!);
Stack<int> s = new();
while (n-- > 0)
{
    string[] command = Console.ReadLine()!.Split();
    switch (command[0])
    {
        case "1":
            s.Push(int.Parse(command[1]));
            break;

        case "2":
            sw.WriteLine(s.Count > 0 ? s.Pop() : -1);
            break;

        case "3":
            sw.WriteLine(s.Count);
            break;

        case "4":
            sw.WriteLine(s.Count > 0 ? 0 : 1);
            break;

        case "5":
            sw.WriteLine(s.Count > 0 ? s.Peek() : -1);
            break;
    }
}
