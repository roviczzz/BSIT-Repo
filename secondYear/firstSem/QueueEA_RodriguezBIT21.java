import java.util.Queue;
import java.util.LinkedList;
import java.util.Scanner;
import java.util.Stack;


public class QueueEA_RodriguezBIT21 {
    public static void operation(Queue<Integer>myQue, int base){
        Stack<Integer> myStack = new Stack<>();

        while(base != 0){ //Push remainder to queue
            myQue.add(base % 2);
            base /=2;
        }

        while(!myQue.isEmpty()){ //Temporarily push queue elements to a stack for reverse conversion
            myStack.push(myQue.poll());
        }

        while(!myStack.isEmpty()){ //Push stack (reversed) elements to queue
            myQue.add(myStack.pop());
        }

        System.out.println("Binary form: "); //Print reverse queue
        while(!myQue.isEmpty()){
            System.out.print(myQue.poll());
        }

    }

    public static void main(String[] args) {
        Queue <Integer> myQue = new LinkedList<>();
        Scanner sc = new Scanner(System.in);

        System.out.println("Binary Conversion");
        System.out.print("Input number: ");
        int base = sc.nextInt();
        operation(myQue, base);




    }



}
