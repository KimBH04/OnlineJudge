t = int(input())
while t > 0:
    input() # n
    costs = [10001] + [*map(int, input().split())]
    costs.reverse()
    result = 0
    m = 0
    for cost in costs:
        if m < cost:
            m = cost
        else:
            result += m - cost
    print(result)
    t -= 1