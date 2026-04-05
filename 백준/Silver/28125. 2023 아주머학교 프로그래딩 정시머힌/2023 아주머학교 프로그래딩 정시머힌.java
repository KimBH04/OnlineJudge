import java.util.ArrayList;
import java.util.Scanner;

public class Main {

  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);
    int n = scanner.nextInt();
    scanner.nextLine();

    while (n-- > 0) {
      int pogiCnt = 0;
      ArrayList<Character> result = new ArrayList<Character>();
      String s = scanner.nextLine();
      int len = s.length();
      for (int i = 0; i < len; i++) {
        char c = s.charAt(i);
        switch (c) {
          case '@':
            result.add('a');
            pogiCnt++;
            break;
          case '[':
            result.add('c');
            pogiCnt++;
            break;
          case '!':
            result.add('i');
            pogiCnt++;
            break;
          case ';':
            result.add('j');
            pogiCnt++;
            break;
          case '^':
            result.add('n');
            pogiCnt++;
            break;
          case '0':
            result.add('o');
            pogiCnt++;
            break;
          case '7':
            result.add('t');
            pogiCnt++;
            break;
          case '\\':
            if (s.charAt(i + 1) == '\'') {
              result.add('v');
              i += 1;
            } else if (s.charAt(i + 1) == '\\' && s.charAt(i + 2) == '\'') {
              result.add('w');
              i += 2;
            }
            pogiCnt++;
            break;
          default:
            result.add(c);
            break;
        }
      }

      if (result.size() <= pogiCnt * 2) {
        System.out.println("I don't understand");
      } else {
        for (Character character : result) {
          System.out.print(character);
        }
        System.out.println();
      }
    }
    scanner.close();
  }
}
