#include <stdio.h>

const int DIR[][2] = {
    { 0,  1},
    { 1,  0},
    { 0, -1},
    {-1,  0},
    { 1,  1},
    { 1, -1},
    {-1, -1},
    {-1,  1}
};
int map[64][64];
int width, height;

void search(int w, int h) {
    for (int i = 0; i < 8; i++) {
        int tw = w + DIR[i][0];
        int th = h + DIR[i][1];
        if (0 < tw && tw <= width && 0 < th && th <= height && map[tw][th]) {
            map[tw][th] = 0;
            search(tw, th);
        }
    }
}

int main() {
    for (;;) {
        scanf("%d%d", &width, &height);
        if (width == 0) break;
        for (int h = 1; h <= height; h++) {
            for (int w = 1; w <= width; w++) {
                scanf("%d", map[w] + h);
            }
        }
        int cnt = 0;
        for (int w = 1; w <= width; w++) {
            for (int h = 1; h <= height; h++) {
                if (map[w][h]) {
                    map[w][h] = 0;
                    cnt++;
                    search(w, h);
                }
            }
        }
        printf("%d\n", cnt);
    }
    return 0;
}