from sys import stdin, stdout

lines = stdin.readlines()

for line in lines[1:]:
    n, s, e = map(int, line.split())
    if (s == 1 and e == n) or (s == n and e == 1):
        stdout.write('0\n')
    elif (s == 1 or s == n) or abs(s - e) == 1:
        stdout.write('1\n')
    else:
        stdout.write('2\n')