t = int(input())
while t > 0:
    t -= 1
    x = [*reversed(input())]
    y = [*reversed(input())]
    xl = len(x)
    yl = len(y)
    xy = xl + yl

    z = [int(c) for c in reversed(input())]
    zl = len(z)
    z += [0] * (xy - zl)
    f = [0] * xy
    for i in range(xl):
        for j in range(yl):
            f[i + j] += int(x[i]) * int(y[j])
    
    inf = "Infinity"
    for i in range(xy):
        if z[i] != f[i]:
            inf = "Finite"
            break

    print(inf)