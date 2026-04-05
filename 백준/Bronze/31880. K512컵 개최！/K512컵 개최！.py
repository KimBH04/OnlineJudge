n, m = map(int, input().split())
s = sum(map(int, input().split()))
for i in input().split():
    j = int(i)
    if j > 0:
        s *= j
print(s)