n = int(input())
house = [0] * (n + n + 1)
result = "Yes"
for s in input().split():
    i = int(s)
    house[i] += 1
    if house[i] > 2:
        result = "No"
        break
print(result)