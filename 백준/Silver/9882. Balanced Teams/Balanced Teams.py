def bt(arr: list[int], res: list[tuple[int, int, int]], used: list[bool], n: int, depth: int, m: int) -> int:
    if depth >= m:
        balance = [sum(res[i]) for i in range(n // 3)]
        return max(balance) - min(balance)
    
    minimum = 12_000_000
    for i in range(n - 2):
        if used[i]:
            continue
        used[i] = True

        for j in range(i + 1, n - 1):
            if used[j]:
                continue
            used[j] = True

            for k in range(j + 1, n):
                if used[k]:
                    continue
                used[k] = True

                res[depth] = (arr[i], arr[j], arr[k])
                result = bt(arr, res, used, n, depth + 1, m)
                if minimum > result:
                    minimum = result

                used[k] = False
            used[j] = False
        used[i] = False
    return minimum

s = [int(input()) for _ in range(12)]
res_arr = [(0, 0, 0), (0, 0, 0), (0, 0, 0), (0, 0, 0)]
v = [False] * 12
print(bt(s, res_arr, v, 12, 0, 4))