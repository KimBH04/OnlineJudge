from collections import deque

n, m, v = map(int, input().split())
edge = [[] for _ in range(n + 1)]
visited = [0 for _ in range(n + 1)]

def DepthFirstSearch(v):
    print(v, end=' ')

    for node in edge[v]:
        if visited[node]:
            continue
        visited[node] = 1
        DepthFirstSearch(node)

def BreathFirstSearch(v):
    queue = deque([v])

    while queue:
        q = queue.popleft()
        print(q, end=' ')

        for node in edge[q]:
            if visited[node]:
                continue
            visited[node] = 1
            queue.append(node)

while m:
    a, z = map(int, input().split())
    edge[a].append(z)
    edge[a].sort()

    edge[z].append(a)
    edge[z].sort()
    
    m -= 1

visited[v] = 1
DepthFirstSearch(v)
print()

visited = [0 for _ in range(n + 1)]
visited[v] = 1
BreathFirstSearch(v)

