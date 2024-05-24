def main():
    global tree
    n = int(input())
    arr = input().split()
    m = int(input())
    root = -1
    tree = [[] for _ in range(n)]
    for child in range(n):
        parent = int(arr[child])
        if parent < 0:
            if child == m:
                return 0
            else:
                root = child
        elif child != m:
            tree[parent].append(child)
    return bfs(root)

def bfs(n):
    global tree
    cnt = 0
    for v in tree[n]:
        cnt += bfs(v)
    return cnt if cnt else 1

if __name__ == '__main__':
    print(main())