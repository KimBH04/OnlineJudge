#include <stdio.h>
#define INF 1000000000

int main() {
    int n, m, a, b, c, dis[128][128];
    scanf("%d%d", &n, &m);
    for (a = 1; a <= n; a++) {
        for (b = 1; b <= n; b++) {
            dis[a][b] = a == b ? 0 : INF;
        }
    }
    while (m-- > 0) {
        scanf("%d%d%d", &a, &b, &c);
        if (dis[a][b] > c) {
            dis[a][b] = c;
        }
    }
    for (m = 1; m <= n; m++) {
        for (a = 1; a <= n; a++) {
            for (b = 1; b <= n; b++) {
                if (dis[a][b] > dis[a][m] + dis[m][b]) {
                    dis[a][b] = dis[a][m] + dis[m][b];
                }
            }
        }
    }
    for (a = 1; a <= n; a++) {
        for (b = 1; b <= n; b++) {
            printf("%d ", dis[a][b] == INF ? 0 : dis[a][b]);
        }
        printf("\n");
    }
    return 0;
}