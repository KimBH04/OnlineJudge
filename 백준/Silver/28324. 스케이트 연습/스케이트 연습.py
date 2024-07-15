n = int(input())
p = 0
s = 0
for v in [*map(int, input().split())][::-1]:
    if v >= s + 1:
        s += 1
    elif v < s:
        s = v
    p += s
print(p)