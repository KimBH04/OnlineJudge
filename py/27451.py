import sys
import heapq

INF = sys.maxsize

n, m = map(int, input().split())
a, b, c = map(int, input().split())

# 그래프 초기화
graph = [[] for _ in range(n+1)]
for _ in range(m):
    s, e = map(int, input().split())
    graph[s].append(e)
    graph[e].append(s)

# 다익스트라 알고리즘
def dijkstra(start):
    dist = [INF] * (n+1)
    dist[start] = 0
    heap = []
    heapq.heappush(heap, (0, start))

    while heap:
        cost, node = heapq.heappop(heap)

        if dist[node] < cost:
            continue

        for next_node in graph[node]:
            next_cost = cost + 1
            if next_cost < dist[next_node]:
                dist[next_node] = next_cost
                heapq.heappush(heap, (next_cost, next_node))

    return dist

# 최단 거리 계산
dist_a = dijkstra(a)
dist_b = dijkstra(b)
dist_c = dijkstra(c)

# 최소 거리 찾기
min_dist = INF
ans = -1
for i in range(1, n+1):
    total_dist = dist_a[i] + dist_b[i] + dist_c[i]
    if min_dist > total_dist:
        min_dist = total_dist
        ans = i

# 결과 출력
if ans == -1:
    print(-1)
else:
    print(ans)
    print(min_dist)
    for dist in [dist_a, dist_b, dist_c]:
        path = []
        node = ans
        while node != dist.index(0):
            path.append(node)
            for next_node in graph[node]:
                if dist[next_node] == dist[node] - 1:
                    node = next_node
                    break
        path.append(dist.index(0))
        path.reverse()
        print(" ".join(map(str, path)))