from sys import stdin, stdout
from collections import *

deq = deque()

n = int(stdin.readline())
while n:
    n -= 1
    command = stdin.readline().split()

    if command[0] == '1':
        deq.appendleft(command[1])
    elif command[0] == '2':
        deq.append(command[1])
    elif command[0] == '3':
        stdout.writelines((deq.popleft() if deq else '-1') + '\n')
    elif command[0] == '4':
        stdout.writelines((deq.pop() if deq else '-1') + '\n')
    elif command[0] == '5':
        stdout.writelines(str(len(deq)) + '\n')
    elif command[0] == '6':
        stdout.writelines(('0' if deq else '1') + '\n')
    elif command[0] == '7':
        stdout.writelines((deq[0] if deq else '-1') + '\n')
    elif command[0] == '8':
        stdout.writelines((deq[-1] if deq else '-1') + '\n')