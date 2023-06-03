import java.util.*;

public class Main {

  static int f, s, g, u, d;
  static boolean[] v;

  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);
    StringTokenizer st = new StringTokenizer(scanner.nextLine());
    f = Integer.parseInt(st.nextToken());
    s = Integer.parseInt(st.nextToken());
    g = Integer.parseInt(st.nextToken());
    u = Integer.parseInt(st.nextToken());
    d = Integer.parseInt(st.nextToken());

    v = new boolean[f + 1];

    int total = BreathFirstSearch();
    if (total < 0) {
      System.out.println("use the stairs");
    } else {
      System.out.println(total);
    }

    scanner.close();
  }

  static int BreathFirstSearch() {
    Queue<Integer> q = new LinkedList<>();
    v[s] = true;
    q.add(s);

    int r = 0;
    while (!q.isEmpty()) {
      int size = q.size();
      for (int i = 0; i < size; i++) {
        int e = q.poll();
        if (e == g) {
          return r;
        }

        if (e + u <= f) {
          if (!v[e + u]) {
            v[e + u] = true;
            q.add(e + u);
          }
        }

        if (e - d > 0) {
          if (!v[e - d]) {
            v[e - d] = true;
            q.add(e - d);
          }
        }
      }

      r++;
    }

    return -1;
  }
}
