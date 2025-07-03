from sys import stdin, stdout, setrecursionlimit

setrecursionlimit(1_000_000)

def find_root(r, n):
    if r[n] != n:
        r[n] = find_root(r, r[n])
    return r[n]

n, m = map(int, stdin.readline().split())
n += 1
r = [*range(0, n)]

while m:
    m -= 1

    c, a, b = map(int, stdin.readline().split())
    a_root, b_root = find_root(r, a), find_root(r, b)
    if c:
        stdout.write(('yes' if a_root == b_root else 'no') + '\n')
    else:
        r[a_root] = r[b_root]