t = int(input())

while t:
    c = 0
    g = 0
    n = int(input())

    while n:
        i = input().split()
        a = int(i[0])
        b = float(i[1])
        c += a
        g += a * b

        n -= 1

    print(c, g / c)
    t -= 1
