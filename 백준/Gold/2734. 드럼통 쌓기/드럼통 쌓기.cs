using static System.Math;

int t = int.Parse(Console.ReadLine()!);
while (t-- > 0)
{
    string[] input = Console.ReadLine()!.Split();
    int n = int.Parse(input[0]);

    Circle[] circles = new Circle[n];
    for (int i = 0; i < n; i++)
    {
        circles[i] = new(double.Parse(input[i + 1]), 1);
    }

    while (n-- > 1)
    {
        Circle[] onCircles = new Circle[n];
        for (int i = 0; i < n; i++)
        {
            onCircles[i] = Circle.BetweenOn(circles[i], circles[i + 1]);
        }
        circles = onCircles.ToArray();
    }

    Console.WriteLine($"{circles[0].X:0.0000} {circles[0].Y:0.0000}");
}

public readonly struct Circle
{
    private readonly double x;
    private readonly double y;

    public Circle(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double X => x;
    public double Y => y;

    public static Circle BetweenOn(Circle a, Circle b)
    {
        double x1 = a.X;
        double y1 = a.Y;
        double x2 = b.X;
        double y2 = b.Y;

        double radian = Atan2(y2 - y1, x2 - x1);

        double halfx = (x1 + x2) / 2;
        double halfy = (y1 + y2) / 2;

        double halfDisx = halfx - x1;
        double halfDisy = halfy - y1;

        double halfDis = halfDisx * halfDisx + halfDisy * halfDisy;

        double resultDis = Sqrt(4 - halfDis);

        double resultx = Sin(radian) * resultDis;
        double resulty = Cos(radian) * resultDis;

        return new Circle(halfx - resultx, halfy + resulty);
    }
}