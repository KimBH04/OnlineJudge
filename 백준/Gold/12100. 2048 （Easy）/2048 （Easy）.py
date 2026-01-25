n = int(input())
def back_tracking(m: list[list[int]], depth: int) -> int:
    if depth == 5:
        re = 0
        for lst in m:
            for i in lst:
                if re < i:
                    re = i
        return re

    re = 0
    for dir_r, dir_c in [(1, 0), (-1, 0), (0, 1), (0, -1)]:
        nxt = [[m[i][j] for j in range(n)] for i in range(n)]
        for i in range(n):
            r = (-(dir_r == -1)) if dir_r else i
            c = (-(dir_r == -1)) if dir_c else i
            last = 0
            for j in range(1, n):
                for ptr in range(j, last, -1):
                    r = ((ptr + (dir_r == -1)) * dir_r) if dir_r else i
                    c = ((ptr + (dir_c == -1)) * dir_c) if dir_c else i
                    if nxt[r - dir_r][c - dir_c]:
                        if nxt[r - dir_r][c - dir_c] == nxt[r][c]:
                            nxt[r - dir_r][c - dir_c] *= 2
                            nxt[r][c] = 0
                            last = ptr
                        break
                    else:
                        nxt[r - dir_r][c - dir_c] = nxt[r][c]
                        nxt[r][c] = 0
        next_re = back_tracking(nxt, depth + 1)
        if re < next_re:
            re = next_re
    return re

print(back_tracking([[*map(int, input().split())] for _ in range(n)], 0))