#include <stdio.h>
#include <stdlib.h>
typedef long long int lld;

lld swap(int start, int end, lld *arr)
{
    if (start + 1 >= end)
    {
        return 0;
    }

    int mid = (start + end) / 2;
    lld result = swap(start, mid, arr) + swap(mid, end, arr);

    int len_front = mid - start;
    int len_back = end - mid;
    lld *arr_front = (lld*)malloc(sizeof(lld) * len_front);
    lld *arr_back = (lld*)malloc(sizeof(lld) * len_back);
    int i;
    for (i = start; i < mid; i++)
    {
        arr_front[i - start] = arr[i];
    }
    for (i = mid; i < end; i++)
    {
        arr_back[i - mid] = arr[i];
    }

    int ptr_front = 0;
    int ptr_back = 0;
    i = start;
    while (ptr_front < len_front && ptr_back < len_back)
    {
        if (arr_front[ptr_front] > arr_back[ptr_back])
        {
            arr[i++] = arr_back[ptr_back++];
            result += len_front - ptr_front;
        }
        else
        {
            arr[i++] = arr_front[ptr_front++];
        }
    }

    while (ptr_front < len_front)
    {
        arr[i++] = arr_front[ptr_front++];
    }
    while (ptr_back < len_back)
    {
        arr[i++] = arr_back[ptr_back++];
    }
    
    free(arr_front);
    free(arr_back);
    return result;
}

int main()
{
    int n;
    scanf("%d", &n);
    lld *a = (lld*)malloc(sizeof(lld) * n);
    for (int i = 0; i < n; i++)
    {
        scanf("%lld", a + i);
    }

    printf("%lld", swap(0, n, a));

    free(a);
    return 0;
}