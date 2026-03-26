#include <stdio.h>

int main()
{
    int sum = 0;
    char s[21] = { 0 };
    scanf("%s", s);
    for (int i = 0; s[i] != 0; i++)
    {
        if (s[i] > 90)
            sum += s[i] - 96;
        else
            sum += s[i] - 38;
    }
    for (int i = 2; i * i <= sum; i++)
    {
        if (sum % i == 0)
        {
            printf("It is not a prime word.");
            return 0;
        }
    }
    printf("It is a prime word.");
    return 0;
}