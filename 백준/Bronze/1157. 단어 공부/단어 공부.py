a=[0]*26;s=input().upper();m=0;r=0
for c in s:
 i=ord(c)-65;a[i]+=1
 if m<a[i]:m=a[i];r=c
 elif m==a[i]:r='?'
print(r)