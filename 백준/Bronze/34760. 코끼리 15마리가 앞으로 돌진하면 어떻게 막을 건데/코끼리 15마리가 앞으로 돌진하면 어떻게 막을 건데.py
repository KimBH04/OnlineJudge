a = [*map(int, input().split())]
m = max(a[:-1])
l = a[-1]
print(l if l > m else m + 1)