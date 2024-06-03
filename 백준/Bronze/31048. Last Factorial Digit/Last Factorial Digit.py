t=int(input())
while t:
 t-=1;n=int(input());r=1
 for i in range(2, n):r*=i
 print(r*n%10)