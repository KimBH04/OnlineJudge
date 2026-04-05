from sys import stdout

def back_tracking(nums:list, s:list, n:int, m:int, depth:int) -> None:
    if m == depth:
        for i in s:
            stdout.write(f'{i} ')
        stdout.write('\n')
    else:
        for i in range(n):
            if nums[i]:
                nums[i] = 0
                s[m] = i + 1
                back_tracking(nums, s, n, m + 1, depth)
                nums[i] = 1


n, m = map(int, input().split())
back_tracking([1] * n, [0] * m, n, 0, m)