int q = int.Parse(Console.ReadLine()!);
while (q-- > 0)
{
    string[] inputs = Console.ReadLine()!.Split();
    int ta = int.Parse(inputs[0]), tb = int.Parse(inputs[1]),
        va = int.Parse(inputs[2]), vb = int.Parse(inputs[3]);

    int t = int.MaxValue;
    for (int i = 0; i <= va; i++)
    {
        int a = ta * (va - i);
        int b = tb * vb + ta * i;
        int c = a > b ? a : b;
        t = c < t ? c : t;
    }
    Console.WriteLine(t);
}
