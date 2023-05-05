n = int(input())

q1, q2, q3, q4, axis = 0, 0, 0, 0, 0
while n:
    x, y = map(int, input().split())
    if x == 0 or y == 0:
        axis += 1
    else:
        if x > 0:
            if y > 0:
                q1 += 1
            else:
                q4 += 1
        else:
            if y > 0:
                q2 += 1
            else:
                q3 += 1
    n -= 1

print('Q1:', q1, sep=' ')
print('Q2:', q2, sep=' ')
print('Q3:', q3, sep=' ')
print('Q4:', q4, sep=' ')
print('AXIS:', axis, sep=' ')