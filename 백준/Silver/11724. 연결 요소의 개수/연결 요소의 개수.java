import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        int m = scanner.nextInt();

        ArrayList<Integer>[] node = new ArrayList[n + 1];
        boolean[] visited = new boolean[n + 1];
        for (int i = 0; i <= n; i++) {
            visited[i] = false;
            node[i] = new ArrayList<Integer>();
        }

        while (m-- > 0) {
            int u = scanner.nextInt();
            int v = scanner.nextInt();

            node[u].add(v);
            node[v].add(u);
        }
        scanner.close();
        
        int r = 0;
        for (int i = 1; i <= n; i++) {
            if (!visited[i]) {
                r++;
                Queue<Integer> q = new LinkedList<>();
                q.offer(i);
                visited[i] = true;

                while (!q.isEmpty()) {
                    int x = q.poll();

                    for (Integer integer : node[x]) {
                        if (!visited[integer]) {
                            visited[integer] = true;
                            q.offer(integer);
                        }
                    }
                }
            }
        }

        System.out.println(r);
    }
}
