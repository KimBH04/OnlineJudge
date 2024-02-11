n = int(input())

r = 1001
while n:
    n -= 1
    a, b = map(int, input().split())
    if a <= b and r > b:
        r = b
        
print(r if r < 1001 else -1)