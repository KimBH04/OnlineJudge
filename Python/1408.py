n = list(map(int, input().split(':')))
a = list(map(int, input().split(':')))

d = [a[0] - n[0], a[1] - n[1], a[2] - n[2]]

if d[2] < 0:
    d[1] -= 1
    d[2] += 60
if d[1] < 0:
    d[0] -= 1
    d[1] += 60
if d[0] < 0:
    d[0] += 24

print('{0:02d}'.format(d[0]) + ':' + '{0:02d}'.format(d[1]) + ':' + '{0:02d}'.format(d[2]))