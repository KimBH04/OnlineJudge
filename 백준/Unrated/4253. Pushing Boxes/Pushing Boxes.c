#include <stdio.h>
#include <string.h>

int width, height, map[20][20];

void push_boxes(int x, int y, int right, int down)
{
    if (map[x][y])
    {
        push_boxes(x + right, y + down, right, down);
        map[x + right][y + down] = 1;
        map[x][y] = 0;
    }
}

int check_boxes(int x, int y, int right, int down)
{
    if (x >= width || y >= height || x < 0 || y < 0)
    {
        return 0;
    }

    if (map[x][y])
    {
        return check_boxes(x + right, y + down, right, down);
    }
    
    return 1;
}

int main()
{
    for (int k = 1; ; k++)
    {
        scanf("%d %d", &height, &width);
        if (!height && !width)
        {
            break;
        }

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                map[j][i] = 0;
            }
        }

        int n;
        scanf("%d", &n);
        while (n--)
        {
            int row, column;
            scanf("%d %d", &row, &column);
            map[column][row] = 1;
        }

        for (; ; )
        {
            char dir[5];
            int time;
            scanf("%s", dir);
            if (!strncmp(dir, "up", 2))
            {
                scanf("%d", &time);
                for (int i = 1; height - i >= height - time; i++)
                {
                    int is_stop = 0;
                    for (int j = 0; j < width; j++)
                    {
                        is_stop |= !check_boxes(j, height - i, 0, -1);
                    }

                    if (is_stop)
                    {
                        break;
                    }

                    for (int j = 0; j < width; j++)
                    {
                        push_boxes(j, height - i, 0, -1);
                    }
                }
            }
            else if (!strncmp(dir, "down", 4))
            {
                scanf("%d", &time);
                for (int i = 0; i < time; i++)
                {
                    int is_stop = 0;
                    for (int j = 0; j < width; j++)
                    {
                        is_stop |= !check_boxes(j, i, 0, 1);
                    }

                    if (is_stop)
                    {
                        break;
                    }

                    for (int j = 0; j < width; j++)
                    {
                        push_boxes(j, i, 0, 1);
                    }
                }
            }
            else if (!strncmp(dir, "left", 4))
            {
                scanf("%d", &time);
                for (int i = 1; width - i >= width - time; i++)
                {
                    int is_stop = 0;
                    for (int j = 0; j < height; j++)
                    {
                        is_stop |= !check_boxes(width - i, j, -1, 0);
                    }
                    
                    if (is_stop)
                    {
                        break;
                    }

                    for (int j = 0; j < height; j++)
                    {
                        push_boxes(width - i, j, -1, 0);
                    }
                }
            }
            else if (!strncmp(dir, "right", 5))
            {
                scanf("%d", &time);
                for (int i = 0; i < time; i++)
                {
                    int is_stop = 0;
                    for (int j = 0; j < height; j++)
                    {
                        is_stop |= !check_boxes(i, j, 1, 0);
                    }

                    if (is_stop)
                    {
                        break;
                    }

                    for (int j = 0; j < height; j++)
                    {
                        push_boxes(i, j, 1, 0);
                    }
                }
            }
            else
            {
                break;
            }
        }

        printf("Data set %d ends with boxes at locations", k);
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (map[j][i])
                {
                    printf(" (%d,%d)", i, j);
                }
            }
        }
        printf(".\n");
    }
    return 0;
}