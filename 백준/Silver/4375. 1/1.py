from sys import stdin, stdout

for item in stdin.readlines():
    n = int(item.strip())
    m = 1
    digit = 1

    while m % n or not stdout.write(f'{digit}\n'):
        m *= 10
        m += 1
        digit += 1