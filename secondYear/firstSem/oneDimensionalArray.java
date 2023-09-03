import java.util.Arrays;

public class oneDimensionalArray {

    static int ctr1 = 1; // index counter
    static int ctr2 = 1; // index counter
    static int ctr3 = 1; // index counter
    static int[] R1; // array1 with fixed size of 5, random elements up to 50
    static int[] R2; // array2 with fixed size of 5, random elements up to 50
    static int[] R3; // array3 for merging of array1 & array2
    static int N1; // array1 first element
    static int N2; // array1 first element


    public static void randomArray1() {
        int[] arr = new int[2];
        for (int i = 0; i < arr.length; i++) {
            arr[i] = (int) Math.floor(Math.random() * 51); // storing random integers in an array
            //R1 = arr;
        }
        R1 = arr;

    }

        public static void randomArray2(){
            int[] arr = new int[2];
            for (int i = 0; i < arr.length; i++) {
                arr[i] = (int) Math.floor(Math.random() * 51); // storing random integers in an array up to 50
                //R2 = arr;
            }
            R2 = arr;

        }

    public static void Merge_Array(int[] R1, int[] R2, int N1, int N2) {
        ctr1 = 0; // Initialize ctr1 to 0
        ctr2 = 0; // Initialize ctr2 to 0
        ctr3 = 0; // Initialize ctr3 to 0

        while (ctr1 < N1 && ctr2 < N2) {

            if(R1[ctr1] < R2[ctr2])
                Copy_from_R1();
//            if (ctr1 > N1)
//                Copy_from_R1();

            else
                Copy_from_R2();

            {

                if (R1[ctr1] < R2[ctr2])
                    Copy_from_R1();


                else
                    Copy_from_R2();

            }
            ctr3++;
        }
    }


    public static void Copy_from_R1(){
        R3[ctr3] = R1[ctr1];
        ctr1++;
        ctr3++;
    }

    public static void Copy_from_R2(){
        R3[ctr3] = R2[ctr2];
        ctr2++;
        ctr3++;
    }


    public static void main(String[]args){
        System.out.println("ONE DIMENSIONAL ARRAY");
        randomArray1();
        randomArray2();
        N1 = R1.length; // N1 is equal to array length of R1
        N2 = R2.length; // N2 is equal to array length of R2
        int length = N1 + N2;
        R3 = new int[length];

        Merge_Array(R1, R2, N1, N2);
        System.out.println(Arrays.toString(R3));




        }
}



//TODO FINAL WORKING CODE, ALTERED VERSION
//import java.util.Arrays;
//
//public class OneDimensionalArray {
//    static int[] R1;
//    static int[] R2;
//    static int[] R3;
//    static int N1;
//    static int N2;
//
//    public static void randomArray1() {
//        int[] arr = new int[3];
//        for (int i = 0; i < arr.length; i++) {
//            arr[i] = (int) Math.floor(Math.random() * 51);
//        }
//        R1 = arr;
//    }
//
//    public static void randomArray2() {
//        int[] arr = new int[3];
//        for (int i = 0; i < arr.length; i++) {
//            arr[i] = (int) Math.floor(Math.random() * 51);
//        }
//        R2 = arr;
//    }
//
//    public static void Merge_Array(int[] R1, int[] R2) {
//        N1 = R1.length;
//        N2 = R2.length;
//
//        int length = N1 + N2;
//        R3 = new int[length];
//
//        int ctr1 = 0;
//        int ctr2 = 0;
//        int ctr3 = 0;
//
//        // Merge R1 and R2 into R3 without sorting
//        while (ctr1 < N1 && ctr2 < N2) {
//            if (R1[ctr1] < R2[ctr2]) {
//                R3[ctr3] = R1[ctr1];
//                ctr1++;
//            } else {
//                R3[ctr3] = R2[ctr2];
//                ctr2++;
//            }
//            ctr3++;
//        }
//
//        // Copy any remaining elements from R1 and R2
//        while (ctr1 < N1) {
//            R3[ctr3] = R1[ctr1];
//            ctr1++;
//            ctr3++;
//        }
//
//        while (ctr2 < N2) {
//            R3[ctr3] = R2[ctr2];
//            ctr2++;
//            ctr3++;
//        }
//    }
//
//    public static void main(String[] args) {
//        System.out.println("ONE DIMENSIONAL ARRAY");
//        randomArray1();
//        randomArray2();
//
//        Merge_Array(R1, R2);
//
//        // Sort the merged array R3
//        Arrays.sort(R3);
//
//        System.out.println(Arrays.toString(R3));
//    }
//}