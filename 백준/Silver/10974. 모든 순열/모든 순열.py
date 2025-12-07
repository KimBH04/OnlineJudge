n = int(input())

v = [0] * n
arr = [0] * n

def bt(a: int):
    if a == n:
        print(*arr)
        return
    
    for i in range(0, n):
        if v[i]:
            continue
        arr[a] = i + 1
        v[i] = 1
        bt(a + 1)
        v[i] = 0

bt(0)