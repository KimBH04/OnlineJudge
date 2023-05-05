import sys

t = int(sys.stdin.readline().strip())

while t:
    print(sum(map(int, sys.stdin.readline().strip().split())))
    t -= 1