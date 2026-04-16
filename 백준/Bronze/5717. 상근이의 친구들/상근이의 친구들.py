while True:
    friends = list(map(int, input().split()))
    if friends[0] + friends[1] == 0:
        break
    print(friends[0] + friends[1])