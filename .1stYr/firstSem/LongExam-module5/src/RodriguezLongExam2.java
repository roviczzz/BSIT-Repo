import java.util.Scanner;

public class RodriguezLongExam2 {
    public static void main(String[] args) {
        // Enter Input
        int numInput, countIn, countOut;
        Scanner sc = new Scanner(System.in);

        System.out.println("How many?: ");
        numInput = sc.nextInt();

        // assignment to recognize inside outside loop through variable "countOut"
        countOut = numInput;

        // Outside DO, assign "countOut" to "countIn"
        do {
            countIn = countOut;

            // Inside DO, countIn message & countIn--
            do {
                System.out.print("" + countIn);
                countIn--;
            }

            // Inside WHILE, while countIn >= 1 is true, countOut--, goes outside loop when false
            while (countIn >= 1);
            countOut--;
            System.out.println("");
        }

        // Outside WHILE, while countOut >= 1 is ture, none, terminate operation when false
        while (countOut>=1);

    }
}
