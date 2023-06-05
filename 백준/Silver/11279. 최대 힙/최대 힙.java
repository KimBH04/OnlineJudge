import java.io.*;
import java.util.*;

public class Main {

  public static void main(String[] args) throws Exception {
    BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
    PriorityQueue<Integer> pq = new PriorityQueue<>();

    int n = Integer.parseInt(bf.readLine());
    while (n-- > 0) {
      int x = Integer.parseInt(bf.readLine());
      if (x == 0) {
        if (pq.isEmpty()) {
          bw.write(0 + "\n");
        } else {
          bw.write(-pq.poll() + "\n");
        }
      } else {
        pq.add(-x);
      }
    }

    bf.close();
    bw.close();
  }
}
