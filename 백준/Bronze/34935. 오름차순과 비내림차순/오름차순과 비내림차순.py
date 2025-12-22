n = int(input())
ls = [*map(int, input().split())]
for i in range(n - 1):
    if ls[i] >= ls[i + 1]:
        print(0)
        exit(0)
print(1)