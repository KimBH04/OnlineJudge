n = int(input())

for i in range(1, n + 1):
    if i == n:
        for j in range(n * 2 - 1):
            print(end='*')
        break

    for j in range(n - i):
        print(end=' ')

    print(end='*')
    if i == 1:
        print()
    else:
        for j in range(i * 2 - 3):
            print(end=' ')
        print('*')