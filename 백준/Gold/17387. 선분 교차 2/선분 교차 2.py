def ccw(x1, y1, x2, y2, x3, y3):
    return x1 * y2 + x2 * y3 + x3 * y1 - (y1 * x2 + y2 * x3 + y3 * x1)

def compare(x1, y1, x2, y2):
    a, b = (x1, y1), (x2, y2)
    if a == b:
        return 0
    return 1 if a > b else -1

def cross(x1, y1, x2, y2, x3, y3, x4, y4):
    a = ccw(x1, y1, x2, y2, x3, y3) * ccw(x1, y1, x2, y2, x4, y4)
    b = ccw(x3, y3, x4, y4, x1, y1) * ccw(x3, y3, x4, y4, x2, y2)
    if a == 0 and b == 0:
        if compare(x1, y1, x2, y2) > 0:
            x1, y1, x2, y2 = x2, y2, x1, y1
        if compare(x3, y3, x4, y4) > 0:
            x3, y3, x4, y4 = x4, y4, x3, y3
        return compare(x3, y3, x2, y2) <= 0 and compare(x1, y1, x4, y4) <= 0
    return a <= 0 and b <= 0

print(+cross(*map(int, ' '.join([input(), input()]).split())))