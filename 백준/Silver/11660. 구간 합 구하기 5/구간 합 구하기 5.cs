class Program
{
#pragma warning disable CS8618
    static int[,] arr;
#pragma warning restore CS8618
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        var input = sr.ReadLine()!.Split();
        int n = int.Parse(input[0]), m = int.Parse(input[1]);
        arr = new int[n + 1, n + 1];

        for (int i = 1; i <= n; i++)
        {
            input = sr.ReadLine()!.Split();
            for (int j = 1; j <= n; j++)
            {
                arr[i, j] = arr[i, j - 1] + int.Parse(input[j - 1]);
            }
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                arr[i, j] += arr[i - 1, j];
            }
        }

        for (int i = 0; i < m; i++)
        {
            input = sr.ReadLine()!.Split();

            int x1 = int.Parse(input[0]), 
                y1 = int.Parse(input[1]), 
                x2 = int.Parse(input[2]), 
                y2 = int.Parse(input[3]);

            sw.WriteLine(arr[x2, y2] - arr[x1 - 1, y2] - arr[x2, y1 - 1] + arr[x1 - 1, y1 - 1]);
        }
    }
}