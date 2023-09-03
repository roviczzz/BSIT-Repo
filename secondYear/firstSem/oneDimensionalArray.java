public class oneDimensionalArray {

    static int ctr1 = 1; // index counter
    static int ctr2 = 1; // index counter
    static int ctr3 = 1; // index counter
    static int[] R1; // array1 with fixed size of 5, random elements up to 50
    static int[] R2; // array2 with fixed size of 5, random elements up to 50
    static int[] R3; // array3 for merging of array1 & array2
    static int N1; // array1 first element
    static int N2; // array1 first element


    public static int[] randomArray1() {
        int[] arr = new int[5];
        for (int i = 0; i < arr.length; i++) {
            arr[i] = (int) Math.floor(Math.random() * 51); // storing random integers in an array up to 50
        }
        return R1 = arr; // assign random generated array to R1
    }

        public static int[] randomArray2(){
            int[] arr = new int[5];
            for (int i = 0; i < arr.length; i++) {
                arr[i] = (int) Math.floor(Math.random() * 51); // storing random integers in an array up to 50
            }
            return R2 = arr; // assign random generated array to R2
    }

    public static int Merge_Array(int[] R1,int[] R2,int N1,int N2){ //merge algo

        while((ctr1<=N1) || (ctr2<=N2))
            {
             if (ctr1>N1)
                return Copy_from_R2();

            else
            {
                if (R1[ctr1] < R2[ctr2])
                    Copy_from_R1();
                else
                    Copy_from_R2();
            }
            ctr3++;
        }

        return 0;
    }

    public static int Copy_from_R1(){
        R3[ctr3] = R1[ctr1];
        return ctr1++;
            }

    public static int Copy_from_R2(){
        R3[ctr3] = R2[ctr2];
        return ctr2++;
            }


    public static void main(String[]args){
        System.out.println("ONE DIMENSIONAL ARRAY");
        randomArray1();
        randomArray2();

        //TODO assign N1, N2
        //TODO method

        System.out.println();




        }
}