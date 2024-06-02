#include <stdio.h>
#define F(x, i) (x >> i & 1)

int main() {
    int t, a, b, c, d;
    scanf("%d", &t);
    while (t-- > 0) {
        scanf("%d%d%d%d", &a, &b, &c, &d);
        for (int i = 0; i < 3; i++) {
            int sum = F(a, i) + F(b, i) + F(c, i) + F(d, i);
            if (sum == 4 || sum == 0) {
                printf("YES\n");
                goto yes;
            }
        }
        printf("NO\n");
    yes:
    }
    return 0;
}