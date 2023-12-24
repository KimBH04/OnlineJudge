from sys import stdin, stdout

n = int(stdin.readline())
while n:
    n -= 1
    stdout.write(f'{int(stdin.readline(), 2)}\n')