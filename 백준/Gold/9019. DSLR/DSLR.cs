const int M = 10000;

(Func<int, int>, char)[] commands = {
    (n => n * 2 % M, 'D'),
    (n => (n + M - 1) % M, 'S'),
    (n => (n * 10 + n / 1000) % M, 'L'),
    (n => n / 10 + n % 10 * 1000, 'R') };

int t = int.Parse(Console.ReadLine()!);
using StreamWriter sw = new(Console.OpenStandardOutput());
while (t-- > 0)
{
    string[] inputs = Console.ReadLine()!.Split();
    int a = int.Parse(inputs[0]),
        b = int.Parse(inputs[1]);

    var map = new (int, char)[10000];
    map[a] = (-1, 'A');
    Queue<int> queue = new();
    queue.Enqueue(a);
    while (queue.Count > 0)
    {
        int x = queue.Dequeue();
        if (x == b)
        {
            break;
        }
        foreach (var (f, name) in commands)
        {
            int y = f(x);
            if (map[y].Item2 != '\0')
            {
                continue;
            }

            map[y] = (x, name);
            queue.Enqueue(y);
        }
    }

    System.Text.StringBuilder sb = new();
    while (b != a)
    {
        sb.Append(map[b].Item2);
        b = map[b].Item1;
    }

    foreach (char c in sb.ToString().Reverse())
    {
        sw.Write(c);
    }
    sw.WriteLine();
}