import java.util.Scanner;

public class RodriguezLongExam1 {

    public static void main(String[] args) {
        // Enter Input
        int numInput;
        Scanner sc = new Scanner(System.in);

        System.out.println("How many?: ");
        numInput = sc.nextInt();


        // Outside for loop, countOut = numInput, operate when inside loop is finished, until count >= 1 is false then *println* none
        for (int countOut = numInput; countOut >= 1; countOut--)
        {

        // Inside for loop, countIn = 1, *print* countIn, count++, until countIn <= countOut is false
        for (int countIn = 1; countIn <= countOut; countIn++)
        {
            System.out.print(countIn);
        }
            System.out.println("");

        }




    }
}
