import java.math.BigInteger;
import java.util.Scanner;

public class Main {

  static BigInteger Factorial(BigInteger n) {
    if (n.intValue() == 1) {
      return new BigInteger("1");
    }
    return n.multiply(Factorial(n.subtract(new BigInteger("1"))));
  }

  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);
    int n = scanner.nextInt();
    int m = scanner.nextInt();
    BigInteger r = Factorial(new BigInteger(n + ""))
      .divide(Factorial(new BigInteger(n - m + "")))
      .divide(Factorial(new BigInteger(m + "")));
    System.out.println(r.toString());
    scanner.close();
  }
}
