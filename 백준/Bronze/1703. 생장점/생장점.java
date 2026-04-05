import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class Main {
    public static void main(String[] args) throws Exception {
        BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
        while (true) {
            StringTokenizer st = new StringTokenizer(bf.readLine());
            int n = Integer.parseInt(st.nextToken());
            if (n == 0) {
                break;
            }

            int l = 1;
            while (n-- > 0) {
                int g = Integer.parseInt(st.nextToken());
                int c = Integer.parseInt(st.nextToken());
                l *= g;
                l -= c;
            }

            System.out.println(l);
        }
    }
}
