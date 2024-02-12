string[] inputs = Console.ReadLine()!.Split();
int d1 = int.Parse(inputs[0]),
    d2 = int.Parse(inputs[1]),
    x = int.Parse(inputs[2]);

if (d1 < d2)
{
    (d1, d2) = (d2, d1);
}

double p = d1 * 100d / x - d1;
double m = p / d2;

Console.WriteLine((p + d1) / (m + 1));