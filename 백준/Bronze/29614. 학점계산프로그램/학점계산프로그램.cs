string score = Console.ReadLine()!;
double sum = 0;
int count = 0;

int scoreLen = score.Length;
for (int i = 0; i < scoreLen; i++, count++)
{
    switch (score[i])
    {
        case 'A':
            sum += 4;
            break;

        case 'B':
            sum += 3;
            break;

        case 'C':
            sum += 2;
            break;

        case 'D':
            sum += 1;
            break;

        default:
            break;
    }

    if (i + 1 < scoreLen)
    {
        if (score[i + 1] == '+')
        {
            sum += .5;
            i++;
        }
    }
}

Console.WriteLine(sum / count);
