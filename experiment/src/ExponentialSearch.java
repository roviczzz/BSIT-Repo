public class ExponentialSearch {
    public static int exponentialSearch(int[] arr, int target) {
        if (arr[0] == target) {
            return 0;
        }
        
        int i = 1;
        int n = arr.length;
        
        while (i < n && arr[i] <= target) {
            i *= 2;
        }
        
        return binarySearch(arr, i/2, Math.min(i, n-1), target);
    }
    
    private static int binarySearch(int[] arr, int low, int high, int target) {
        while (low <= high) {
            int mid = low + (high - low) / 2;
            
            if (arr[mid] == target) {
                return mid;
            }
            
            if (arr[mid] < target) {
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }
        
        return -1;
    }
    
    public static void main(String[] args) {
        int[] arr = {2, 5, 7, 12, 16, 23, 36, 42, 56};
        int target = 23;
        
        int index = exponentialSearch(arr, target);
        
        if (index != -1) {
            System.out.println("Element found at index " + index);
        } else {
            System.out.println("Element not found in the array");
        }
    }
}
