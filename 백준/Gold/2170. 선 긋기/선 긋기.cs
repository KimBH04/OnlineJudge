using StreamReader sr = new(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine()!);

var lines = new (int, int)[n];
for (int i = 0; i < n; i++)
{
    string[] inputs = sr.ReadLine()!.Split();
    int x = int.Parse(inputs[0]), y = int.Parse(inputs[1]);
    lines[i] = (x, y);
}
Array.Sort(lines);

int result = 0;
var (left, right) = lines[0];
for (int i = 1; i < n; i++)
{
    var (x, y) = lines[i];
    if (right < x)
    {
        result += Math.Abs(right - left);
        left = x;
        right = y;
    }
    else if (right < y)
    {
        right = y;
    }
}
result += Math.Abs(right - left);

Console.WriteLine(result);