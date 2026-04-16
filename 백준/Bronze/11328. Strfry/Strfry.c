#include <stdio.h>

int main() {
    int n;
    scanf("%d", &n);
    while (n--) {
        int cnt[26] = { 0, };
        char a[1001], b[1001];
        scanf("%s %s", a, b);
        for (int i = 0; a[i] != 0; i++) {
            cnt[a[i] - 97]++;
        }
        for (int i = 0; b[i] != 0; i++) {
            cnt[b[i] - 97]--;
        }
        for (int i = 0; i < 26; i++) {
            if (cnt[i]) {
                printf("Impossible\n");
                goto next;
            }
        }
        printf("Possible\n");
    next:;
    }
    return 0;
}