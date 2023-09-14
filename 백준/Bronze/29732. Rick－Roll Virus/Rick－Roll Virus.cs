string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]), m = int.Parse(input[1]), k = int.Parse(input[2]);
char[] s = Console.ReadLine()!.ToCharArray();

for (int i = 0; i < n; i++)
{
    if (s[i] == 'R')
    {
        int a = Math.Min(n, i + k + 1);
        for (int j = Math.Max(0, i - k); j < a; j++)
        {
            if (s[j] == '.')
            {
                s[j] = 'r';
            }
        }
    }
}

int r = 0;
for (int i = 0; i < n; i++)
{
    if (s[i] == 'R' || s[i] == 'r')
    {
        r++;
    }
}

Console.WriteLine(r > m ? "No" : "Yes");