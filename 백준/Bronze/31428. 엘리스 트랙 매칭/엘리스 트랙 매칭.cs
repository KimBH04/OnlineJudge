int n = int.Parse(Console.ReadLine()!);
string[] inputs = Console.ReadLine()!.Split();
string input = Console.ReadLine()!;

int r = 0;
for (int i = 0; i < n; i++)
{
    if (inputs[i] == input)
    {
        r++;
    }
}

Console.WriteLine(r);