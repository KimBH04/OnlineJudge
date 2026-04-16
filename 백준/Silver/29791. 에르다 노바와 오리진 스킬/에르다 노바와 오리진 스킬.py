def maple(ls, C):
    r = 0
    c = 0
    for i in ls:
        if c <= i:
            c = i + C
            r += 1
    return r

input()
a = list(map(int, input().split()))
b = list(map(int, input().split()))

a.sort()
b.sort()
print(maple(a, 100), maple(b, 360))