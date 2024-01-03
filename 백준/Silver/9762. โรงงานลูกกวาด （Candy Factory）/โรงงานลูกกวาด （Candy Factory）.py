H=0
def S(a,n):
 global H
 if a[n]<1:l,r=S(a,n*2),S(a,n*2+1);a[n]=min(l,r);H+=abs(l-r)
 return a[n]
t=int(input())
while t:t-=1;n=int(input());c=(n-n//2)*[0]+list(map(int,input().split()));print(S(c,1)+H);H=0