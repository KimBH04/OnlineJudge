import java.util.Scanner;

public class Main {

  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);
    long l = scanner.nextLong();
    scanner.nextLong();
    long b = scanner.nextLong();
    long k = scanner.nextLong();

    long r = l / b + (l % b > 0 ? 1 : 0);
    System.out.println(r * b * k);
    scanner.close();
  }
}
