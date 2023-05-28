import java.util.Scanner;

public class Main {

  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int r = 91;
    for (int i = 0; i < 3; i++) {
      if (i % 2 == 1) {
        r += scanner.nextInt() * 3;
      } else {
        r += scanner.nextInt();
      }
    }

    System.out.println("The 1-3-sum is " + r);
    scanner.close();
  }
}
