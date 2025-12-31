n = int(input())
m = 1 << n * n
MASKED = m - 1

def locate_to_index(r: int, c: int) -> int:
    return r * n + c

def index_to_locate(a: int) -> tuple[int, int]:
    return (a // n, a % n)

def marking(m: int, r: int, c: int) -> int:
    result = 0
    i = r - min(r, c)
    j = c - min(r, c)
    while i < n and j < n:
        result |= 1 << locate_to_index(i, j)
        i += 1
        j += 1

    i = r + min(n - (r + 1), c)
    j = c - min(n - (r + 1), c)
    while i >= 0 and j < n:
        result |= 1 << locate_to_index(i, j)
        i -= 1
        j += 1

    return (result ^ MASKED) & m

def back_tracking(m: int, idx:int, max_idx: int, black: bool) -> int:
    if idx >= n * n:
        return 0
    
    result = 0
    for i in range(idx, max_idx):
        j, k = index_to_locate(i)
        if (j + k) % 2 == black and m & 1 << i:
            r, c = index_to_locate(i)
            new_m = marking(m, r, c)
            cnt = back_tracking(new_m, i + 1, max_idx, black) + 1
            if result < cnt:
                result = cnt

    return result

for i in range(n):
    s = input().split()
    for j in range(n):
        m += int(s[j]) << locate_to_index(i, j)

print(back_tracking(m, 0, n * n, True) + back_tracking(m, 0, n * n, False))