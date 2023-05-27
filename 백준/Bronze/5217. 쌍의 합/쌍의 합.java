import java.util.Scanner;

public class Main {

  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);
    int t = scanner.nextInt();

    for (int i = 0; i < t; i++) {
      int n = scanner.nextInt();
      System.out.print("Pairs for " + n + ": ");

      StringBuilder sb = new StringBuilder();
      for (int j = 1; j < n - j; j++) {
        if (sb.length() > 0) {
          sb.append(", ");
        }

        sb.append(j + " " + (n - j));
      }

      System.out.println(sb);
    }

    scanner.close();
  }
}
