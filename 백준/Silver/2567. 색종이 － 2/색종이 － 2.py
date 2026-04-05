paper = [[0 for _ in range(101)] for _ in range(101)]
r = 0

n = int(input())
while n:
    x, y = map(int, input().split())
    for i in range(10):
        for j in range(10):
            paper[x + i][y + j] = 1
    n -= 1

for x in range(101):
    for y in range(101):
        if paper[x][y]:
            if x + 1 < 101:
                if not paper[x + 1][y]:
                    r += 1

            if x - 1 >= 0:
                if not paper[x - 1][y]:
                    r += 1

            if y + 1 < 101:
                if not paper[x][y + 1]:
                    r += 1

            if y - 1 >= 0:
                if not paper[x][y - 1]:
                    r += 1

print(r)
