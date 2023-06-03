import java.io.*;
import java.util.*;

public class Main {

  static boolean[] v;

  public static void main(String[] args) throws Exception {
    BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    StringTokenizer st = new StringTokenizer(bf.readLine());

    int n = Integer.parseInt(st.nextToken());
    int m = Integer.parseInt(st.nextToken());
    int a = Integer.parseInt(st.nextToken());
    int b = Integer.parseInt(st.nextToken());

    v = new boolean[n + 1];

    while (m-- > 0) {
      st = new StringTokenizer(bf.readLine());
      int l = Integer.parseInt(st.nextToken());
      int r = Integer.parseInt(st.nextToken());

      if (l > r) {
        int temp = l;
        l = r;
        r = temp;
      }

      for (int i = l; i <= r; i++) {
        v[i] = true;
      }
    }

    int total = BreathFirstSearch(n, a, b);
    System.out.println(total);
    bf.close();
  }

  static int BreathFirstSearch(int n, int a, int b) {
    Queue<Integer> q = new LinkedList<>();
    v[0] = true;
    q.add(0);
    int r = 0;
    while (!q.isEmpty()) {
      int size = q.size();
      while (size-- > 0) {
        int e = q.poll();
        if (n == e) {
          return r;
        }

        if (e + a <= n) {
          if (!v[e + a]) {
            v[e + a] = true;
            q.add(e + a);
          }
        }

        if (e + b <= n) {
          if (!v[e + b]) {
            v[e + b] = true;
            q.add(e + b);
          }
        }
      }

      r++;
    }

    return -1;
  }
}
