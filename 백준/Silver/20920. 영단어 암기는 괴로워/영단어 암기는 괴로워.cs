using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

string[] input = sr.ReadLine()!.Split();
int n = int.Parse(input[0]), m = int.Parse(input[1]);

Dictionary<string, int> dic = new();
while (n-- > 0)
{
    string s = sr.ReadLine()!;
    if (s.Length >= m)
    {
        if (dic.ContainsKey(s))
        {
            dic[s]++;
        }
        else
        {
            dic.Add(s, 0);
        }
    }
}

foreach (var k in dic.OrderBy(x => x.Key).OrderBy(x => -x.Key.Length).OrderBy(x => -x.Value).Select(x => x.Key))
{
    sw.WriteLine(k);
}