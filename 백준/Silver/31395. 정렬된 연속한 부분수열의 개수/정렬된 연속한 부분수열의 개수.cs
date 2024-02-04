int n = int.Parse(Console.ReadLine()!);

int f = 0;
long r = 0;
int s = 0;
string[] inputs = Console.ReadLine()!.Split();
foreach (string input in inputs)
{
    int a = int.Parse(input);
    if (f < a)
    {
        r += ++s;
    }
    else
    {
        r += s = 1;
    }
    f = a;
}

Console.WriteLine(r);