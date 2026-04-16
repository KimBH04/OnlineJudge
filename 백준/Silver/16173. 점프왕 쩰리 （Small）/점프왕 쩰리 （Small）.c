#include <stdio.h>

int n;
int map[3][3];

int search(int r, int c)
{
    if (r >= n || c >= n || map[r][c] == 0)
        return 0;

    if (map[r][c] == -1)
        return 1;

    int jump = map[r][c];
    return search(r + jump, c) || search(r, c + jump);
}

int main()
{
    scanf("%d", &n);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            scanf("%d", map[i] + j);
        }
    }
    printf(search(0, 0) ? "HaruHaru" : "Hing");
    return 0;
}