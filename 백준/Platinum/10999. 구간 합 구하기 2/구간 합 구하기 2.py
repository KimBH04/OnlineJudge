from sys import stdin, stdout

n, m, k = map(int, stdin.readline().split())
array = [0] + [int(stdin.readline()) for _ in range(n)]

depth = 1
while n >= depth:
    depth <<= 1
depth <<= 1
depth -= 1
tree = [0] * depth
lazy = [0] * depth

def make(node: int, start: int, end: int):
    if start > end:
        return

    if start == end:
        tree[node] = array[start]
        return

    mid = (start + end) >> 1
    make(node * 2, start, mid)
    make(node * 2 + 1, mid + 1, end)
    tree[node] = tree[node * 2] + tree[node * 2 + 1]

def update(node: int, start: int, end: int, value: int, left: int, right: int):
    if lazy[node]:
        tree[node] += (end - start + 1) * lazy[node]
        if start != end:
            lazy[node * 2] += lazy[node]
            lazy[node * 2 + 1] += lazy[node]
        lazy[node] = 0

    if end < left or start > right:
        return

    if start >= left and end <= right:
        tree[node] += (end - start + 1) * value
        if start != end:
            lazy[node * 2] += value
            lazy[node * 2 + 1] += value
        return

    mid = (start + end) >> 1
    update(node * 2, start, mid, value, left, right)
    update(node * 2 + 1, mid + 1, end, value, left, right)
    tree[node] = tree[node * 2] + tree[node * 2 + 1]

def get_sum(node: int, start: int, end: int, left: int, right: int) -> int:
    if lazy[node]:
        tree[node] += (end - start + 1) * lazy[node]
        if start != end:
            lazy[node * 2] += lazy[node]
            lazy[node * 2 + 1] += lazy[node]
        lazy[node] = 0

    if end < left or start > right:
        return 0

    if start >= left and end <= right:
        return tree[node]

    mid = (start + end) >> 1
    return get_sum(node * 2, start, mid, left, right) + get_sum(node * 2 + 1, mid + 1, end, left, right)

make(1, 1, n)
for _ in range(m + k):
    query = stdin.readline().split()
    a, b, c = map(int, query[:3])
    if a == 1:
        d = int(query[-1])
        update(1, 1, n, d, b, c)
    else:
        stdout.write(f'{get_sum(1, 1, n, b, c)}\n')