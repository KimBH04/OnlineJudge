from sys import stdin, stdout, setrecursionlimit

setrecursionlimit(100000)

s = 0

def depth_first_search(nodes, visited, sequence, v):
    global s
    s += 1
    sequence[v] = s
    for i in nodes[v]:
        if visited[i]:
            continue

        visited[i] = 1
        depth_first_search(nodes, visited, sequence, i)

n, m, r = map(int, stdin.readline().split())
nodes = [[] for _ in range(n + 1)]
visited = [0] * (n + 1)
sequence = [0] * (n + 1)

while m:
    m -= 1
    u, v = map(int, stdin.readline().split())
    nodes[u].append(v)
    nodes[v].append(u)

for i in range(1, n + 1):
    nodes[i] = sorted(nodes[i], reverse=1)

visited[r] = 1
depth_first_search(nodes, visited, sequence, r)

for i in sequence[1:]:
    stdout.write(f'{i}\n')