import java.util.*;

public class Main {

  public static void main(String[] args) throws Exception {
    Scanner scanner = new Scanner(System.in);
    int r = 0;
    for (int i = 0; i < 2; i++) {
      StringTokenizer st = new StringTokenizer(scanner.nextLine());
      int t = 0;
      for (int j = 0; j < 4; j++) {
        t += Integer.parseInt(st.nextToken());
      }
      r = r < t ? t : r;
    }
    System.out.println(r);
    scanner.close();
  }
}
