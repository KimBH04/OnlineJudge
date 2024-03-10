string[] inputs = Console.ReadLine()!.Split();
double a = double.Parse(inputs[0]), b = double.Parse(inputs[1]), h = double.Parse(inputs[2]);

if (a == b)
{
    Console.WriteLine(-1);
    return;
}

if (a > b)
{
    (a, b) = (b, a);
}

double c = a / b;
double t = h / (1 - c);
double d = h / t;

double r = Math.Sqrt(t * t + b * b);
double s1 = r * r * Math.PI;

double e = r - r * d;
double s2 = e * e * Math.PI;
Console.WriteLine(s1 - s2);