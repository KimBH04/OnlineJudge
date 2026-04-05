using StreamWriter sw = new(Console.OpenStandardOutput());
int n = int.Parse(Console.ReadLine()!);

while (n-- > 0)
    sw.Write("swimming ");
sw.WriteLine();
sw.Flush();

string[] input = Console.ReadLine()!.Split();
foreach (string s in input)
    if (s == "bowling")
        sw.Write("soccer ");
    else
        sw.Write("bowling ");
sw.WriteLine();