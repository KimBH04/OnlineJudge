using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine()!);
Dictionary<string, bool> kaisha = new();
while (n-- > 0)
{
    string[] input = sr.ReadLine()!.Split();

    if (kaisha.ContainsKey(input[0]))
    {
        if (input[1] == "leave")
        {
            kaisha.Remove(input[0]);
        }
    }
    else
    {
        if (input[1] == "enter")
        {
            kaisha.Add(input[0], true);
        }
    }
}

foreach (string key in kaisha.Keys.OrderBy(x => x).Reverse())
{
    sw.WriteLine(key);
}
