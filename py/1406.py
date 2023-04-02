import sys

s = list(input())
m = int(input())
cursor = len(s)
while m:
    command = sys.stdin.readline().split()

    match command[0]:
        case 'L':
            if cursor:
                cursor -= 1
        
        case 'D':
            if cursor < len(s):
                cursor += 1

        case 'B':
            if cursor and s:
                del s[cursor - 1]
                if cursor >= len(s):
                    cursor = len(s)
        
        case 'P':
            s.insert(cursor, command[1])

    m -= 1

for i in s:
    print(i, end='')