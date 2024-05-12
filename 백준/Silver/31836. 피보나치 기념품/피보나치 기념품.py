n = int(input())

if n == 2:
    print('1\n1\n1\n2')
else:
    serim = []
    seongju = []
    for i in range(n, 2, -3):
        serim.append(str(i - 2))
        serim.append(str(i - 1))
        seongju.append(str(i))
    if (n - 2) % 3 == 0:
        serim.append('1')
        seongju.append('2')
    print(len(serim))
    print(' '.join(serim))
    print(len(seongju))
    print(' '.join(seongju))