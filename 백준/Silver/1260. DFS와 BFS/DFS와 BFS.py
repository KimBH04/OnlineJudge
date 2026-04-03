from collections import deque

n, m, v = map(int, input().split())
graph = [[]] + [[] for _ in range(n)]
while m > 0:
    m -= 1
    a, b = map(int, input().split())
    graph[a].append(b)
    graph[b].append(a)

for edge in graph:
    edge.sort()

visited = [0] * (n + 1)
visited[v] = 1
def bfs(v):
    print(v, end=' ')
    for node in graph[v]:
        if visited[node]:
            continue
        visited[node] = 1
        bfs(node)
bfs(v)

print()

queue = deque()
queue.append(v)
visited[v] = 0
while queue:
    v = queue.popleft()
    print(v, end=' ')
    for node in graph[v]:
        if not visited[node]:
            continue
        visited[node] = 0
        queue.append(node)