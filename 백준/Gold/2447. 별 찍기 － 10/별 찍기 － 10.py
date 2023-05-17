def recursive(x: int, y: int, n: int) -> None:
    d = n // 3
    r = 0

    for i in range(x, n + x, d):
        for j in range(y, n + y, d):
            r += 1
            if r == 5:
                continue

            if d == 1:
                re[i][j] = "*"
            else:
                recursive(i, j, d)


n = int(input())
re = [[" "] * n for _ in range(n)]

recursive(0, 0, n)

for x in range(n):
    for y in range(n):
        print(re[x][y], end="")
    print()
