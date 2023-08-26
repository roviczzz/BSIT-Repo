import  java.util.Scanner;

public class doWhileSUM {
    public static void main(String[] args) {
        // Your math teacher asked you to calculate the sum of the numbers 1 to N, where N is a given number.
      
        // Task: Take an integer N from input and output the sum of the numbers 1 to N, inclusive.

        // Sample Input: 10
        // Sample Output: 55
      
        int inp;
        Scanner sc = new Scanner(System.in);
        inp = sc.nextInt();
        
        int i = 0; // start from iteration zero
        int m = 1; // add increment
        int n = 0; // final number
        do{
            n += m; // n = 0 + 1
            m++; // increment
            i++; // iteration increment

        }
        while(i < inp);
        System.out.println(n); // output SUM
    }

}
