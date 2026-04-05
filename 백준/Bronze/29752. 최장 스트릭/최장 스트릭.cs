int n = int.Parse(Console.ReadLine()!);

string[] input = Console.ReadLine()!.Split();
int l = 0, c = 0;
for (int i = 0; i < n; i++)
{
    int s = int.Parse(input[i]);
    if (s > 0)
    {
        c++;
    }
    else
    {
        c = 0;
    }
    l = c > l ? c : l;
}
Console.WriteLine(l);