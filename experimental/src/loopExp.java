import java.lang.*;
import java.util.Scanner;

public class loopExp {

    public static void main(String[] args) {

        // nested for loop
        // output:
        // 55555
        // 4444
        // 333
        // 22
        // 1

        int numInput;
        Scanner sc = new Scanner(System.in);

        System.out.println("input number");
        numInput = sc.nextInt();

        for (int io = numInput; io >= 1; io--) {

            for (int i = 1; i <= io; i++) {
                System.out.print(io);
            }
            System.out.println("");
        }
        System.out.println("loop finished");
        System.exit(0);



    }

}
