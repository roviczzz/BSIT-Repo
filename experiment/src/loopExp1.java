import java.lang.*;
import java.util.Scanner;

public class loopExp1 {

    public static void main(String[] args) {

        // nested do while loop
        // output:
        // 55555
        // 4444
        // 333
        // 22
        // 1

        int numInput, countIn, countOut;
        Scanner sc = new Scanner(System.in);

        System.out.println("How many?: ");
        numInput = sc.nextInt();

        countOut = numInput;

        do {
            countIn = countOut;

            do {
                System.out.print(countOut);
                countIn--;
            }

            while (countIn >= 1);
            System.out.println("");
            countOut--;
        }

        while (countOut>=1);

        System.out.println("");
        System.out.println("");
        System.out.println("Tracing final:");
        System.out.println("countIn: " + countIn);
        System.out.println("countOut: " + countOut);




    }

}
