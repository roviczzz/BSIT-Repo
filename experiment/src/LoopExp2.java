import java.lang.*;
import java.util.Scanner;


public class LoopExp2 {
    public static void main(String[] args) {
        // nested do while loop
        // output:
        // 55555
        // 4444
        // 333
        // 22
        // 1

        int numInput, i, io;
        Scanner sc = new Scanner(System.in);
        System.out.println("input number: ");
        numInput = sc.nextInt();

        io = numInput;

        do {
            i = io;
            do {
                System.out.print(io);
                i--;
            } while (i >= 1);
            System.out.println("");
            io--;

        } while (io >= 1);


    }

}
