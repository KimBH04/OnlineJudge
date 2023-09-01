from sys import stdin, stdout

while 1:
    n = int(stdin.readline())
    if not n:
        break

    for i in range(1, n + 1):
        stdout.write('*' * i + '\n')