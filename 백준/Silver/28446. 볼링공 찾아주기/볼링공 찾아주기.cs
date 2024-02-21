using StreamWriter sw = new(Console.OpenStandardOutput());

int m = int.Parse(Console.ReadLine()!);
Dictionary<int, int> locker = new();
while (m-- > 0)
{
    string[] input = Console.ReadLine()!.Split();
    if (input[0] == "1")
    {
        locker.Add(int.Parse(input[2]), int.Parse(input[1]));
    }
    else
    {
        sw.WriteLine(locker[int.Parse(input[1])]);
    }
}
