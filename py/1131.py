memo = [0 for _ in range(3188647)]

def S(n):
    r = 0
    while n:
        r += (n % 10) ** k
        n //= 10
    return r

def DepthFirstSearch(n, visited):
    if visited[n]:
        return memo[n]
    
    visited[n] = True
    return min(memo[n], DepthFirstSearch(memo[n], visited))

def Progression(n):
    if memo[n]:
        return
    
    memo[n] = S(n)
    Progression(memo[n])

def main():
    global k
    visited = [False for _ in range(3188647)]

    a, b, k = map(int, input().split())

    for i in range(a, b + 1):
        Progression(i)

    r = 0
    for i in range(a, b + 1):
        r += DepthFirstSearch(i, visited)

    print(r)

if __name__ == '__main__':
    main()