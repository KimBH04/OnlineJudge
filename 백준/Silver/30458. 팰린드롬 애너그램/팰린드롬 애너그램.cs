int n = int.Parse(Console.ReadLine()!);
string s = Console.ReadLine()!;
int half = n / 2;

int[] alphabets = new int[26];
for (int i = 0; i < half; i++)
{
    alphabets[s[i] - 'a']++;
    alphabets[s[^(i + 1)] - 'a']++;
}

foreach (int c in alphabets)
{
    if (c % 2 == 1)
    {
        Console.WriteLine("No");
        return;
    }
}
Console.WriteLine("Yes");