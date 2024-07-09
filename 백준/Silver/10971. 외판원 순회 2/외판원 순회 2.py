n = int(input())
w = [[*map(int, input().split())] for _ in range(n)]
mini = 0x123456789
arr = []

def back_tracking(m: int) -> None:
    global arr
    if m == n:
        dis = 0
        for i in range(n):
            if w[arr[i - 1]][arr[i]] == 0:
                return
            dis += w[arr[i - 1]][arr[i]]
        global mini
        if mini > dis:
            mini = dis
        return
    
    for i in range(0, n):
        if i in arr:
            continue
        arr.append(i)
        back_tracking(m + 1)
        arr.pop()

back_tracking(0)
print(mini)