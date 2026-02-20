#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n, k, cnt = 0;
    scanf("%d%d", &n, &k);
    char *check = (char*)malloc(sizeof(char) * n);
    scanf("%s", check);

    for (int i = 0; i < n; i++)
    {
        if (check[i] == '1')
        {
            cnt = 0;
        }
        else
        {
            cnt++;
        }

        if (cnt == k)
        {
            printf("0");
            return 0;
        }
    }
    printf("1");

    free(check);
    return 0;
}