from typing import Optional, List, Tuple

class PanCakeCookie:
    def __init__(self, w: int, h: int, maxC: int, u: int, d: int):
        self.__w = w
        self.__h = h
        self.__x = 0
        self.__y = 0
        self.__t = 0
        self.__score = 0
        self.__maxC = maxC
        self.__curC = maxC
        self.__u = u
        self.__d = d

    def getX(self) -> int:
        return self.__x

    def getY(self) -> int:
        return self.__y

    def getU(self) -> int:
        return self.__u

    def getD(self) -> int:
        return self.__d

    def getScore(self) -> int:
        return self.__score

    def getC(self) -> int:
        return self.__curC

    def reset(self) -> None:
        self.__x = 0
        self.__y = 0
        self.__t = 0
        self.__score = 0

    def setU(self, x: int) -> None:
        if x > 0 and x < 1001:
            self.__u = x
            self.reset()

    def setD(self, x: int) -> None:
        if x > 0 and x < 1001:
            self.__d = x
            self.reset()

    def setC(self, x: int) -> None:
        if x > 0 and x < 1001:
            self.__maxC = x
            self.reset()

    def setT(self, t: int) -> None:
        if t > -1 and t < self.__w:
            self.__t = t