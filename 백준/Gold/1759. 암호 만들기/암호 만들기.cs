string[] lc = Console.ReadLine()!.Split();
int l = int.Parse(lc[0]), c = int.Parse(lc[1]);

string[] inputs = Console.ReadLine()!.Split();
char[] chars = new char[c];
for (int i = 0; i < c; i++)
{
    chars[i] = char.Parse(inputs[i]);
}
Array.Sort(chars);

using StreamWriter sw = new(Console.OpenStandardOutput());
Code(sw, chars, string.Empty, 0, c, 0, l);

static void Code(StreamWriter sw, char[] arr, string code, int start, int n, int m, int depth)
{
    if (m == depth && IsPossible(code))
    {
        sw.WriteLine(code);
    }
    else
    {
        for (int i = start; i < n; i++)
        {
            Code(sw, arr, code + arr[i], i + 1, n, m + 1, depth);
        }
    }
}

static bool IsPossible(string code)
{
    int l = code.Length;
    
    foreach (char vowel in "aeiou")
    {
        foreach (char c in code)
        {
            if (c == vowel)
            {
                l--;
                break;
            }
        }
    }

    return l > 1 && l < code.Length;
}
