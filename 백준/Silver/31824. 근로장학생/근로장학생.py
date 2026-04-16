n, m = map(int, input().split())
dic = {}
while n:
    n -= 1
    values = input().split()
    dic[values[0]] = values[1]

while m:
    m -= 1
    value = ''
    word = input()
    l = len(word)
    for i in range(l):
        for j in range(i + 1, l + 1):
            if word[i:j] in dic:
                value += dic[word[i:j]]
    print(value if value else -1)