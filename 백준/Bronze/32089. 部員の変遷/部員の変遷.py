while 1:
    n = int(input())
    if n == 0:
        break

    s = 0
    ls = [*map(int, input().split())]
    for i in range(3):
        s += ls[i]

    m = s
    for i in range(3, n):
        s += ls[i]
        s -= ls[i - 3]
        if m < s:
            m = s

    print(m)