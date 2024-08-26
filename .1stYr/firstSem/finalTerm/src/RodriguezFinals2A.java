import java.util.Scanner;
import java.io.*;

public class RodriguezFinals2A {
    public static void main(String[] args) {
        int num, x, y = 1;

        Scanner sc = new Scanner(System.in);
        System.out.println("What is the value of N?: ");
        num = sc.nextInt();

        for (x = 1; x<=num; x++){
            y = y * x;

        }
        System.out.println("The Factorial of " + num + " is " + y);
    }


}
