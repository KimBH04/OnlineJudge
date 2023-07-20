using static System.Console;

string[] input = ReadLine()!.Split();
int n = int.Parse(input[0]),
    m = int.Parse(input[1]);

Dictionary<int, bool> a = new();
List<int> b = new();
input = ReadLine()!.Split();

for (int i = 0; i < n; i++)
{
    a.Add(int.Parse(input[i]), false);
}

input = ReadLine()!.Split();
for (int i = 0; i < m; i++)
{
    int x = int.Parse(input[i]);
    if (a.ContainsKey(x))
    {
        a.Remove(x);
    }
    else
    {
        b.Add(x);
    }
}

WriteLine(a.Count + b.Count);