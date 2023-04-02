global white
global blue
white = 0
blue = 0

def ArrSum(arr:list) -> int:
    r = 0
    for i in arr:
        r += sum(i)
    
    return r

def DC(n:int, arr:list) -> None:
    global white
    global blue
    
    arrSum = ArrSum(arr)

    if arrSum == n * n:
        blue += 1
    elif arrSum == 0:
        white += 1
    else:
        divideN = int(n / 2)
        newArr = []
        for i in arr[:divideN]:
            newArr.append(i[:divideN])
            DC(divideN, newArr)
            
        newArr = []
        for i in arr[:divideN]:
            newArr.append(i[divideN:])
            DC(divideN, newArr)
        
        newArr = []
        for i in arr[divideN:]:
            newArr.append(i[:divideN])
            DC(divideN, newArr)
        
        newArr = []
        for i in arr[divideN:]:
            newArr.append(i[divideN:])
            DC(divideN, newArr)

n = int(input())
arr = []

while n:
    arr.append(list(map(int, input().split())))
    n -= 1

DC(n, arr)

print(white, blue, sep='\n')