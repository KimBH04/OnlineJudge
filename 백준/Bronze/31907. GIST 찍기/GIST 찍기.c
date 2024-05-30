#include <stdio.h>

char flag[4][8] = {
    "G...",
    ".I.T",
    "..S.",
};

int main() {
    int k; scanf("%d", &k);
    for (int a = 0; a < 3; a++) {
        for (int b = 0; b < k; b++) {
            for (int c = 0; c < 4; c++) {
                for (int d = 0; d < k; d++) {
                    printf("%c", flag[a][c]);
                }
            }
            printf("\n");
        }
    }
    return 0;
}