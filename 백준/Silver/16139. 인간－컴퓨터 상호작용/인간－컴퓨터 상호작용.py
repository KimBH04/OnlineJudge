from sys import stdin, stdout

s = stdin.readline().strip()
ls = [[0] * (len(s) + 1) for _ in range(26)]
for i in range(len(s)):
    ls[ord(s[i]) - 97][i + 1] = 1
    for e in ls:
        e[i + 1] += e[i]

q = int(stdin.readline())
while q:
    q -= 1
    i = stdin.readline().split()
    c = i[0]
    l, r = map(int, i[1:])
    a = ord(c) - 97
    stdout.write(f"{ls[a][r + 1] - ls[a][l]}\n")
