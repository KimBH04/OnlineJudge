int n = int.Parse(Console.ReadLine()!);
string s = Console.ReadLine()!;

int[] alphabets = new int[26];
for (int i = 0; i < n; i++)
{
    int ascii = s[i] - 'a';
    if (ascii > -1)
    {
        alphabets[ascii]++;
    }
}

Console.WriteLine(alphabets.Max());