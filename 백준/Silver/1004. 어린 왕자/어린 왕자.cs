using static System.Console;
int t = int.Parse(ReadLine()!);

while (t-- > 0)
{
    int result = 0;
    var input = ReadLine()!.Split();
    int fx = int.Parse(input[0]),
        fy = int.Parse(input[1]),
        ex = int.Parse(input[2]),
        ey = int.Parse(input[3]);

    int n = int.Parse(ReadLine()!);
    
    while (n-- > 0)
    {
        input = ReadLine()!.Split();
        int x = int.Parse(input[0]),
            y = int.Parse(input[1]),
            r = int.Parse(input[2]);

        var circle = new Circle(x, y, r);

        if (circle.EnterExit(fx, fy) != circle.EnterExit(ex, ey))
        {
            result++;
        }
    }

    WriteLine(result);
}

struct Circle
{
    private int x, y, r;

    public Circle(int x, int y, int r)
    {
        this.x = x;
        this.y = y;
        this.r = r;
    }

    public bool EnterExit(int x, int y)
    {
        int xdis = Math.Abs(x - this.x),
            ydis = Math.Abs(y - this.y);

        return xdis * xdis + ydis * ydis > r * r;
    }
}