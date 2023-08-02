//\u000a/*

#include <iostream>

int main()
{
    int b[11] = { 0, 1, 10, 11, 100, 101, 110, 111, 1000, 1001, 1010 }, n;
    std::cin >> n;
    for (int i = 0; i <= n; i++)
    {
        std::cout << b[i];
    }
}
//*/
/*\u002a/
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int[] b = { 0, 1, 10, 11, 100, 101, 110, 111, 1000, 1001, 1010 };
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        for (int i = 0; i <= n; i++) {
            System.out.print(b[i]);
        }
        scanner.close();
    }
}

/*\u002a/
// */