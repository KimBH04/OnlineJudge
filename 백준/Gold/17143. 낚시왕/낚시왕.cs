string[] input = Console.ReadLine()!.Split();
int r = int.Parse(input[0]),
    c = int.Parse(input[1]),
    m = int.Parse(input[2]);

Shark.Row = r++;
Shark.Col = c++;

Shark[,] sharks = new Shark[c, r];
for (int i = 0; i < m; i++)
{
    input = Console.ReadLine()!.Split();
    int x = int.Parse(input[1]),
        y = int.Parse(input[0]);

    sharks[x, y] = new Shark(
        int.Parse(input[2]),
        int.Parse(input[4]),
        int.Parse(input[3]));
}

int result = 0;
for (int i = 1; i < c; i++)
{
    for (int j = 1; j < r; j++)
    {
        if (sharks[i, j] != null)
        {
            result += sharks[i, j].size;
            sharks[i, j] = null!;
            break;
        }
    }

    Shark[,] temp = new Shark[c, r];
    for (int j = 1; j < c; j++)
    {
        for (int k = 1; k < r; k++)
        {
            sharks[j, k]?.Move(temp, j, k);
        }
    }

    sharks = temp;
}

Console.WriteLine(result);

public class Shark
{
    public static int Row, Col;
    public readonly int speed, size;
    public Direction dir;

    public Shark(int speed, int size, int dir)
    {
        this.speed = speed % (dir > 2 ? Col + Col - 2 : Row + Row - 2);
        this.size = size;
        this.dir = (Direction)dir;
    }

    public void Move(Shark[,] target, int x, int y)
    {
        switch (dir)
        {
            case Direction.UP:
                y -= speed;
                if (y < 1)
                {
                    y = -y + 2;
                    dir = Direction.DOWN;
                    if (y > Row)
                    {
                        y = Row + Row - y;
                        dir = Direction.UP;
                    }
                }
                break;

            case Direction.DOWN:
                y += speed;
                if (y > Row)
                {
                    y = Row + Row - y;
                    dir = Direction.UP;
                    if (y < 1)
                    {
                        y = -y + 2;
                        dir = Direction.DOWN;
                    }
                }
                break;

            case Direction.LEFT:
                x -= speed;
                if (x < 1)
                {
                    x = -x + 2;
                    dir = Direction.RIGHT;
                    if (x > Col)
                    {
                        x = Col + Col - x;
                        dir = Direction.LEFT;
                    }
                }
                break;

            case Direction.RIGHT:
                x += speed;
                if (x > Col)
                {
                    x = Col + Col - x;
                    dir = Direction.LEFT;
                    if (x < 1)
                    {
                        x = -x + 2;
                        dir = Direction.RIGHT;
                    }
                }
                break;
        }

        if (target[x, y] == null || target[x, y]?.size < size)
        {
            target[x, y] = this;
        }
    }
}

public enum Direction
{
    UP = 1,
    DOWN = 2,
    RIGHT = 3,
    LEFT = 4,
}
