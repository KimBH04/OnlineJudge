using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

int[] time = Enumerable.Repeat(0, 1000002).ToArray();
string[] input;

int n = int.Parse(sr.ReadLine()!);
while (n-- > 0)
{
    input = sr.ReadLine()!.Split();
    int s = int.Parse(input[0]),
        e = int.Parse(input[1]);

    time[s]++;
    time[e + 1]--;
}

for (int i = 1; i < 1000002; i++)
{
    time[i] += time[i - 1];
}

int q = int.Parse(sr.ReadLine()!);
input  = sr.ReadLine()!.Split();

for (int i = 0; i < q; i++)
{
    sw.WriteLine(time[int.Parse(input[i])]);
}
