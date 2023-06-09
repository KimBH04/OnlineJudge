import java.util.Scanner;

public class Main {

  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int n = scanner.nextInt();
    int[] r = new int[n];
    int[][] body = new int[n][2];
    for (int i = 0; i < n; i++) {
      r[i] = 1;
      body[i][0] = scanner.nextInt();
      body[i][1] = scanner.nextInt();
    }

    for (int i = 0; i < n; i++) {
      for (int j = 0; j < n; j++) {
        if (body[j][0] > body[i][0] && body[j][1] > body[i][1]) {
          r[i]++;
        }
      }
    }

    for (int i = 0; i < n; i++) {
      System.out.print(r[i] + " ");
    }

    scanner.close();
  }
}
