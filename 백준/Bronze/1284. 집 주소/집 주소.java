import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws Exception {
        Scanner scanner = new Scanner(System.in);
        while (true) {
            int n = scanner.nextInt();
            scanner.nextLine();
            if (n == 0) {
                break;
            }

            int r = 0;
            while (n > 0) {
                switch (n % 10) {
                    case 0:
                        r += 5;
                        break;
                    case 1:
                        r += 3;
                        break;
                    default:
                        r += 4;
                        break;
                }

                n /= 10;
            }

            System.out.println(r + 1);
        }
        scanner.close();
    }
}
