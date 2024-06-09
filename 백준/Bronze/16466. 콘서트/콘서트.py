n = int(input())
a = sorted([0] + list(map(int, input().split())) + [2 ** 31])
for i in range(n + 2):
    if a[i] != i and not print(i):
        break