import java.io.*;
import java.util.*;

public class Main {

  public static void main(String[] args) throws Exception {
    BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));

    StringTokenizer st = new StringTokenizer(bf.readLine());
    int s = Integer.parseInt(st.nextToken());
    int p = Integer.parseInt(st.nextToken());

    String dna = bf.readLine();
    int[] A = new int[s];
    int[] C = new int[s];
    int[] G = new int[s];
    int[] T = new int[s];
    for (int i = 0; i < s; i++) {
      char j = dna.charAt(i);
      A[i] = j == 'A' ? 1 : 0;
      C[i] = j == 'C' ? 1 : 0;
      G[i] = j == 'G' ? 1 : 0;
      T[i] = j == 'T' ? 1 : 0;
    }

    st = new StringTokenizer(bf.readLine());
    int a = Integer.parseInt(st.nextToken());
    int c = Integer.parseInt(st.nextToken());
    int g = Integer.parseInt(st.nextToken());
    int t = Integer.parseInt(st.nextToken());

    int r = 0;
    int[] DNA = { 0, 0, 0, 0 };
    for (int i = 0; i < p; i++) {
      DNA[0] += A[i];
      DNA[1] += C[i];
      DNA[2] += G[i];
      DNA[3] += T[i];
    }

    for (int i = 0; i <= s - p; i++) {
      if (DNA[0] >= a && DNA[1] >= c && DNA[2] >= g && DNA[3] >= t) {
        r++;
      }

      if (i != s - p) {
        DNA[0] -= A[i] - A[p + i];
        DNA[1] -= C[i] - C[p + i];
        DNA[2] -= G[i] - G[p + i];
        DNA[3] -= T[i] - T[p + i];
      }
    }

    bw.write(String.valueOf(r));

    bf.close();
    bw.close();
  }
}
