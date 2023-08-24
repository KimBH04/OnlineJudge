card = [0] * 20000001

n = int(input())
for i in map(int, input().split()):
    card[i + 10000000] += 1

m = int(input())
for i in map(int, input().split()):
    print(card[i + 10000000], end=" ")
