def FizzBuzz(i: int) -> str:
    re = ('' if i % 3 else 'Fizz') + ('' if i % 5 else 'Buzz')
    return re if re else str(i)

try:
    s = int(input())
    print(FizzBuzz(s + 3))
except:
    try:
        s = int(input())
        print(FizzBuzz(s + 2))
    except:
        s = int(input())
        print(FizzBuzz(s + 1))