#include <stdio.h>
#define abs(x) (((x) < 0) ? (-(x)) : (x))

int main()
{
    int left = 1, right, arr[100001], min = 2147483647, a = 0, b = 0;
    scanf("%d", &right);
    for (int i = 1; i <= right; i++)
    {
        scanf("%d", arr + i);
    }
    while (left < right)
    {
        int sum = arr[left] + arr[right];
        int abs_sum = abs(sum);
        if (min > abs_sum)
        {
            min = abs_sum;
            a = arr[left];
            b = arr[right];
        }
        if (sum > 0)
        {
            right--;
        }
        else if (sum < 0)
        {
            left++;
        }
        else
        {
            a = arr[left];
            b = arr[right];
            break;
        }
    }
    printf("%d %d", a, b);
    return 0;
}