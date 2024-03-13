from sys import stdin, stdout

n, q = map(int, stdin.readline().strip().split())
a = list(map(int, stdin.readline().strip().split()))
s = [a[0]] * n
for i in range(1, n):
    s[i] = s[i - 1] + a[i]
begin = 0
while q:
    q -= 1
    query = stdin.readline().strip().split()
    if query[0] == '1':
        k = int(query[1])
        begin -= k
        if begin < 0:
            begin = n + begin
    elif query[0] == '2':
        k = int(query[1])
        begin = (begin + k) % n
    else:
        a, b = map(int, query[1:])
        a = (begin + a - 1) % n
        b = (begin + b - 1) % n
        if a > b:
            stdout.write(f"{s[-1] - s[a - 1] + s[b]}\n")
        elif a == 0:
            stdout.write(f"{s[b]}\n")
        else:
            stdout.write(f"{s[b] - s[a - 1]}\n")