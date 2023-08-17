import java.util.*;

public class LabWeek1_RodriguezBIT11 {

    public static int[] randomNumberGen(int n) {
        int[] arr = new int[n];

        for (int i = 0; i < n; i++) {
            arr[i] = (int) (Math.random() * 20 + 1);

            for (int j = 0; j < i; j++) {
                if (arr[i] == arr[j]) {
                    i--; //if a[i] is a duplicate of a[j], then run the outer loop on i again
                    break;
                }
            }
        }

        return arr;
    }

    public static void main(String[] args) {
        int arrSize;
        int[] arr;
        System.out.println("Provide array size: ");
        Scanner sc = new Scanner(System.in);

        arrSize = sc.nextInt();

        if(arrSize < 21) {
            arr = randomNumberGen(arrSize);
            System.out.println(Arrays.toString(arr)); //output method
        }

        else
        System.out.println("invalid size"); //output method

    }
}