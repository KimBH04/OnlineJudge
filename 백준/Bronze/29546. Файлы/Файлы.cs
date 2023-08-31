using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine()!);
string[] files = new string[n];
for (int i = 0; i < n; i++)
{
    files[i] = sr.ReadLine()!;
}

int m = int.Parse(sr.ReadLine()!);
while (m-- > 0)
{
    string[] input = sr.ReadLine()!.Split();
    int l = int.Parse(input[0]), r = int.Parse(input[1]);

    for (int i = l - 1; i < r; i++)
    {
        sw.WriteLine(files[i]);
    }
}
