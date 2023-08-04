n = int(input()) * 2 - 1
e = ""
while n:
    c = input()
    if c == '/':
        e += c
    e += c
    n -= 1
print(eval(e))