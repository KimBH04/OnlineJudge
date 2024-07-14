def main():
    n, s, p = map(int, input().split())
    if n == 0:
        return 1

    ls = [-1, *map(int, input().split())]
    r = 1
    for i in range(1, n + 1):
        if ls[i] < s:
            if ls[i - 1] == s:
                return r
            else:
                return i
        if ls[i - 1] != ls[i]:
            r = i
    if n < p:
        if ls[-1] > s:
            return n + 1
        else:
            return r
    else:
        return -1

if __name__ == '__main__':
    print(main())