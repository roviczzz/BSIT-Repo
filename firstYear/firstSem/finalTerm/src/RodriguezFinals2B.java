import java.util.Scanner;

public class RodriguezFinals2B {

    public static void main(String[] args) {
        int num, x = 1, y = 1;

        Scanner sc = new Scanner(System.in);
        System.out.println("What is the value of N?: ");
        num = sc.nextInt();

        while (x <= num) {
            y = y * x;
            x++;

        }
        System.out.println("The Factorial of " + num + " is " + y);

    }

}
