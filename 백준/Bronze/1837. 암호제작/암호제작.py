p, k = map(int, input().split())

out = 'GOOD'
for i in range(2, k):
    if p % i:
        continue

    out = 'BAD ' + str(i)
    break

print(out)