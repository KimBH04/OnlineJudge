from sys import stdout

DIR = [(1, 2), (2, 1), (-1, -2), (-2, -1), (-1, 2), (2, -1), (1, -2), (-2, 1)]

n = int(input())
r, c = map(int, input().split())
r -= 1
c -= 1
if n % 2 and (r + c) % 2:
    print(-1, -1)
    exit(0)

def t2i(x: int, y: int):
    return x * n + y

def i2t(x: int):
    return (x // n, x % n)

board = [0] * (n * n)
for i in range(n):
    for j in range(n):
        for rd, cd in DIR:
            if 0 <= i + rd and i + rd < n and 0 <= j + cd and j + cd < n:
                board[t2i(i, j)] += 1

while 1:
    stdout.write(f'{r + 1} {c + 1}\n')
    board[t2i(r, c)] = 9
    m = 9
    for rd, cd in DIR:
        tr = r + rd
        tc = c + cd
        if 0 <= tr and tr < n and 0 <= tc and tc < n and m > board[t2i(tr, tc)]:
            m = board[t2i(tr, tc)]
            r = tr
            c = tc
    if m == 9:
        break