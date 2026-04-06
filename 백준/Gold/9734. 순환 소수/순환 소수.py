def gcd(a, b):
    while b:
        a, b = b, a % b
    return a

from sys import stdin, stdout

inputs = stdin.readlines()
for s in inputs:
    multi = [0, 0]
    idx = 0
    i, d = s.split('.')
    for c in d:
        if c == '(':
            diff = int(i)
            idx = 1
            continue
        if c == ')':
            break
        i += c
        multi[idx] += 1
    numer = int(i) - diff
    denomin = int('9' * multi[1] + '0' * multi[0])
    n = gcd(denomin, numer)
    stdout.write(f'{s.strip()} = {numer // n} / {denomin // n}\n')