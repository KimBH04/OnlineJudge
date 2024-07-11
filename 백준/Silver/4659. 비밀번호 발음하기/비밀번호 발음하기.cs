while (true)
{
    string pass = Console.ReadLine()!;
    if (pass == "end")
    {
        break;
    }

    bool able = true, hasVowel = false;
    int consonant = 0, vowel = 0, passLen = pass.Length;
    char front = '\0';
    for (int i = 0; i < passLen; i++)
    {
        char c = pass[i];
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        {
            hasVowel = true;
            consonant = 0;
            vowel++;
        }
        else
        {
            vowel = 0;
            consonant++;
        }

        if (consonant >= 3 || vowel >= 3 || front == c && c != 'e' && c != 'o')
        {
            able = false;
            break;
        }

        front = c;
    }

    Console.WriteLine($"<{pass}> is{(able && hasVowel ? " " : " not ")}acceptable.");
}