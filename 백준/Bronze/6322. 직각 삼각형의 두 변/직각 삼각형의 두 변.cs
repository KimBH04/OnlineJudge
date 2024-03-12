for (int i = 1; ; i++)
{
    string[] inputs = Console.ReadLine()!.Split();
    int a = int.Parse(inputs[0]), b = int.Parse(inputs[1]), c = int.Parse(inputs[2]);
    if (a == 0 && b == 0 && c == 0)
    {
        break;
    }

    Console.WriteLine($"Triangle #{i}");
    if (c == -1)
    {
        Console.WriteLine($"c = {Math.Sqrt(a * a + b * b):0.000}\n");
    }
    else if (a == -1)
    {
        if (b >= c)
        {
            Console.WriteLine("Impossible.\n");
        }
        else
        {
            Console.WriteLine($"a = {Math.Sqrt(c * c - b * b):0.000}\n");
        }
    }
    else
    {
        if (a >= c)
        {
            Console.WriteLine("Impossible.\n");
        }
        else
        {
            Console.WriteLine($"b = {Math.Sqrt(c * c - a * a):0.000}\n");
        }
    }
}