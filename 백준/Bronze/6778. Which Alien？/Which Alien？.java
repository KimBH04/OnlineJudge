import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int an = scan.nextInt();
        int ey = scan.nextInt();

        if (an >= 3 && ey <= 4) {
            System.out.println("TroyMartian");
        }

        if (an <= 6 && ey >= 2) {
            System.out.println("VladSaturnian");
        }

        if (an <= 2 && ey <= 3) {
            System.out.println("GraemeMercurian");
        }

        scan.close();
    }
}
