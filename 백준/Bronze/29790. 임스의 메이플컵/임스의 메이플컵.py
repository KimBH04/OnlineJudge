def maple(n, u, l):
    if n > 999:
        if u > 7999 or l > 259:
            return 'Very Good'
        return 'Good'
    return 'Bad'
n, u, l = map(int, input().split())
print(maple(n, u, l))