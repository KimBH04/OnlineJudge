n, w, l = map(int, input().split())
a = [*map(int, input().split())]
q = [0] * w
cnt = 0
idx = 0

while 1:
    del q[0]                # 다리에서 내리기
    cnt += 1

    if sum(q) + a[idx] > l: # 무게 되면 다리에 오르기
        q.append(0)
    else:
        q.append(a[idx])
        idx += 1

    if idx == n:            # 모든 트럭이 다리에 오르면
        cnt += w            # 마지막 트럭으로부터 끝까지 거리 더하기
        break

print(cnt)