import java.util.Scanner;

public class nodeDriver {

    public static void insertNode(Node node, int value) {

        if (value > node.data) {
            if (node.right == null) {
                node.right = new Node(value);
//                System.out.println("Inserted " + value + " at the right of " + node.data);
            } else {
                insertNode(node.right, value);
                insertNode(node.right, value);
            }
        }
    }

    public static void printTree(Node node){
        if (node!=null){
            System.out.print(node.data + "-");
            printTree(node.right);
        }
    }

    static int sum = 0;
    public static int nodeSum(Node node){
        if (node != null){

            int data = node.data;
            sum = sum + node.data;

            nodeSum(node.left);
            nodeSum(node.right);
        }
        return sum;
    }

    public static void main(String[] args) {
        Node root = new Node(10);
        Scanner sc = new Scanner(System.in);
        int operation = 0;
        int insertValue = 0;
        int sumNode = 0;

        while(operation != 3) {
            System.out.println("\nSelect Operation: ");

            System.out.println("[1] - Insert Node");
            System.out.println("[2] - Sum of nodes data");
            System.out.println("[3] - Terminate program");
            operation = sc.nextInt();
            switch (operation) {
                case 1:
                    System.out.println("Input value to be inserted: ");
                    insertValue = sc.nextInt();
                    insertNode(root, insertValue);
                    printTree(root);
                    break;

                case 2:
                    System.out.println("Sum of Nodes' data: ");
                    System.out.println(nodeSum(root));
            }
        }



    }
}
