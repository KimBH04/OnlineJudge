#include <stdio.h>

int main() {
    int n, x, s, c, p;
    scanf("%d %d %d", &n, &x, &s);
    while (n--) {
        scanf("%d %d", &c, &p);
        if (c <= x && p > s) {
            printf("YES");
            return 0;
        }
    }
    printf("NO");
    return 0;
}