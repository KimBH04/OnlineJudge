a, b = map(str, input().split())

a = list(a)
b = list(b)

r = 0
for i in a:
    for j in b:
        r += int(i) * int(j)

print(r)
