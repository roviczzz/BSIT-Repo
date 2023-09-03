import java.util.Arrays;
import java.util.Scanner;

public class MyInsertionSort {
    public static void insertionSort(int[] arr) {//insertionSort method
        int n = arr.length;//array length
        for (int i = 1; i < n; i++) {//initialize int i = 1, loop until i
            int key = arr[i];
            int k = i - 1;

            while (k >= 0 && arr[k] > key) {
                arr[k + 1] = arr[k];
                k--;
            }
            arr[k + 1] = key;
        }
    }


    public static void main(String[] args) {
        int arr[] = {9, 21, 7, 8, 15};

        System.out.print("Provided set of array: " + Arrays.toString(arr));
        insertionSort(arr);
        System.out.println("Sorted array:");
        for (int num : arr) {
            System.out.print(num + " ");
        }
    }

}