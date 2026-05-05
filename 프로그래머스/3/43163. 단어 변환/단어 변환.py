def solution(begin, target, words):
    n = len(words)
    edges = [[] for _ in range(n)]
    for i in range(n):
        for j in range(i + 1, n):
            if sum(1 for a, b in zip(words[i], words[j]) if a != b) == 1:
                edges[i].append(j)
                edges[j].append(i)
                
    queue = []
    v = [0] * n
    for i in range(n):
        if sum(1 for a, b in zip(begin, words[i]) if a != b) == 1:
            queue.append(i)
            v[i] = 1

    cnt = 1
    while queue:
        qlen = len(queue)
        while qlen > 0:
            qlen -= 1
            e = queue[0]
            del queue[0]
            if words[e] == target:
                return cnt
        
            for node in edges[e]:
                if v[node]:
                    continue
            
                v[node] = 1
                queue.append(node)
        cnt += 1

    return 0