int n = int.Parse(Console.ReadLine()!);
int W = 0, C = 0;

while (n-- > 0)
{
    string[] input = Console.ReadLine()!.Split();
    if (input[0] == "A")
    {
        int w = int.Parse(input[1]), h = int.Parse(input[2]), l = int.Parse(input[3]);
        int c = w / 12 * (h / 12) * (l / 12);
        W += c * 500 + 1000;
        C += c * 4000;
    }
    else
    {
        W += 6000;
    }
}

Console.WriteLine(W);
Console.WriteLine(C);