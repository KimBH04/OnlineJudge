class Program
{
    static int a, b, k;
    static readonly int[] memo = new int[3188647];
    static readonly int[] visited = new int[3188647];

    static void Main()
    {
        string[] input = Console.ReadLine()!.Split();
        a = int.Parse(input[0]);
        b = int.Parse(input[1]);
        k = int.Parse(input[2]);

        long r = 0;

        for (int i = a; i <= b; i++)
        {
            Init(i);
        }

        for (int i = a; i <= b; i++)
        {
            r += Min(i);
        }

        Console.WriteLine(r);
    }

    static void Init(int i)
    {
        if (memo[i] != 0)
            return;

        Init(memo[i] = S(i));
    }

    static int Min(int i)
    {
        if (visited[i] >= 2)
            return Math.Min(i, memo[i]);

        visited[i]++;
        return memo[i] = Math.Min(i, Min(memo[i]));
    }

    static int S(int n)
    {
        int r = 0;
        while (n > 0)
        {
            r += (int)Math.Pow(n % 10, k);
            n /= 10;
        }
        return r;
    }
}