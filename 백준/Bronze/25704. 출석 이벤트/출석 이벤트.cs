int n = int.Parse(Console.ReadLine()!);
int p = int.Parse(Console.ReadLine()!);

int min = p;
if (n >= 5)
{
    int r = p - 500;
    r = 0 > r ? 0 : r;
    min = r < min ? r : min;
}
if (n >= 10)
{
    int r = p - (p / 10);
    min = r < min ? r : min;
}
if (n >= 15)
{
    int r = p - 2000;
    r = 0 > r ? 0 : r;
    min = r < min ? r : min;
}
if (n >= 20)
{
    int r = p - (p / 4);
    min = r < min ? r : min;
}

Console.WriteLine(min);