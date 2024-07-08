#include <stdio.h>

void merge_sort(int *arr, int start, int end)
{
    if (start + 1 >= end)
    {
        return;
    }

    int half = (start + end) / 2;
    merge_sort(arr, start, half);
    merge_sort(arr, half, end);

    int merge[100000], i = start, j = half, k = 0;
    while (i < half && j < end)
    {
        if (arr[i] < arr[j])
        {
            merge[k] = arr[i];
            k++; i++;
        }
        else
        {
            merge[k] = arr[j];
            k++; j++;
        }
    }

    while (i < half)
    {
        merge[k] = arr[i];
        k++; i++;
    }

    while (j < end)
    {
        merge[k] = arr[j];
        k++; j++;
    }

    for (i = 0; i < k; i++)
    {
        arr[start + i] = merge[i];
    }
}

int main()
{
    int n, arr[100000];
    scanf("%d", &n);
    for (int i = 0; i < n; i++)
    {
        scanf("%d", arr + i);
    }
    merge_sort(arr, 0, n);

    int left = 0, right = n - 1, a = 0, b = 0, min = 0x7FFFFFFF;
    while (left < right)
    {
        int sum = arr[left] + arr[right];
        int abs_sum = sum < 0 ? -sum : sum;
        if (min > abs_sum)
        {
            a = arr[left];
            b = arr[right];
            min = abs_sum;
        }

        if (sum < 0)
        {
            left++;
        }
        else if (sum > 0)
        {
            right--;
        }
        else
        {
            break;
        }
    }
    printf("%d %d", a, b);
    return 0;
}