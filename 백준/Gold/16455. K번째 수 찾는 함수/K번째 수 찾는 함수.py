from random import randint

def kth(a, k):
    l = len(a)
    k -= 1
    start = 0
    pivot = l - 1
    while 1:
        rand = randint(start, pivot)
        a[rand], a[pivot] = a[pivot], a[rand]
        
        left = start
        right = pivot - 1

        while 1:
            while left <= right and (a[left] < a[pivot] or (a[left] == a[pivot] and left < rand)):
                left += 1
            while left <= right and (a[right] > a[pivot] or (a[right] == a[pivot] and right > rand)):
                right -= 1

            if left >= right:
                break

            a[left], a[right] = a[right], a[left]

        a[left], a[pivot] = a[pivot], a[left]
        
        if left < k:
            start = left + 1
        elif left > k:
            pivot = left - 1
        else:
            return a[k]

if __name__ == '__main__':
    n, k = map(int, input().split())
    a = [randint(0, 100) for _ in range(n)]
    print(a)
    print(kth(a, k))
    print(a)