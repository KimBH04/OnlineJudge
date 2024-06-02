string[] inputs = Console.ReadLine()!.Split();
int a = int.Parse(inputs[0]), b = int.Parse(inputs[1]), c = int.Parse(inputs[2]);

var AxBsinxC = (double x) => a * x + b * Math.Sin(x) - c;

double l = 0, r = double.MaxValue;
double n = AxBsinxC(l);
while (r - l > 0.0000000001)
{
    double mid = (l + r) / 2;
    double m = AxBsinxC(mid);
    if (n * m < 0)
    {
        r = mid;
    }
    else
    {
        l = mid;
        n = m;
    }
}
Console.WriteLine($"{(l + r) / 2}");