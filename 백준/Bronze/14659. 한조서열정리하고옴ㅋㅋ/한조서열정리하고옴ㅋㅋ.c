#include <stdio.h>

int main() {
    int n, m[32768], max = 0;
    scanf("%d", &n);
    for (int i = 0; i < n; i++) {
        scanf("%d", m + i);
    }
    for (int i = 0; i < n; i++) {
        int cnt = 0;
        for (int j = i + 1; j < n && m[j] < m[i]; j++) {
            cnt++;
        }
        if (max < cnt) {
            max = cnt;
        }
    }
    printf("%d", max);
    return 0;
}