int n = int.Parse(Console.ReadLine()!);
string[] input = Console.ReadLine()!.Split();
double[] logs = new double[n];
logs[0] = Math.Log2(double.Parse(input[0]));
ulong cnt = 0;
for (int i = 1; i < n; i++)
{
    double log = Math.Log2(double.Parse(input[i]));
    if (logs[i - 1] > log)
    {
        double ceil = Math.Ceiling(logs[i - 1] - log);
        cnt += (ulong)ceil;
        log += ceil;
    }
    logs[i] = log;
}
Console.WriteLine(cnt);