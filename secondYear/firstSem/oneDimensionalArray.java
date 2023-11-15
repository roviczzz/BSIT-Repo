import java.util.Arrays;
import java.util.Scanner;

public class oneDimensionalArray {

    static int ctr1 = 1; // index counter
    static int ctr2 = 1; // index counter
    static int ctr3 = 1; // index counter
    static int[] R1; // array1
    static int[] R2; // array2
    static int[] R3; // array3 for merging of array1 & array2
    static int N1; // array1 size
    static int N2; // array2 size


    public static void randomArray1(int n) {
        int[] arr = new int[n];
        for (int i = 0; i < arr.length; i++) {
            arr[i] = (int) Math.floor(Math.random() * 51); // random number generator up to 50
        }
        R1 = arr;
    }

        public static void randomArray2(int n){
        int[] arr = new int[n];
        for (int i = 0; i < arr.length; i++) {
            arr[i] = (int) Math.floor(Math.random() * 51); // random number generator up to 50
        }
        R2 = arr;
    }

    public static void Merge_Array(int[] R1, int[] R2, int N1, int N2) {
        ctr1 = 0; // Initialize ctr1 to 0
        ctr2 = 0; // Initialize ctr2 to 0
        ctr3 = 0; // Initialize ctr3 to 0

        while (ctr1 < N1 && ctr2 < N2) {
            if (R1[ctr1] < R2[ctr2])
                Copy_from_R1();
            else
                Copy_from_R2();
        }

        while (ctr1 < N1) {
            Copy_from_R1();
        }

        while (ctr2 < N2) {
            Copy_from_R2();
        }
    }

    public static void Copy_from_R1() {
        R3[ctr3] = R1[ctr1];
        ctr1++;
        ctr3++; // Increment ctr3 to keep track of the next available index in R3
    }

    public static void Copy_from_R2() {
        R3[ctr3] = R2[ctr2];
        ctr2++;
        ctr3++; // Increment ctr3 to keep track of the next available index in R3
    }

    public static void main(String[]args){
        System.out.println("RANDOM GENERATED (up to 50) - ONE DIMENSIONAL ARRAY");
        Scanner sc = new Scanner(System.in);
        System.out.println("Provide array 1 size: ");
        int size1 = sc.nextInt();
        System.out.println("Provide array 2 size: ");
        int size2 = sc.nextInt();
        randomArray1(size1);
        randomArray2(size2);


        N1 = R1.length; // N1 is equal to array length of R1
        N2 = R2.length; // N2 is equal to array length of R2
        int length = N1 + N2;
        R3 = new int[length];

        Merge_Array(R1, R2, N1, N2);
        System.out.println("First array: " + Arrays.toString(R1));
        System.out.println("Second array: " + Arrays.toString(R2));
        System.out.println("Merged array: " + Arrays.toString(Arrays.stream(R3).sorted().toArray()));



        }
}