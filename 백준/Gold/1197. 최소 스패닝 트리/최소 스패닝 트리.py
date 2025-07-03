from sys import stdin, setrecursionlimit
from queue import PriorityQueue

setrecursionlimit(100000)

def find_root(r, n):
    if r[n] != n:
        r[n] = find_root(r, r[n])
    return r[n]

input = stdin.readline

v, e = map(int, input().split())
v += 1
r = [*range(0, v)]

pq = PriorityQueue()
while e:
    e -= 1
    a, b, c = map(int, input().split())
    pq.put((c, a, b))

stw = 0
while not pq.empty():
    w, s, f = pq.get()
    s_root, f_root = find_root(r, s), find_root(r, f)
    if s_root != f_root:
        stw += w
        r[s_root] = r[f_root]

print(stw)