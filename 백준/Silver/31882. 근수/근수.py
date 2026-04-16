input()
cnt = 0
stack = 0
score = 0
for c in input() + '\0':
    if c == '2':
        cnt += 1
        stack += cnt
        score += stack
    else:
        cnt = 0
        stack = 0
print(score)