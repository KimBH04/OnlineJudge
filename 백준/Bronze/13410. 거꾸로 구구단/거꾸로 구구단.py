n,k=map(int,input().split())
print(max(int(''.join(reversed(str(n*i))))for i in range(1,k+1)))