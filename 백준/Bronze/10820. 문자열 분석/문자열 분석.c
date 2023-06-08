#include <stdio.h>
#include <string.h>

int main()
{
    char str[100];
    while (gets(str) != NULL)
    {
        int low, up, num, space;
        low = up = num = space = 0;
        int len = strlen(str);

        for (int i = 0; i < len; i++)
        {
            if (str[i] < 48)
            {
                space++;
            }
            else if (str[i] < 65)
            {
                num++;
            }
            else if (str[i] < 97)
            {
                up++;
            }
            else
            {
                low++;
            }          
        }

        printf("%d %d %d %d\n", low, up, num, space);
    }
    return 0;
}