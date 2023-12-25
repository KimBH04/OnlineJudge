int n = int.Parse(Console.ReadLine()!);
while (n-- > 0)
{
    int consonants = 0, vowels = 0;
    string sentence = Console.ReadLine()!.ToUpper();
    foreach (char c in sentence)
    {
        if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
        {
            vowels++;
        }
        else if (c != ' ')
        {
            consonants++;
        }
    }

    Console.WriteLine($"{consonants} {vowels}");
}
