n = int(input())
a = [*map(int, input().split())]

def sort(start: int, end: int) -> int:
    if start + 1 >= end:
        return 0
    
    mid = (start + end) // 2
    result = sort(start, mid) + sort(mid, end)

    global a
    arr_front = a[start:mid]
    len_front = mid - start
    ptr_front = 0
    arr_back = a[mid:end]
    len_back = end - mid
    ptr_back = 0
    i = start
    while ptr_front < len_front and ptr_back < len_back:
        if arr_front[ptr_front] > arr_back[ptr_back]:
            a[i] = arr_back[ptr_back]
            result += len_front - ptr_front
            ptr_back += 1
        else:
            a[i] = arr_front[ptr_front]
            ptr_front += 1
        i += 1
    
    while ptr_front < len_front:
        a[i] = arr_front[ptr_front]
        ptr_front += 1
        i += 1

    while ptr_back < len_back:
        a[i] = arr_back[ptr_back]
        ptr_back += 1
        i += 1

    return result

print(sort(0, n))