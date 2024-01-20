find = input()
n = int(input())
r = 0
while n:
    n -= 1
    ring = input() * 2
    if find in ring:
        r += 1
print(r)