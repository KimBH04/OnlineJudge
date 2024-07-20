t=int(input())
while t:t-=1;l,r,s=map(int,input().split());a,b=s-l,r-s;print(a*2+1 if a<b else b*2)