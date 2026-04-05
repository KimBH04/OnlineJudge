while True:
    try:
        jolly = True
        _input = input()

        strInput = _input.split()
        n = int(strInput[0])

        if n == 1:
            print('Jolly')
            continue

        nums = [0 for _ in range(n)]
        n -= 1
        jollyTest = [0 for _ in range(n)]
        
        nums = list(map(int, strInput[1:]))

        for index in range(n):
            jollyTest[index] = abs(nums[index] - nums[index + 1])

        jollyTest.sort()

        jollyTemp = jollyTest[0]

        for item in jollyTest[1:]:
            if jollyTemp + 1 != item:
                jolly = False
                break
            jollyTemp = item

        if jolly:
            print('Jolly')
        else:
            print('Not jolly')

    except:
        break