from collections import deque

def main():
    global color
    global edges
    global n
    v, e = map(int, input().split())
    n = v + 1
    color = [None] * n
    edges = [[] for _ in range(n)]
    while e:
        e -= 1
        a, b = map(int, input().split())
        edges[a].append(b)
        edges[b].append(a)
    return bfs()
    
def bfs():
    global color
    global edges
    global n
    for i in range(1, n):
        if color[i] == None:
            color[i] = True
            queue = deque([i])
            while queue:
                node = queue.popleft()
                for j in edges[node]:
                    if color[j] == None:
                        color[j] = not color[node]
                        queue.append(j)
                    elif color[j] == color[node]:
                        return "NO"
    return "YES"

if __name__ == '__main__':
    k = int(input())
    while k:
        k -= 1
        print(main())