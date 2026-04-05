from sys import stdin, stdout

t = int(stdin.readline())
while t:
    t -= 1
    n = int(stdin.readline())
    stdout.write(f'{n * n}\n')