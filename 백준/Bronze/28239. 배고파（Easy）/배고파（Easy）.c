#include <stdio.h>
typedef long long int ll;

int main()
{
    int n;
    scanf("%d", &n);
    while (n--)
    {
        ll m;
        int xy[2] = { -1, -1 };
        scanf("%lld", &m);

        int j = 0;
        for (int i = 0; i < 64; i++)
        {
            if (m % 2)
            {
                xy[j] = i;
                j++;

                if (j == 2)
                {
                    break;
                }
            }
            m >>= 1;
        }

        if (xy[1] == -1)
        {
            xy[0] -= 1;
            xy[1] = xy[0];
        }

        printf("%d %d\n", xy[0], xy[1]);
    }
    return 0;
}