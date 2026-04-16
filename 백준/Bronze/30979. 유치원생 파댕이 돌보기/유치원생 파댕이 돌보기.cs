int t = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);

string[] inputs = Console.ReadLine()!.Split();
int s = 0;
foreach (string input in inputs)
{
    s += int.Parse(input);
}

Console.WriteLine("Padaeng_i " + (t > s ? "Cry" : "Happy"));