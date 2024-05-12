#include <stdio.h>

int n, m, a, stack = 0, cnt = 0;

int main() {
    scanf("%d%d", &n, &m);
    while (n--) {
        scanf("%d", &a);
        stack += a;
        if (stack < 0) {
            stack = 0;
        }
        if (stack >= m) {
            cnt++;
        }
    }
    printf("%d", cnt);
    return 0;
}