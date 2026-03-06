t = int(input())
while t > 0:
    t -= 1
    x = [*map(int, input()[::-1])]
    y = [*map(int, input()[::-1])]
    l = len(x) + len(y)

    z = [*map(int, input()[::-1])] + [0] * l
    f = [0] * l
    for (i, xc) in enumerate(x):
        for (j, yc) in enumerate(y):
            f[i + j] += xc * yc
    
    inf = "Infinity"
    for i in range(l):
        if z[i] != f[i]:
            inf = "Finite"
            break

    print(inf)