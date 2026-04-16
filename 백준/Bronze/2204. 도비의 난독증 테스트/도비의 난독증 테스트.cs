using var sr = new StreamReader(Console.OpenStandardInput());
using var sw = new StreamWriter(Console.OpenStandardOutput());

while (true)
{
    var n = int.Parse(sr.ReadLine());
    if (n == 0)
    {
        break;
    }
    var str = new string[n];

    for (int i = 0; i < n; i++)
    {
        str[i] = sr.ReadLine();
    }

    sw.WriteLine(str.OrderBy(x => x.ToLower()).ToArray()[0]);
}