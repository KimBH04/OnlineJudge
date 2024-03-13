total = 0
input()
nums = input().split()
findNum = input()

for i in nums:
    if i == findNum:
        total = total + 1

print(total)
