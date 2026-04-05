n, m = map(int, input().split())
rect = [input() for _ in range(n)]
result = 0
for size in range(min(n, m)):
    for i in range(n - size):
        for j in range(m - size):
            if (rect[i][j]        == rect[i + size][j] and
                rect[i + size][j] == rect[i][j + size] and
                rect[i][j + size] == rect[i + size][j + size]):
                result = max((size + 1) ** 2, result)
print(result)