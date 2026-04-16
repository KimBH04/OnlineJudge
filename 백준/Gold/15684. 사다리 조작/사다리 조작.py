n, m, h = map(int, input().split())
ladder = [[0] * h for _ in range(n)]
for _ in range(m):
    a, b = map(int, input().split())
    a -= 1
    ladder[b - 1][a] = 1
    ladder[b][a] = -1

def try_place(row: int, col: int) -> bool:
    return ladder[row][col] == 0 and ladder[row + 1][col] == 0

def step_down(idx: int) -> int:
    for i in range(h):
        idx += ladder[idx][i]
    return idx

def try_ladder() -> bool:
    for i in range(n):
        if i != step_down(i):
            return False
    return True

locates = [(i, j) for j in range(h) for i in range(n - 1) if try_place(i, j)]
count = len(locates)

def back_tracking(depth: int, start: int) -> int:
    if depth <= 3:
        if try_ladder():
            return depth
    if depth >= 3:
        return 4
    
    result = 4
    for i in range(start, count):
        r, c = locates[i]
        if not try_place(r, c):
            continue

        ladder[r][c] = 1
        ladder[r + 1][c] = -1
        res = back_tracking(depth + 1, i + 1)
        if result > res:
            result = res
        ladder[r][c] = 0
        ladder[r + 1][c] = 0
    return result

result = back_tracking(0, 0)
print(result if result < 4 else -1)