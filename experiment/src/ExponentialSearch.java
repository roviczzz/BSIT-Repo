public class ExponentialSearch {
    static Scanner console = new Scanner(System.in);
    
    
    public static int exponentialSearch(int arr[], int x) {
        int n = arr.length;

        if (arr[0] == x)
            return 0;

        int i = 1;
        while (i < n && arr[i] <= x)
            i = i * 2;

        return binarySearch(arr, x, i / 2, Math.min(i, n - 1));
    }
    

 public static int binarySearch(int arr[], int x, int left, int right) {
        if (right >= left) {
            int mid = left + (right - left) / 2;

            if (arr[mid] == x)
                return mid;

            if (arr[mid] > x)
                return binarySearch(arr, x, left, mid - 1);

            return binarySearch(arr, x, mid + 1, right);
        }

        return -1;
    }
 
 
    public static void main(String[] args) {
        
        int arr[] = {2,4,6,8,10,12,14,16,18,20};
        System.out.println("Array: " + Arrays.toString(arr));
        System.out.print("Element to search: ");
        int x = console.nextInt();
        
        int index = exponentialSearch(arr, x);
        if (index == -1)
            System.out.println("Element not found in the array");
        else
             System.out.println("Element found at index: " + index);
    }
}
