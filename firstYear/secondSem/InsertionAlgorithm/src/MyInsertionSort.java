import java.util.Arrays;
import java.util.Scanner;

public class MyInsertionSort {
    public static void insertionSort(int[] arr) {//insertionSort method
        int n = arr.length;//array length
        for (int i = 1; i < n; i++) {//
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key) {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
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