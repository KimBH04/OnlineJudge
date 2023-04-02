def main():
    n, s = list(map(int, input().split()))
    S = list(map(int, input().split()))

    if s > sum(S):
        print(0)
        return

    r = 100000

    for i in range(n):
        for j in range(i + 1, n + 1):
            if j - i >= r:
                break
            if s <= sum(S[i:j + 1]):
                r = j - i + 1
                break
        
    print(r)
    return

if __name__ == '__main__':
    main()