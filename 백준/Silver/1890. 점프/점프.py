n = int(input())
board = [[*map(int, input().split())] for _ in range(n)]

dp =[[-1] * n for _ in range(n)]
def dynamic_programming(r: int, c: int) -> int:
    global dp
    if r >= n or c >= n:
        return 0
    
    if board[r][c] == 0:
        if r + 1 == n and c + 1 == n:
            return 1
        else:
            return 0
    
    if dp[r][c] == -1:
        dp[r][c] = dynamic_programming(r + board[r][c], c) + dynamic_programming(r, c + board[r][c])

    return dp[r][c]

print(dynamic_programming(0, 0))