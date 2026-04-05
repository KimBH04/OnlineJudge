int n = int.Parse(Console.ReadLine()!), i = 0;
var s = Console.ReadLine()!;

bool oneTime = new();
while (i++ < n)
{
    oneTime = false;
    string a = s[..i], b = s[^i..];
    for (int j = 0; j < i; j++)
    {
        if (a[j] != b[j])
        {
            if (oneTime)
            {
                oneTime = false;
                break;
            }
            else
            {
                oneTime = true;
            }
        }
    }

    if (oneTime)
        break;
}

Console.WriteLine(oneTime ? "YES" : "NO");