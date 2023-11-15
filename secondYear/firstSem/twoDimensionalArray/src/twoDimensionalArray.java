import java.util.Scanner;

public class twoDimensionalArray {

    static int row1, col1, row2, col2;


    public static void main(String[] args) {
        System.out.println("Enter 2D array size (Rows)(Columns): ");
        Scanner sc = new Scanner(System.in);

        int rows = sc.nextInt();
        int columns = sc.nextInt();

        System.out.println("Enter array 1 values: ");
        int[][] twoArr1 = new int[rows][columns];


        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                twoArr1[i][j] = sc.nextInt();
            }
        }

        System.out.print("\nArray 1: \n");
        for (int[] x : twoArr1) {
            for (int y : x) {
                System.out.print(y + " ");
            }
            System.out.println();
        }


        System.out.println("Enter array 2 values: ");
        int[][] twoArr2 = new int[rows][columns];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                twoArr2[i][j] = sc.nextInt();
            }
        }

        System.out.print("\nArray 2: \n");
        for (int[] x : twoArr1) {
            for (int y : x) {
                System.out.print(y + " ");
            }
            System.out.println("\n");
        }

        row1 = twoArr1.length;
        col1 = twoArr1[0].length;

        row2 = twoArr2.length;
        col2 = twoArr2[0].length;

        int[][] prod = new int[row1][col2];

        //Performs product of matrices a and b. Store the result in matrix prod
        for (int j = 0; j < row1; j++) {
            for (int i = 0; i < col2; i++) {
                for (int k = 0; k < row2; k++) {
                    prod[i][j] = prod[i][j] + twoArr1[i][k] * twoArr2[k][j];
                }
            }
        }

        System.out.println("Product of array 1 and 2: ");
        for (int j = 0; j < row1; j++) {
            for (int i = 0; i < col2; i++) {
                System.out.print(prod[i][j] + " ");
            }
            System.out.println();
        }
    }
}
