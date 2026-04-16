int n = int.Parse(Console.ReadLine()!);
using StreamWriter sw = new(Console.OpenStandardOutput());
AtMark(sw, n, 5);
AtMark(sw, n, 1);
AtMark(sw, n, 5);
AtMark(sw, n, 1);
AtMark(sw, n, 1);

static void AtMark(StreamWriter sw, int n, int count)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n * count; j++)
        {
            sw.Write('@');
        }
        sw.WriteLine();
    }
}
