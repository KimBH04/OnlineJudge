#include <stdio.h>
#include <stdlib.h>

int main() {
    int robot, box, goal;
    char state[16];
    scanf("%s", state);
    for (int i = 0; i < 10; i++) {
        switch (state[i])
        {
        case '@':
            robot = i;
            break;
        case '#':
            box = i;
            break;
        case '!':
            goal = i;
            break;
        default:
            break;
        }
    }
    printf("%d", (robot < box && box < goal) || (robot > box && box > goal) ? abs(robot - goal) - 1 : -1);
    return 0;
}