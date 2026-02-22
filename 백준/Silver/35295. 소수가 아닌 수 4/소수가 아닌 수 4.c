#include <stdio.h>

int main()
{
    int n, a[1000];
    scanf("%d", &n);
    for (int i = 0; i < n; i++)
    {
        scanf("%d", a + i);
    }

    if (n > 2)
    {
        printf("YES\n%d\n", n);
        for (int i = 0; i < n; i++)
        {
            printf("%d ", a[i]);
        }
        return 0;
    }
    
    if (a[0] > a[1])
    {
        int temp = a[0];
        a[0] = a[1];
        a[1] = temp;
    }

    if (a[0] == 1)
    {
        for (int i = 2; i * i <= a[1]; i++)
        {
            if (a[1] % i == 0)
            {
                goto is_not_prime;
            }
        }

        printf("NO");
        return 0;
    }

is_not_prime:
    printf("YES\n%d\n%d %d", n, a[0], a[1]);

    return 0;
}