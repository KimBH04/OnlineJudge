int t = int.Parse(Console.ReadLine()!);
while (t --> 0)
{
    string[] input = Console.ReadLine()!.Split();
    int from = int.Parse(input[0]),
        to = int.Parse(input[1]);

    input = Console.ReadLine()!.Split();
    double a = double.Parse(input[0]),
        b = double.Parse(input[1]),
        c = double.Parse(input[2]);

    if (from == 1)
    {
        double r = Math.Sqrt(a * a + b * b);
        double pi = Math.Atan2(b, a);
        if (pi < 0)
        {
            pi += Math.PI * 2;
        }

        if (to == 2)
        {
            double z = c;
            Console.WriteLine($"{r} {pi} {z}");
        }
        else    // to == 3
        {
            double rho = Math.Sqrt(a * a + b * b + c * c);
            double ceta = Math.Atan2(r, c);
            Console.WriteLine($"{rho} {ceta} {pi}");
        }
    }
    else if (from == 2)
    {
        if (to == 1)
        {
            double x = Math.Cos(b) * a;
            double y = Math.Sin(b) * a;
            double z = c;
            Console.WriteLine($"{x} {y} {z}");
        }
        else    // to == 3
        {
            double rho = Math.Sqrt(a * a + c * c);
            double ceta = Math.Atan2(a, c);
            double pi = b;
            Console.WriteLine($"{rho} {ceta} {pi}");
        }
    }
    else    // to == 3
    {
        double z = Math.Cos(b) * a;
        double r = Math.Sqrt(a * a - z * z);
        if (to == 1)
        {
            double x = Math.Cos(c) * r;
            double y = Math.Sin(c) * r;
            Console.WriteLine($"{x} {y} {z}");
        }
        else    // to == 2
        {
            double pi = c;
            Console.WriteLine($"{r} {pi} {z}");
        }
    }
}
