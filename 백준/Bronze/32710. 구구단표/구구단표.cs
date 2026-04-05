int n = int.Parse(Console.ReadLine()!);
for (int a = 2; a < 10; a++)
{
    for (int b = 1; b < 10; b++)
    {
        int c = a * b;
        if (a == n || b == n || c == n)
        {
            Console.WriteLine(1);
            return;
        }
    }
}

Console.WriteLine(0);
return;