int n = int.Parse(Console.ReadLine()!);

string a = Console.ReadLine()!;
string b = Console.ReadLine()!;

Console.WriteLine("Deletion " + (Deletion(a, b, n, a.Length) ? "succeeded" : "failed"));

static bool Deletion(string a, string b, int n, int l)
{
    if (n % 2 == 0)
    {
        for (int i = 0; i < l; i++)
        {
            if (a[i] != b[i])
            {
                return false;
            }
        }
    }
    else
    {
        for (int i = 0; i < l; i++)
        {
            if (a[i] == b[i])
            {
                return false;
            }

        }
    }

    return true;
}
