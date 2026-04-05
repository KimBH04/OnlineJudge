from sys import stdin as r, stdout as w

n, q = map(int, r.readline().strip().split())
computers = [False] * (n + 1)
uninfect_cnt = n
while q:
    q -= 1
    line = r.readline().strip().split()
    if line[0] == '1':
        idx = int(line[1])
        uninfect_cnt -= 0 if computers[idx] else 1
        computers[idx] = True
    elif line[0] == '2':
        idx = int(line[1])
        uninfect_cnt += 1 if computers[idx] else 0
        computers[idx] = False
    else:
        w.write(f'{uninfect_cnt}\n')