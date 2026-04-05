#include <stdio.h>

typedef struct stric {
    int reverse_stric;
    char name[11];
} stric;

int main() {
    int n, m, cnts[201] = { 0, }, i, j, max, cnt, diff_cnt = 0;
    char whether;
    stric arr[201];
    scanf("%d%d", &n, &m);
    for (i = 0; i < n; i++) {
        max = 0; cnt = 0;
        for (j = 0; j < m; j++) {
        re: scanf("%c", &whether);
            if (whether == '*') {
                if (max < cnt) {
                    max = cnt;
                }
                cnt = 0;
            }
            else if (whether == '.') {
                cnt++;
            }
            else {
                goto re;
            }
        }
        if (max < cnt) {
            max = cnt;
        }
        if (cnts[max] == 0) {
            diff_cnt++;
        }
        cnts[max]++;
        arr[i].reverse_stric = max;
        scanf("%s", arr[i].name);
    }
    printf("%d\n", diff_cnt);
    for (i = 0; i < n; i++) {
        printf("%d %s\n", arr[i].reverse_stric, arr[i].name);
    }
    return 0;
}