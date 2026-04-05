#include <stdio.h>

int main() {
    int n, q, query, l, r, alpha_cnt;
    char s[300], current;
    scanf("%d%d%s", &n, &q, s + 1);
    while (q--) {
        scanf("%d%d%d", &query, &l, &r);
        if (query == 1) {
            alpha_cnt = 1; current = '\0';
            for (; l < r; l++) {
                if (s[l] != s[l + 1]) {
                    alpha_cnt++;
                }
            }
            printf("%d\n", alpha_cnt);
        }
        else {
            for (; l <= r; l++) {
                s[l]++;
                if (s[l] > 'Z') {
                    s[l] = 'A';
                }
            }
        }
    }
    return 0;
}