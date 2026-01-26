string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]),
    m = int.Parse(inputs[1]);

using var sw = new StreamWriter(Console.OpenStandardOutput());
for (int i = 0; i < n; i++)
{
    sw.WriteLine(string.Join(' ', Enumerable.Range(i * m + 1, m)));
}